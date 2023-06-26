using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HidLibrary
{
	public class HidDevices
	{
		private static Guid _hidClassGuid = Guid.Empty;

		public static bool IsConnected(string devicePath)
		{
			return EnumerateDevices().Any(x => x.Path == devicePath);
		}

		public static HidDevice GetDevice(string devicePath)
		{
			return Enumerate(devicePath).FirstOrDefault();
		}

		public static IEnumerable<HidDevice> Enumerate()
		{
			return EnumerateDevices().Select(x => new HidDevice(x.Path, x.Description));
		}

		public static IEnumerable<HidDevice> Enumerate(string devicePath)
		{
			return EnumerateDevices().Where(x => x.Path == devicePath)
									 .Select(x => new HidDevice(x.Path, x.Description));
		}

		public static IEnumerable<HidDevice> Enumerate(int vendorId, params int[] productIds)
		{
			return EnumerateDevices().Select(x => new HidDevice(x.Path, x.Description))
									 .Where(x => x.Attributes.VendorId == vendorId
													&& productIds.Contains(x.Attributes.ProductId));
		}

		public static IEnumerable<HidDevice> Enumerate(int vendorId, int productId, ushort UsagePage)
		{
			return EnumerateDevices().Select(x => new HidDevice(x.Path, x.Description))
									 .Where(x => x.Attributes.VendorId == vendorId
													&& productId == (ushort)x.Attributes.ProductId
													&& (ushort)x.Capabilities.UsagePage == UsagePage);
		}

		public static IEnumerable<HidDevice> Enumerate(int vendorId)
		{
			return EnumerateDevices().Select(x => new HidDevice(x.Path, x.Description))
									 .Where(x => x.Attributes.VendorId == vendorId);
		}

		public static IEnumerable<HidDevice> Enumerate(ushort UsagePage)
		{
			return EnumerateDevices().Select(x => new HidDevice(x.Path, x.Description))
									 .Where(x => (ushort)x.Capabilities.UsagePage == UsagePage);
		}

		internal class DeviceInfo { public string Path { get; set; } public string Description { get; set; } }

		internal static IEnumerable<DeviceInfo> EnumerateDevices()
		{
			var devices = new List<DeviceInfo>();
			var hidClass = HidClassGuid;
			var deviceInfoSet = NativeMethods.SetupDiGetClassDevsW(ref hidClass, null, hwndParent: IntPtr.Zero, NativeMethods.DIGCF_PRESENT | NativeMethods.DIGCF_DEVICEINTERFACE);

			if (deviceInfoSet.ToInt64() != NativeMethods.INVALID_HANDLE_VALUE)
			{
				var deviceInfoData = CreateDeviceInfoData();
				var deviceIndex = 0;

				while (NativeMethods.SetupDiEnumDeviceInfo(deviceInfoSet, deviceIndex, ref deviceInfoData))
				{
					deviceIndex += 1;

					var deviceInterfaceData = new NativeMethods.SP_DEVICE_INTERFACE_DATA();
					deviceInterfaceData.cbSize = Marshal.SizeOf(deviceInterfaceData);
					var deviceInterfaceIndex = 0;

					while (NativeMethods.SetupDiEnumDeviceInterfaces(deviceInfoSet, ref deviceInfoData, ref hidClass, deviceInterfaceIndex, ref deviceInterfaceData))
					{
						deviceInterfaceIndex++;
						var devicePath = GetDevicePath(deviceInfoSet, deviceInterfaceData);
						var description = GetBusReportedDeviceDescription(deviceInfoSet, ref deviceInfoData) ??
										  GetDeviceDescription(deviceInfoSet, ref deviceInfoData);
						devices.Add(new DeviceInfo { Path = devicePath, Description = description });
					}
				}
				NativeMethods.SetupDiDestroyDeviceInfoList(deviceInfoSet);
			}
			return devices;
		}

		private static NativeMethods.SP_DEVINFO_DATA CreateDeviceInfoData()
		{
			var deviceInfoData = new NativeMethods.SP_DEVINFO_DATA();

			deviceInfoData.cbSize = Marshal.SizeOf(deviceInfoData);
			deviceInfoData.DevInst = 0;
			deviceInfoData.ClassGuid = Guid.Empty;
			deviceInfoData.Reserved = IntPtr.Zero;

			return deviceInfoData;
		}

		private static string GetDevicePath(IntPtr deviceInfoSet, NativeMethods.SP_DEVICE_INTERFACE_DATA deviceInterfaceData)
		{
			string devicePath = null;
			IntPtr detailData = IntPtr.Zero;
			var bufferSize = 0;

			NativeMethods.SetupDiGetDeviceInterfaceDetailW(deviceInfoSet, ref deviceInterfaceData, detailData, 0, ref bufferSize, IntPtr.Zero);
			if (bufferSize > 0)
			{
				int structSize = Marshal.SystemDefaultCharSize;
				if (IntPtr.Size == 8)
					structSize += 6;  // 64-bit systems, with 8-byte packing
				else
					structSize += 4; // 32-bit systems, with byte packing

				detailData = Marshal.AllocHGlobal(bufferSize + structSize);
				Marshal.WriteInt32(detailData, structSize);
				bool success = NativeMethods.SetupDiGetDeviceInterfaceDetailW(deviceInfoSet, ref deviceInterfaceData, detailData, bufferSize, ref bufferSize, IntPtr.Zero);
				if (success)
				{
					devicePath = Marshal.PtrToStringUni(new IntPtr(detailData.ToInt64() + 4));
				}
				Marshal.FreeHGlobal(detailData);
			}

			return devicePath;
		}

		private static Guid HidClassGuid
		{
			get
			{
				if (_hidClassGuid.Equals(Guid.Empty)) NativeMethods.HidD_GetHidGuid(ref _hidClassGuid);
				return _hidClassGuid;
			}
		}

		private static string GetDeviceDescription(IntPtr deviceInfoSet, ref NativeMethods.SP_DEVINFO_DATA devinfoData)
		{
			unsafe
			{
				const int charCount = 1024;
				var descriptionBuffer = stackalloc char[charCount];

				var requiredSize = 0;
				var type = 0;

				if (NativeMethods.SetupDiGetDeviceRegistryPropertyW(deviceInfoSet,
					ref devinfoData,
					NativeMethods.SPDRP_DEVICEDESC,
					ref type,
					descriptionBuffer,
					propertyBufferSize: charCount * sizeof(char),
					ref requiredSize))
				{
					return new string(descriptionBuffer);
				}

				return null; // No device description found
			}
		}

		private static string GetBusReportedDeviceDescription(IntPtr deviceInfoSet, ref NativeMethods.SP_DEVINFO_DATA devinfoData)
		{
			unsafe
			{
				const int charCount = 1024;
				var descriptionBuffer = stackalloc char[charCount];

				if (Environment.OSVersion.Version.Major > 5)
				{
					uint propertyType = 0;
					var requiredSize = 0;

					if (NativeMethods.SetupDiGetDevicePropertyW(deviceInfoSet,
						ref devinfoData,
						ref NativeMethods.DEVPKEY_Device_BusReportedDeviceDesc,
						ref propertyType,
						descriptionBuffer,
						propertyBufferSize: charCount * sizeof(char),
						ref requiredSize,
						0))
					{
						return new string(descriptionBuffer);
					}
				}

				return null; // No device description found
			}
		}
	}
}
