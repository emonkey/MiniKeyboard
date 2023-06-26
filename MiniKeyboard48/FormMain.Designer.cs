using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace MiniKeyboard48
{
	partial class FormMain
	{
		// Choose between Stream writing(0) or Report writing(1)
		private ushort WriteMode = 1;
		private HidOperations hidOps = new HidOperations();
		private IntPtr hidDeviceRef;

		private byte[] RecDataBuffer = new byte[90];
		private readonly Color menuBackColor = Color.FromArgb(200, 200, 169);
		private readonly Color menuMouserOverColor = Color.FromArgb(230, 206, 172);
		private readonly string[] menuStr = { "Basic Keys", "Ctrl Shift Alt", "Multimedia", "LED", "Mouse" };
		private Dictionary<string, Form> menuDic = new Dictionary<string, Form>();
		private ToolStripMenuItem fdToolStripMenuItem;

		private int NumTicksToShowDownloadResultText;
		private Label labelDownloadResultText;
		private Label stateLabel;
		private Button Download;
		private Button Key_Clear;
		private TextBox SetText;
		private TextBox SetFunText;

		private Button KEY1;
		private Button KEY2;
		private Button KEY3;
		private Button KEY4;
		private Button KEY5;
		private Button KEY6;
		private Button KEY7;
		private Button KEY8;
		private Button KEY9;
		private Button KEY10;
		private Button KEY11;
		private Button KEY12;
		private Button KEY13;
		private Button KEY14;
		private Button KEY15;
		private Button KEY16;

		private Button K1_Left;
		private Button K1_Press;
		private Button K1_Right;
		private Button K2_Left;
		private Button K2_Press;
		private Button K2_Right;
		private Button K3_Left;
		private Button K3_Press;
		private Button K3_Right;

		private SplitContainer splitContainer1;
		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel_LayerFunctions;

		private System.Windows.Forms.Timer timer;

		public class KeyParam
		{
			// Data buffer to send to the device
			public static byte[] Data_Send_Buff = new byte[65];

			// Index of the physical key to be configured; 0-18, 176(LED); Stored in Data_Send_Buff[0]
			public static byte KeySet_KeyNum = 0;
			// Type of key to be configured; Stored in Data_Send_Buff[1]
			// 1=basic, 2=media, 3=mouse, 8=LED
			public static byte KeyType_Num = 1;
			// Stack index for sending multi-key sequences; Stored in Data_Send_Buff[2]
			public static byte KeyGroup_CharNum = 2;
			// Unused
			public static byte KeySet_KeyValNum = 3;
			// Index of function key to map to physical key; Stored in Data_Send_Buff[4]
			// 1=ctrl, 2=shft, 4=alt, 8=win, 16=ctrl, 32=shft, 64=alt, 128=win
			public static byte Key_Fun_Num = 4;
			// Index of basic key to map to physical key; Stored in Data_Send_Buff[5]
			// 0-101
			public static byte Key_Char_Num = 5;
			// Data_Send_Buff[6-8] is used as a bitmap for mouse keys

			// Human readable description of the key(s) being mapped
			public static string[] KeyChar = new string[100];
			public static string[] ComboKeyChar = new string[100];
			// Stack index for sending multi-key sequences
			public static byte ComboKey_Char_Num = 0;

			// Device version; See KeyBoardVersion_Check logic
			public static byte ReportID = 0;
			
			// Should clear data buffers and reset configuration
			public static bool ShouldClearConfigBuffers = false;

			// Default configuration sent to layer 1
			public static byte KEY_Cur_Layer = 1;

			// Default "Basic Keys" configuration shown
			// TODO: enum menu pages, fix special logic for LED configuration
			public static byte KEY_Cur_Page = 1;
		}

		private void LayerFunctionsList()
		{
			LayerFunctions layerFunctions = new LayerFunctions();
			flowLayoutPanel_LayerFunctions.Controls.Add((Control)layerFunctions);
			layerFunctions.Show();
		}

		private void MenuList()
		{
			for (int index = 0; index < menuStr.Length; ++index)
			{
				Button button = new Button();
				button.Text = menuStr[index];
				button.FlatStyle = FlatStyle.Flat;
				button.FlatAppearance.MouseOverBackColor = menuMouserOverColor;
				button.FlatAppearance.BorderSize = 0;
				button.Width = flowLayoutPanel1.Width;
				button.Height = 40;
				button.Margin = new Padding() { All = 0 };
				button.MouseClick += new MouseEventHandler(Btn_OnClick);
				flowLayoutPanel1.Controls.Add((Control)button);
				flowLayoutPanel1.BackColor = menuBackColor;
			}
			BasicKeys basicKeys = new BasicKeys();
			basicKeys.Parent = (Control)splitContainer1.Panel2;
			basicKeys.Dock = DockStyle.Fill;
			basicKeys.Show();
			FormMain.KeyParam.KEY_Cur_Page = (byte)1;
		}

		private void Btn_OnClick(object sender, MouseEventArgs e)
		{
			switch ((sender as Button).Text)
			{
				case "Basic Keys":
					splitContainer1.Panel2.Controls.Clear();
					BasicKeys basicKeys = new BasicKeys();
					basicKeys.Parent = (Control)splitContainer1.Panel2;
					basicKeys.Dock = DockStyle.Fill;
					basicKeys.Show();
					FormMain.KeyParam.KEY_Cur_Page = (byte)1;
					break;

				case "Ctrl Shift Alt":
					splitContainer1.Panel2.Controls.Clear();
					ComboKeys comboKeys = new ComboKeys();
					comboKeys.Parent = (Control)splitContainer1.Panel2;
					comboKeys.Dock = DockStyle.Fill;
					comboKeys.Show();
					FormMain.KeyParam.KEY_Cur_Page = (byte)2;
					break;
				
				case "Multimedia":
					splitContainer1.Panel2.Controls.Clear();
					MediaKeys mediaKeys = new MediaKeys();
					mediaKeys.Parent = (Control)splitContainer1.Panel2;
					mediaKeys.Dock = DockStyle.Fill;
					mediaKeys.Show();
					FormMain.KeyParam.KEY_Cur_Page = (byte)3;
					break;
				
				case "LED":
					splitContainer1.Panel2.Controls.Clear();
					LedFunctions ledFuncs = new LedFunctions();
					ledFuncs.Parent = (Control)splitContainer1.Panel2;
					ledFuncs.Dock = DockStyle.Fill;
					ledFuncs.Show();
					Key_Clear_Fun();
					FormMain.KeyParam.KEY_Cur_Page = (byte)4;
					break;
				
				case "Mouse":
					splitContainer1.Panel2.Controls.Clear();
					MouseKeys mouseKeys = new MouseKeys();
					mouseKeys.Parent = (Control)splitContainer1.Panel2;
					mouseKeys.Dock = DockStyle.Fill;
					mouseKeys.Show();
					Key_Clear_Fun();
					FormMain.KeyParam.KEY_Cur_Page = (byte)5;
					break;
			}
		}

		protected void myhid_DataReceived(object sender, Report r)
		{
			RecDataBuffer = r.reportBuff;
			var receivedString = new ASCIIEncoding().GetString(RecDataBuffer);
			Console.WriteLine(receivedString);
		}

		protected void myhid_DeviceRemoved(object sender, EventArgs e)
		{
			stateLabel.Text = "Device Removed";
			stateLabel.BackColor = stateLabel.BackColor = Color.Red;
		}

		#region Automatic Actions Performed Every Tick

		private void StartIntervalTimer()
		{
			timer = new System.Windows.Forms.Timer();
			timer.Enabled = true;
			timer.Interval = 500;
			timer.Tick += Timer_Elapsed;
			timer.Start();
		}

		private void Timer_Elapsed(object sender, EventArgs e)
		{
			AutoCheckUsb();

			if (FormMain.KeyParam.ShouldClearConfigBuffers)
				Key_Clear_Fun();

			if (NumTicksToShowDownloadResultText-- == 0)
				Hide_Dowload_Text();

			// Display any key mappings that are waiting to be sent
			if (FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] != (byte)0)
			{
				string str1 = "";
				str1 = str1 + FormMain.KeyParam.KeyChar[0]
					+ " " + FormMain.KeyParam.KeyChar[2]
					+ " " + FormMain.KeyParam.KeyChar[4]
					+ " " + FormMain.KeyParam.KeyChar[6]
					+ " " + FormMain.KeyParam.KeyChar[8];
				SetText.Text = str1;

				string str2 = "";
				str2 = str2 + FormMain.KeyParam.ComboKeyChar[0]
					+ " " + FormMain.KeyParam.ComboKeyChar[1]
					+ " " + FormMain.KeyParam.ComboKeyChar[2]
					+ " " + FormMain.KeyParam.ComboKeyChar[3];
				SetFunText.Text = str2;
			}
			// Otherwise clear the displayed text
			else
			{
				string str1 = "";
				SetText.Text = str1;

				string str2 = "";
				SetFunText.Text = str2;
			}
		}

		private void AutoCheckUsb()
		{
			// Doesn't seem like WriteMode will ever not be 1; i.e. nothing sets WriteMode other than init=1
			// I guess just manually choose between Stream writing(0) or Report writing(1) Modes ¯\_(ツ)_/¯
			if (WriteMode == (ushort)0)
			{
				if (!hidOps.IsOpen())
				{
					if ((hidDeviceRef = hidOps.ConnectStreamMode()) != HidOperations.INVALID_HANDLE_VALUE)
					{
						KeyBoardVersion_Check();
						stateLabel.Text = "Connected";
						stateLabel.BackColor = stateLabel.BackColor = Color.Green;
					}
					else
					{
						stateLabel.Text = "Not Connected";
						stateLabel.BackColor = stateLabel.BackColor = Color.Red;
					}
				}
				else
				{
					stateLabel.Text = "Connected";
					stateLabel.BackColor = stateLabel.BackColor = Color.Green;
				}
			}
			else if (WriteMode == (ushort)1)
			{
				if (!hidOps.IsReady())
				{
					if (hidOps.ConnectReportMode())
					{
						KeyBoardVersion_Check();
						stateLabel.Text = "Connected";
						stateLabel.BackColor = stateLabel.BackColor = Color.Green;
					}
					else
					{
						stateLabel.Text = "Not Connected";
						stateLabel.BackColor = stateLabel.BackColor = Color.Red;
					}
				}
				else if (hidOps.Check_Disconnect())
				{
					stateLabel.Text = "Connected";
					stateLabel.BackColor = stateLabel.BackColor = Color.Green;
				}
				else
				{
					stateLabel.Text = "Not Connected";
					stateLabel.BackColor = stateLabel.BackColor = Color.Red;
				}
			}
		}

		private void KeyBoardVersion_Check()
		{
			byte[] arrayBuff = new byte[65];
			FormMain.KeyParam.ReportID = (byte)0;
			arrayBuff[0] = (byte)0;
			arrayBuff[1] = (byte)0;

			if (WriteMode == (ushort)0)
			{
				if (hidOps.WriteToStream(FormMain.KeyParam.ReportID, arrayBuff) != HID_RETURN.SUCCESS)
				{
					FormMain.KeyParam.ReportID = (byte)2;
					if (hidOps.WriteToStream(FormMain.KeyParam.ReportID, arrayBuff) != HID_RETURN.SUCCESS)
						FormMain.KeyParam.ReportID = (byte)3;
				}
			}
			else if (WriteMode == (ushort)1)
			{
				FormMain.KeyParam.ReportID = (byte)3;
				if (!hidOps.WriteToDevice(FormMain.KeyParam.ReportID, arrayBuff))
				{
					FormMain.KeyParam.ReportID = (byte)0;
					if (!hidOps.WriteToDevice(FormMain.KeyParam.ReportID, arrayBuff))
					{
						FormMain.KeyParam.ReportID = (byte)2;
						if (!hidOps.WriteToDevice(FormMain.KeyParam.ReportID, arrayBuff))
							return;
					}
				}
			}
		}

		#endregion

		#region Downloading Bindings to the Keyboard

		private void Show_Dowload_Text()
		{
			// Show text for 20 ticks
			NumTicksToShowDownloadResultText = 2;
			labelDownloadResultText.Show();
		}

		private void Hide_Dowload_Text() => labelDownloadResultText.Hide();

		private void Download_Click(object sender, EventArgs e)
		{
			// Initialise a 64+1 bytes buffer
			byte[] arrayBuff = new byte[65];
			if (!hidOps.IsReady())
				return;

			// 0-index; Determine which key is going to be configured
			arrayBuff[0] = FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum];
			if (arrayBuff[0] == (byte)0)
				return;
			
			if (FormMain.KeyParam.ReportID == (byte)0)
			{
				// When device is v0;
				arrayBuff[1] = (FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num] &= (byte)15);
			}
			else
			{
				// Otherwise device v2, v3;
				Send_SwLayer();
				arrayBuff[1] = FormMain.KeyParam.KEY_Cur_Layer;
				arrayBuff[1] <<= 4;
				arrayBuff[1] |= FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num];
			}

			// KeyType being configured is 1=basic keys
			if (((int)FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num] & 15) == 1)
			{
				arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyGroup_CharNum];
				for (byte index = 0; (int)index <= (int)FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyGroup_CharNum]; ++index)
				{
					arrayBuff[3] = index;
					switch (index)
					{
						case 0:
							arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[4];
							arrayBuff[5] = (byte)0;
							break;
						case 1:
							arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[4];
							arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[5];
							break;
						case 2:
							arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[6];
							arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[7];
							break;
						case 3:
							arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[8];
							arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[9];
							break;
						case 4:
							arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[10];
							arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[11];
							break;
						case 5:
							arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[12];
							arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[13];
							break;
					}

					WriteDataToDevice(FormMain.KeyParam.ReportID, arrayBuff);
				}

				Send_WriteFlash_Cmd();
			}
			// KeyType being configured is 2=media keys
			else if (((int)FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num] & 15) == 2)
			{
				arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[5];
				arrayBuff[3] = FormMain.KeyParam.Data_Send_Buff[6];

				WriteDataToDevice(FormMain.KeyParam.ReportID, arrayBuff);

				Send_WriteFlash_Cmd();
			}
			// KeyType being configured is 3=mouse keys
			else if (((int)FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num] & 15) == 3)
			{
				arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[5];
				arrayBuff[3] = FormMain.KeyParam.Data_Send_Buff[6];
				arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[7];
				arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[8];
				arrayBuff[6] = FormMain.KeyParam.Data_Send_Buff[9];

				WriteDataToDevice(FormMain.KeyParam.ReportID, arrayBuff);

				Send_WriteFlash_Cmd();
			}
			// KeyType being configured is 8=LED
			else if (((int)FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num] & 15) == 8)
			{
				arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[2];

				WriteDataToDevice(FormMain.KeyParam.ReportID, arrayBuff);
				
				Send_WriteFlash_Cmd(true);
			}
		}

		private bool WriteDataToDevice(byte reportId, byte[] reportBuff)
		{
			if (WriteMode == (ushort)0)
			{
				return hidOps.WriteToStream(reportId, reportBuff) == HID_RETURN.SUCCESS;
			}
			else if (WriteMode == (ushort)1)
				return hidOps.WriteToDevice(reportId, reportBuff);
			else
				return false;
		}

		private void Send_SwLayer()
		{
			byte[] arrayBuff = new byte[65];
			arrayBuff[0] = (byte)161;
			arrayBuff[1] = FormMain.KeyParam.KEY_Cur_Layer;
			if (arrayBuff[1] == (byte)0)
				arrayBuff[1] = (byte)1;

			WriteDataToDevice(FormMain.KeyParam.ReportID, arrayBuff);
		}

		private void Send_WriteFlash_Cmd(bool isLed = false)
		{
			byte[] arrayBuff = new byte[65];
			arrayBuff[0] = (byte)170;
			arrayBuff[1] = isLed ? (byte)161 : (byte)170;

			if (WriteDataToDevice(FormMain.KeyParam.ReportID, arrayBuff))
			{
				labelDownloadResultText.Text = "Download success";
				labelDownloadResultText.BackColor = labelDownloadResultText.BackColor = Color.Green;
				Show_Dowload_Text();
			}
			else
			{
				labelDownloadResultText.Text = "Download failed";
				labelDownloadResultText.BackColor = labelDownloadResultText.BackColor = Color.Red;
				Show_Dowload_Text();
			}
		}

		#endregion

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Defining Key Functions

		/// <summary>
		/// Event handler calling Key_Clear
		/// </summary>
		private void Key_Clear_Click(object sender, EventArgs e) => Key_Clear_Fun();

		/// <summary>
		/// Clear data buffers and reset to empty configurations
		/// </summary>
		private void Key_Clear_Fun()
		{
			Char_Init();
			Key_Init();
			Colour_Init();
			FormMain.KeyParam.ShouldClearConfigBuffers = false;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)0;
		}

		private void Char_Init()
		{
			for (int index = 0; index < 100; ++index)
			{
				FormMain.KeyParam.KeyChar[index] = (string)null;
				FormMain.KeyParam.ComboKeyChar[index] = (string)null;
				FormMain.KeyParam.ComboKey_Char_Num = (byte)0;
			}
		}

		private void Key_Init()
		{
			FormMain.KeyParam.Key_Char_Num = (byte)5;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyType_Num] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeyGroup_CharNum] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyValNum] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Fun_Num] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 1] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 2] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 3] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 4] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 5] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 6] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 7] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 8] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 9] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 10] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 11] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 12] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 13] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 14] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 15] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 16] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 17] = (byte)0;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.Key_Char_Num + 18] = (byte)0;
		}

		private void Colour_Init()
		{
			int red = 152;
			int green = 251;
			int blue = 152;
			KEY1.BackColor = Color.FromArgb(red, green, blue);
			KEY2.BackColor = Color.FromArgb(red, green, blue);
			KEY3.BackColor = Color.FromArgb(red, green, blue);
			KEY4.BackColor = Color.FromArgb(red, green, blue);
			KEY5.BackColor = Color.FromArgb(red, green, blue);
			KEY6.BackColor = Color.FromArgb(red, green, blue);
			KEY7.BackColor = Color.FromArgb(red, green, blue);
			KEY8.BackColor = Color.FromArgb(red, green, blue);
			KEY9.BackColor = Color.FromArgb(red, green, blue);
			KEY10.BackColor = Color.FromArgb(red, green, blue);
			KEY11.BackColor = Color.FromArgb(red, green, blue);
			KEY12.BackColor = Color.FromArgb(red, green, blue);
			KEY13.BackColor = Color.FromArgb(red, green, blue);
			KEY14.BackColor = Color.FromArgb(red, green, blue);
			KEY15.BackColor = Color.FromArgb(red, green, blue);
			KEY16.BackColor = Color.FromArgb(red, green, blue);
			K1_Left.BackColor = Color.FromArgb(red, green, blue);
			K1_Press.BackColor = Color.FromArgb(red, green, blue);
			K1_Right.BackColor = Color.FromArgb(red, green, blue);
			K2_Left.BackColor = Color.FromArgb(red, green, blue);
			K2_Press.BackColor = Color.FromArgb(red, green, blue);
			K2_Right.BackColor = Color.FromArgb(red, green, blue);
			K3_Left.BackColor = Color.FromArgb(red, green, blue);
			K3_Press.BackColor = Color.FromArgb(red, green, blue);
			K3_Right.BackColor = Color.FromArgb(red, green, blue);
		}

		private void KEY1_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)1;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY1.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY2_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)2;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY2.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY3_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)3;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY3.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY4_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)4;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY4.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY5_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)5;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY5.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY6_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)6;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY6.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY7_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)7;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY7.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY8_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)8;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY8.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY9_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)9;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY9.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY10_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)10;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY10.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY11_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)11;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY11.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void KEY12_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)12;
			Key_Init();
			Char_Init();
			Colour_Init();
			KEY12.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void K1_Left_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)13;
			Key_Init();
			Char_Init();
			Colour_Init();
			K1_Left.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void K1_Press_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)14;
			Key_Init();
			Char_Init();
			Colour_Init();
			K1_Press.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void K1_Right_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)15;
			Key_Init();
			Char_Init();
			Colour_Init();
			K1_Right.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void K2_Left_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)16;
			Key_Init();
			Char_Init();
			Colour_Init();
			K2_Left.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void K2_Press_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)17;
			Key_Init();
			Char_Init();
			Colour_Init();
			K2_Press.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		private void K2_Right_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.KEY_Cur_Page == (byte)4)
				return;
			FormMain.KeyParam.Data_Send_Buff[(int)FormMain.KeyParam.KeySet_KeyNum] = (byte)18;
			Key_Init();
			Char_Init();
			Colour_Init();
			K2_Right.BackColor = Color.FromArgb((int)byte.MaxValue, 48, 48);
		}

		#endregion

		#region Resizing the Form Window

		private AutoSizeForm asc = new AutoSizeForm();

		private void FormMain_Load(object sender, EventArgs e) => asc.controllInitializeSize((Control)this);

		private void MainPage_SizeChanged(object sender, EventArgs e) => asc.controlAutoSize((Control)this);

		#endregion

		#region Windows Form Initialisation

		/// <summary>
		/// Required method for Designer support
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();

			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.stateLabel = new System.Windows.Forms.Label();
			this.fdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Download = new System.Windows.Forms.Button();
			this.KEY1 = new System.Windows.Forms.Button();
			this.KEY2 = new System.Windows.Forms.Button();
			this.KEY3 = new System.Windows.Forms.Button();
			this.KEY4 = new System.Windows.Forms.Button();
			this.KEY5 = new System.Windows.Forms.Button();
			this.KEY6 = new System.Windows.Forms.Button();
			this.KEY7 = new System.Windows.Forms.Button();
			this.KEY8 = new System.Windows.Forms.Button();
			this.KEY9 = new System.Windows.Forms.Button();
			this.KEY10 = new System.Windows.Forms.Button();
			this.KEY11 = new System.Windows.Forms.Button();
			this.KEY12 = new System.Windows.Forms.Button();
			this.KEY13 = new System.Windows.Forms.Button();
			this.KEY14 = new System.Windows.Forms.Button();
			this.KEY15 = new System.Windows.Forms.Button();
			this.KEY16 = new System.Windows.Forms.Button();
			this.K1_Left = new System.Windows.Forms.Button();
			this.K1_Press = new System.Windows.Forms.Button();
			this.K1_Right = new System.Windows.Forms.Button();
			this.K2_Right = new System.Windows.Forms.Button();
			this.K2_Press = new System.Windows.Forms.Button();
			this.K2_Left = new System.Windows.Forms.Button();
			this.K3_Left = new System.Windows.Forms.Button();
			this.K3_Press = new System.Windows.Forms.Button();
			this.K3_Right = new System.Windows.Forms.Button();
			this.Key_Clear = new System.Windows.Forms.Button();
			this.SetText = new System.Windows.Forms.TextBox();
			this.SetFunText = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel_LayerFunctions = new System.Windows.Forms.FlowLayoutPanel();
			this.labelDownloadResultText = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(20, 245);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(945, 345);
			this.splitContainer1.SplitterDistance = 105;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 245);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(95, 345);
			// 
			// stateLabel
			// 
			this.stateLabel.AutoSize = true;
			this.stateLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.stateLabel.Font = new System.Drawing.Font("Arial", 18F);
			this.stateLabel.Location = new System.Drawing.Point(25, 10);
			this.stateLabel.Name = "stateLabel";
			this.stateLabel.Size = new System.Drawing.Size(145, 30);
			this.stateLabel.Text = "Not Connected";
			// 
			// fdToolStripMenuItem
			// 
			this.fdToolStripMenuItem.Name = "fdToolStripMenuItem";
			this.fdToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			// 
			// Download
			// 
			this.Download.Location = new System.Drawing.Point(545, 160);
			this.Download.Name = "Download";
			this.Download.Size = new System.Drawing.Size(195, 55);
			this.Download.TabIndex = 28;
			this.Download.Text = "Download";
			this.Download.UseVisualStyleBackColor = true;
			this.Download.Click += new System.EventHandler(this.Download_Click);
			// 
			// KEY1
			// 
			this.KEY1.Location = new System.Drawing.Point(20, 55);
			this.KEY1.Name = "KEY1";
			this.KEY1.Size = new System.Drawing.Size(65, 40);
			this.KEY1.TabIndex = 1;
			this.KEY1.Text = "Key 1";
			this.KEY1.UseVisualStyleBackColor = true;
			this.KEY1.Click += new System.EventHandler(this.KEY1_Click);
			// 
			// KEY2
			// 
			this.KEY2.Location = new System.Drawing.Point(90, 55);
			this.KEY2.Name = "KEY2";
			this.KEY2.Size = new System.Drawing.Size(65, 40);
			this.KEY2.TabIndex = 2;
			this.KEY2.Text = "Key 2";
			this.KEY2.UseVisualStyleBackColor = true;
			this.KEY2.Click += new System.EventHandler(this.KEY2_Click);
			// 
			// KEY3
			// 
			this.KEY3.Location = new System.Drawing.Point(160, 55);
			this.KEY3.Name = "KEY3";
			this.KEY3.Size = new System.Drawing.Size(65, 40);
			this.KEY3.TabIndex = 3;
			this.KEY3.Text = "Key 3";
			this.KEY3.UseVisualStyleBackColor = true;
			this.KEY3.Click += new System.EventHandler(this.KEY3_Click);
			// 
			// KEY4
			// 
			this.KEY4.Location = new System.Drawing.Point(230, 55);
			this.KEY4.Name = "KEY4";
			this.KEY4.Size = new System.Drawing.Size(65, 40);
			this.KEY4.TabIndex = 4;
			this.KEY4.Text = "Key 4";
			this.KEY4.UseVisualStyleBackColor = true;
			this.KEY4.Click += new System.EventHandler(this.KEY4_Click);
			// 
			// KEY5
			// 
			this.KEY5.Location = new System.Drawing.Point(20, 100);
			this.KEY5.Name = "KEY5";
			this.KEY5.Size = new System.Drawing.Size(65, 40);
			this.KEY5.TabIndex = 5;
			this.KEY5.Text = "Key 5";
			this.KEY5.UseVisualStyleBackColor = true;
			this.KEY5.Click += new System.EventHandler(this.KEY5_Click);
			// 
			// KEY6
			// 
			this.KEY6.Location = new System.Drawing.Point(90, 100);
			this.KEY6.Name = "KEY6";
			this.KEY6.Size = new System.Drawing.Size(65, 40);
			this.KEY6.TabIndex = 6;
			this.KEY6.Text = "Key 6";
			this.KEY6.UseVisualStyleBackColor = true;
			this.KEY6.Click += new System.EventHandler(this.KEY6_Click);
			// 
			// KEY7
			// 
			this.KEY7.Location = new System.Drawing.Point(160, 100);
			this.KEY7.Name = "KEY7";
			this.KEY7.Size = new System.Drawing.Size(65, 40);
			this.KEY7.TabIndex = 7;
			this.KEY7.Text = "Key 7";
			this.KEY7.UseVisualStyleBackColor = true;
			this.KEY7.Click += new System.EventHandler(this.KEY7_Click);
			// 
			// KEY8
			// 
			this.KEY8.Location = new System.Drawing.Point(230, 100);
			this.KEY8.Name = "KEY8";
			this.KEY8.Size = new System.Drawing.Size(65, 40);
			this.KEY8.TabIndex = 8;
			this.KEY8.Text = "Key 8";
			this.KEY8.UseVisualStyleBackColor = true;
			this.KEY8.Click += new System.EventHandler(this.KEY8_Click);
			// 
			// KEY9
			// 
			this.KEY9.Location = new System.Drawing.Point(20, 145);
			this.KEY9.Name = "KEY9";
			this.KEY9.Size = new System.Drawing.Size(65, 40);
			this.KEY9.TabIndex = 9;
			this.KEY9.Text = "Key 9";
			this.KEY9.UseVisualStyleBackColor = true;
			this.KEY9.Click += new System.EventHandler(this.KEY9_Click);
			// 
			// KEY10
			// 
			this.KEY10.Location = new System.Drawing.Point(90, 145);
			this.KEY10.Name = "KEY10";
			this.KEY10.Size = new System.Drawing.Size(65, 40);
			this.KEY10.TabIndex = 10;
			this.KEY10.Text = "Key 10";
			this.KEY10.UseVisualStyleBackColor = true;
			this.KEY10.Click += new System.EventHandler(this.KEY10_Click);
			// 
			// KEY11
			// 
			this.KEY11.Location = new System.Drawing.Point(160, 145);
			this.KEY11.Name = "KEY11";
			this.KEY11.Size = new System.Drawing.Size(65, 40);
			this.KEY11.TabIndex = 11;
			this.KEY11.Text = "Key 11";
			this.KEY11.UseVisualStyleBackColor = true;
			this.KEY11.Click += new System.EventHandler(this.KEY11_Click);
			// 
			// KEY12
			// 
			this.KEY12.Location = new System.Drawing.Point(230, 145);
			this.KEY12.Name = "KEY12";
			this.KEY12.Size = new System.Drawing.Size(65, 40);
			this.KEY12.TabIndex = 12;
			this.KEY12.Text = "Key 12";
			this.KEY12.UseVisualStyleBackColor = true;
			this.KEY12.Click += new System.EventHandler(this.KEY12_Click);
			// 
			// KEY13
			// 
			this.KEY13.Location = new System.Drawing.Point(20, 190);
			this.KEY13.Name = "KEY13";
			this.KEY13.Size = new System.Drawing.Size(65, 40);
			this.KEY13.TabIndex = 13;
			this.KEY13.Text = "Key 13";
			this.KEY13.UseVisualStyleBackColor = true;
			// 
			// KEY14
			// 
			this.KEY14.Location = new System.Drawing.Point(90, 190);
			this.KEY14.Name = "KEY14";
			this.KEY14.Size = new System.Drawing.Size(65, 40);
			this.KEY14.TabIndex = 14;
			this.KEY14.Text = "Key 14";
			this.KEY14.UseVisualStyleBackColor = true;
			// 
			// KEY15
			// 
			this.KEY15.Location = new System.Drawing.Point(160, 190);
			this.KEY15.Name = "KEY15";
			this.KEY15.Size = new System.Drawing.Size(65, 40);
			this.KEY15.TabIndex = 15;
			this.KEY15.Text = "Key 15";
			this.KEY15.UseVisualStyleBackColor = true;
			// 
			// KEY16
			// 
			this.KEY16.Location = new System.Drawing.Point(230, 190);
			this.KEY16.Name = "KEY16";
			this.KEY16.Size = new System.Drawing.Size(65, 40);
			this.KEY16.TabIndex = 16;
			this.KEY16.Text = "Key 16";
			this.KEY16.UseVisualStyleBackColor = true;
			// 
			// K1_Left
			// 
			this.K1_Left.Location = new System.Drawing.Point(310, 55);
			this.K1_Left.Name = "K1_Left";
			this.K1_Left.Size = new System.Drawing.Size(70, 50);
			this.K1_Left.TabIndex = 17;
			this.K1_Left.Text = "K1 Left";
			this.K1_Left.UseVisualStyleBackColor = true;
			this.K1_Left.Click += new System.EventHandler(this.K1_Left_Click);
			// 
			// K1_Press
			// 
			this.K1_Press.Location = new System.Drawing.Point(385, 55);
			this.K1_Press.Name = "K1_Press";
			this.K1_Press.Size = new System.Drawing.Size(70, 50);
			this.K1_Press.TabIndex = 18;
			this.K1_Press.Text = "K1 Press";
			this.K1_Press.UseVisualStyleBackColor = true;
			this.K1_Press.Click += new System.EventHandler(this.K1_Press_Click);
			// 
			// K1_Right
			// 
			this.K1_Right.Location = new System.Drawing.Point(460, 55);
			this.K1_Right.Name = "K1_Right";
			this.K1_Right.Size = new System.Drawing.Size(70, 50);
			this.K1_Right.TabIndex = 19;
			this.K1_Right.Text = "K1 Right";
			this.K1_Right.UseVisualStyleBackColor = true;
			this.K1_Right.Click += new System.EventHandler(this.K1_Right_Click);
			// 
			// K2_Left
			// 
			this.K2_Left.Location = new System.Drawing.Point(310, 110);
			this.K2_Left.Name = "K2_Left";
			this.K2_Left.Size = new System.Drawing.Size(70, 50);
			this.K2_Left.TabIndex = 20;
			this.K2_Left.Text = "K2 Left";
			this.K2_Left.UseVisualStyleBackColor = true;
			this.K2_Left.Click += new System.EventHandler(this.K2_Left_Click);
			// 
			// K2_Press
			// 
			this.K2_Press.Location = new System.Drawing.Point(385, 110);
			this.K2_Press.Name = "K2_Press";
			this.K2_Press.Size = new System.Drawing.Size(70, 50);
			this.K2_Press.TabIndex = 21;
			this.K2_Press.Text = "K2 Press";
			this.K2_Press.UseVisualStyleBackColor = true;
			this.K2_Press.Click += new System.EventHandler(this.K2_Press_Click);
			// 
			// K2_Right
			// 
			this.K2_Right.Location = new System.Drawing.Point(460, 110);
			this.K2_Right.Name = "K2_Right";
			this.K2_Right.Size = new System.Drawing.Size(70, 50);
			this.K2_Right.TabIndex = 22;
			this.K2_Right.Text = "K2 Right";
			this.K2_Right.UseVisualStyleBackColor = true;
			this.K2_Right.Click += new System.EventHandler(this.K2_Right_Click);
			// 
			// K3_Left
			// 
			this.K3_Left.Location = new System.Drawing.Point(310, 165);
			this.K3_Left.Name = "K3_Left";
			this.K3_Left.Size = new System.Drawing.Size(70, 50);
			this.K3_Left.TabIndex = 23;
			this.K3_Left.Text = "K3 Left";
			this.K3_Left.UseVisualStyleBackColor = true;
			// 
			// K3_Press
			// 
			this.K3_Press.Location = new System.Drawing.Point(385, 165);
			this.K3_Press.Name = "K3_Press";
			this.K3_Press.Size = new System.Drawing.Size(70, 50);
			this.K3_Press.TabIndex = 24;
			this.K3_Press.Text = "K3 Press";
			this.K3_Press.UseVisualStyleBackColor = true;
			// 
			// K3_Right
			// 
			this.K3_Right.Location = new System.Drawing.Point(460, 165);
			this.K3_Right.Name = "K3_Right";
			this.K3_Right.Size = new System.Drawing.Size(70, 50);
			this.K3_Right.TabIndex = 25;
			this.K3_Right.Text = "K3 Right";
			this.K3_Right.UseVisualStyleBackColor = true;
			// 
			// Key_Clear
			// 
			this.Key_Clear.Location = new System.Drawing.Point(760, 160);
			this.Key_Clear.Name = "Key_Clear";
			this.Key_Clear.Size = new System.Drawing.Size(195, 55);
			this.Key_Clear.TabIndex = 29;
			this.Key_Clear.Text = "Cancel";
			this.Key_Clear.UseVisualStyleBackColor = true;
			this.Key_Clear.Click += new System.EventHandler(this.Key_Clear_Click);
			// 
			// SetText
			// 
			this.SetText.Font = new System.Drawing.Font("Arial", 15F);
			this.SetText.Location = new System.Drawing.Point(545, 110);
			this.SetText.MaximumSize = new System.Drawing.Size(600, 300);
			this.SetText.Multiline = true;
			this.SetText.Name = "SetText";
			this.SetText.Size = new System.Drawing.Size(410, 40);
			this.SetText.TabIndex = 26;
			// 
			// SetFunText
			// 
			this.SetFunText.Font = new System.Drawing.Font("Arial", 15F);
			this.SetFunText.Location = new System.Drawing.Point(545, 55);
			this.SetFunText.MaximumSize = new System.Drawing.Size(600, 300);
			this.SetFunText.Multiline = true;
			this.SetFunText.Name = "SetFunText";
			this.SetFunText.Size = new System.Drawing.Size(410, 40);
			this.SetFunText.TabIndex = 27;
			// 
			// flowLayoutPanel_LayerFunctions
			// 
			this.flowLayoutPanel_LayerFunctions.Location = new System.Drawing.Point(310, 10);
			this.flowLayoutPanel_LayerFunctions.Name = "flowLayoutPanel_LayerFunctions";
			this.flowLayoutPanel_LayerFunctions.Size = new System.Drawing.Size(645, 35);
			// 
			// labelDownloadResultText
			// 
			this.labelDownloadResultText.AutoSize = true;
			this.labelDownloadResultText.Font = new System.Drawing.Font("Arial", 26F);
			this.labelDownloadResultText.Location = new System.Drawing.Point(310, 190);
			this.labelDownloadResultText.Name = "labelDownloadResultText";
			this.labelDownloadResultText.Size = new System.Drawing.Size(310, 40);
			this.labelDownloadResultText.Text = "Download Success";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 610);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.labelDownloadResultText);
			this.Controls.Add(this.flowLayoutPanel_LayerFunctions);
			this.Controls.Add(this.SetFunText);
			this.Controls.Add(this.SetText);
			this.Controls.Add(this.Key_Clear);
			this.Controls.Add(this.Download);
			this.Controls.Add(this.stateLabel);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.K3_Right);
			this.Controls.Add(this.K3_Press);
			this.Controls.Add(this.K3_Left);
			this.Controls.Add(this.K2_Right);
			this.Controls.Add(this.K2_Press);
			this.Controls.Add(this.K2_Left);
			this.Controls.Add(this.K1_Right);
			this.Controls.Add(this.K1_Press);
			this.Controls.Add(this.K1_Left);
			this.Controls.Add(this.KEY16);
			this.Controls.Add(this.KEY15);
			this.Controls.Add(this.KEY14);
			this.Controls.Add(this.KEY13);
			this.Controls.Add(this.KEY12);
			this.Controls.Add(this.KEY11);
			this.Controls.Add(this.KEY10);
			this.Controls.Add(this.KEY9);
			this.Controls.Add(this.KEY8);
			this.Controls.Add(this.KEY7);
			this.Controls.Add(this.KEY6);
			this.Controls.Add(this.KEY5);
			this.Controls.Add(this.KEY4);
			this.Controls.Add(this.KEY3);
			this.Controls.Add(this.KEY2);
			this.Controls.Add(this.KEY1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "FormMain";
			this.Text = "Mini Keyboard Configurator";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		#endregion
	}
}

