using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

using HidLibrary;

namespace MiniKeyboard48
{
	public class Report
	{
		public readonly byte reportID;
		public readonly byte[] reportBuff;

		public Report(byte id, byte[] arrayBuff)
		{
			reportID = id;
			reportBuff = arrayBuff;
		}
	}

	public enum HID_RETURN
	{
		SUCCESS,
		NO_DEVICE_CONNECTED,
		DEVICE_NOT_FOUND,
		DEVICE_OPENED,
		WRITE_FAILED,
		READ_FAILED,
	}

	public class HidOperations
	{
		public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
		
		private FileStream deviceReadWriteStream;

		private HidDevice selectedDevice;
		public HidDevice SelectedDevice() => selectedDevice;

		// Used to signal readiness in Stream Write Mode
		private bool deviceIsOpen;
		public bool IsOpen() => deviceIsOpen;

		private int outputReportLength;
		public int OutputReportLength() => outputReportLength;

		private int inputReportLength;
		public int InputReportLength() => inputReportLength;

		// Used to signal readiness in Report Write Mode
		private bool deviceIsReady;
		public bool IsReady() => deviceIsReady;

		public bool ConnectReportMode()
		{
			foreach (HidDevice hidDevice in HidDevices.Enumerate(4489, 34960).ToList())
			{
				if (hidDevice.DevicePath.IndexOf("mi_01") != -1)
				{
					selectedDevice = hidDevice;
					selectedDevice.OpenDevice();
					selectedDevice.MonitorDeviceEvents = true;
					deviceIsReady = true;
					return true;
				}
			}
			return false;
		}

		public IntPtr ConnectStreamMode()
		{
			if (deviceIsOpen)
				return INVALID_HANDLE_VALUE;

			foreach (HidDevice hidDevice in HidDevices.Enumerate(4489, 34960).ToList())
			{
				selectedDevice = hidDevice;
				selectedDevice.OpenDevice();
				deviceIsOpen = selectedDevice.IsOpen;

				outputReportLength = selectedDevice.Capabilities.OutputReportByteLength;
				inputReportLength = selectedDevice.Capabilities.InputReportByteLength;

				deviceReadWriteStream = new FileStream(
					new SafeFileHandle(selectedDevice.ReadHandle, false),
					FileAccess.ReadWrite,
					inputReportLength,
					true
				);
				BeginAsyncRead();
				return selectedDevice.ReadHandle;
			}
			return INVALID_HANDLE_VALUE;
		}

		private void BeginAsyncRead()
		{
			byte[] numArray = new byte[inputReportLength];
			var handle = deviceReadWriteStream.SafeFileHandle;
			deviceReadWriteStream.BeginRead(numArray, 0, inputReportLength, new AsyncCallback(ReadCompleted), numArray);
		}

		private void ReadCompleted(IAsyncResult iResult)
		{
			byte[] asyncState = (byte[])iResult.AsyncState;
			try
			{
				if (!deviceIsOpen)
					return;

				deviceReadWriteStream.EndRead(iResult);
				byte[] arrayBuff = new byte[asyncState.Length - 1];

				for (int index = 1; index < asyncState.Length; ++index)
					arrayBuff[index - 1] = asyncState[index];

				OnDataReceived(new Report(asyncState[0], arrayBuff));

				BeginAsyncRead();
			}
			catch (IOException ex)
			{
				OnDeviceRemoved(new EventArgs());
			}
		}

		// WriteMode == 0
		public HID_RETURN WriteToStream(byte reportId, byte[] reportBuff)
		{
			if (selectedDevice.IsOpen)
			{
				try
				{
					byte[] buffer = new byte[outputReportLength];
					buffer[0] = reportId;
					int num = reportBuff.Length >= outputReportLength - 1 ? outputReportLength - 1 : reportBuff.Length;

					for (int index = 1; index <= num; ++index)
						buffer[index] = reportBuff[index - 1];
					deviceReadWriteStream.Write(buffer, 0, 65);

					return HID_RETURN.SUCCESS;
				}
				catch (Exception ex)
				{
					throw new Exception("Error writing buffer.", ex);
				}
			}
			return HID_RETURN.WRITE_FAILED;
		}

		// WriteMode == 1
		public bool WriteToDevice(byte reportId, byte[] reportBuff)
		{
			HidDeviceReport report = selectedDevice.CreateReport();
			report.ReportId = reportId;
			report.Data[0] = reportBuff[0];
			report.Data[1] = reportBuff[1];
			report.Data[2] = reportBuff[2];
			report.Data[3] = reportBuff[3];
			report.Data[4] = reportBuff[4];
			report.Data[5] = reportBuff[5];
			report.Data[6] = reportBuff[6];
			report.Data[7] = reportBuff[7];
			return selectedDevice.WriteReport(report, 500);
		}

		public bool Check_Disconnect()
		{
			if (selectedDevice.IsConnected)
				return true;
			selectedDevice.CloseDevice();
			deviceIsReady = false;
			return false;
		}

		public event EventHandler<Report> DataReceived;

		protected virtual void OnDataReceived(Report e)
		{
			if (DataReceived == null)
				return;

			DataReceived(this, e);
		}

		public event EventHandler DeviceRemoved;

		protected virtual void OnDeviceRemoved(EventArgs e)
		{
			deviceIsOpen = false;

			if (DeviceRemoved == null)
				return;

			DeviceRemoved(this, e);
		}
	}
}
