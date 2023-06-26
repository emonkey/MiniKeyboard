using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiniKeyboard48
{
	internal class ComboKeys : UserControl
	{
		private IContainer components;
		private Button KEY_Ctrl_Left_Click;
		private Button KEY_Shift_Left_Click;
		private Button KEY_Alt_Left_Click;
		private Button KEY_Alt_Right_Click;
		private Button KEY_Shift_Right_Click;
		private Button KEY_Ctrl_Right_Click;
		private Button KEY_Win_Left_Click;
		private Button KEY_Win_Right_Click;
		private Button KEY_Ctrl_Alt;
		private Button KEY_Ctrl_Shift;
		private Button KEY_Alt_Shift;
		private Button KEY_Ctrl_Shift_Alt;
		private Button KEY_Ctrl_Alt_Win;
		private Button KEY_Shift_Win;
		private Button KEY_Ctrl_Alt_Shift_Win;
		private Button KEY_Shift_And_1;
		private Button KEY_Shift_And_2;
		private Button KEY_Shift_And_3;
		private Button KEY_Shift_And_4;
		private Button KEY_Shift_And_5;
		private Button KEY_Shift_And_6;
		private Button KEY_Shift_And_7;
		private Button KEY_Shift_And_8;
		private Button KEY_Shift_And_9;
		private Button KEY_Shift_And_10;
		private Button KEY_Shift_And_11;
		private Button KEY_Shift_And_12;
		private Button KEY_Shift_And_13;
		private Button KEY_Shift_And_14;
		private Button KEY_Shift_And_15;
		private Button KEY_Shift_And_16;
		private Button KEY_Shift_And_17;
		private Button KEY_Shift_And_18;
		private Button KEY_Shift_And_19;
		private Button KEY_Shift_And_20;
		private Button KEY_Shift_And_21;

		public ComboKeys() => InitializeComponent();

		private void FunGeneral_Char_Set()
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			++FormMain.KeyParam.ComboKey_Char_Num;
		}

		private void KEY_Ctrl_Left_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
		}

		private void KEY_Shift_Left_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
		}

		private void KEY_Alt_Left_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
		}

		private void KEY_Win_Left_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 8;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Win";
			FunGeneral_Char_Set();
		}

		private void KEY_Ctrl_Right_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 16;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
		}

		private void KEY_Shift_Right_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 32;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
		}

		private void KEY_Alt_Right_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 64;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
		}

		private void KEY_Win_Right_Click_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 128;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Win";
			FunGeneral_Char_Set();
		}

		private void KEY_Ctrl_Alt_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
		}

		private void KEY_Ctrl_Shift_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
		}

		private void KEY_Alt_Shift_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
		}

		private void KEY_Shift_Win_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 8;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Win";
			FunGeneral_Char_Set();
		}

		private void KEY_Ctrl_Shift_Alt_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
		}

		private void KEY_Ctrl_Alt_Win_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 8;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Win";
			FunGeneral_Char_Set();
		}

		private void KEY_Ctrl_Alt_Shift_Win_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 1;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Ctrl";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 4;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Alt";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Shift";
			FunGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 8;
			FormMain.KeyParam.ComboKeyChar[FormMain.KeyParam.ComboKey_Char_Num] = "Win";
			FunGeneral_Char_Set();
		}

		private void ShiftGeneral_Char_Set()
		{
			if (FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] != 0)
				FormMain.KeyParam.Key_Char_Num += 2;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num - 1] |= 2;
		}

		private void ShiftGeneral_Char_Set2()
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 1;
			FormMain.KeyParam.Key_Char_Num += 2;
			++FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyGroup_CharNum];
			++FormMain.KeyParam.ComboKey_Char_Num;
		}

		private void KEY_Shift_And_1_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 53;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_1.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_2_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 30;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_2.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_3_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 31;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_3.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_4_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 32;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_4.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_5_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 33;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_5.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_6_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 34;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_6.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_7_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 35;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_7.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_8_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 36;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_8.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_9_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 37;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_9.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_10_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 38;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_10.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_11_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 39;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_11.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_12_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 45;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_12.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_13_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 46;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_13.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_14_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 47;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_14.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_15_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 48;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_15.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_16_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 49;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_16.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_17_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 51;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_17.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_18_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 52;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_18.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_19_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 54;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_19.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_20_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 55;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_20.Text;
			ShiftGeneral_Char_Set2();
		}

		private void KEY_Shift_And_21_Click(object sender, EventArgs e)
		{
			ShiftGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 56;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Shift_And_21.Text;
			ShiftGeneral_Char_Set2();
		}

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

		private void InitializeComponent()
		{
			KEY_Ctrl_Left_Click = new Button();
			KEY_Shift_Left_Click = new Button();
			KEY_Alt_Left_Click = new Button();
			KEY_Win_Left_Click = new Button();
			KEY_Ctrl_Right_Click = new Button();
			KEY_Shift_Right_Click = new Button();
			KEY_Alt_Right_Click = new Button();
			KEY_Win_Right_Click = new Button();

			KEY_Ctrl_Alt = new Button();
			KEY_Ctrl_Shift = new Button();
			KEY_Alt_Shift = new Button();
			KEY_Ctrl_Shift_Alt = new Button();
			KEY_Ctrl_Alt_Win = new Button();
			KEY_Shift_Win = new Button();
			KEY_Ctrl_Alt_Shift_Win = new Button();
			KEY_Shift_And_1 = new Button();
			KEY_Shift_And_2 = new Button();
			KEY_Shift_And_3 = new Button();
			KEY_Shift_And_4 = new Button();
			KEY_Shift_And_5 = new Button();
			KEY_Shift_And_6 = new Button();
			KEY_Shift_And_7 = new Button();
			KEY_Shift_And_8 = new Button();
			KEY_Shift_And_9 = new Button();
			KEY_Shift_And_10 = new Button();
			KEY_Shift_And_11 = new Button();
			KEY_Shift_And_12 = new Button();
			KEY_Shift_And_13 = new Button();
			KEY_Shift_And_14 = new Button();
			KEY_Shift_And_15 = new Button();
			KEY_Shift_And_16 = new Button();
			KEY_Shift_And_17 = new Button();
			KEY_Shift_And_18 = new Button();
			KEY_Shift_And_19 = new Button();
			KEY_Shift_And_20 = new Button();
			KEY_Shift_And_21 = new Button();

			SuspendLayout();

			KEY_Ctrl_Left_Click.Location = new Point(3, 3);
			KEY_Ctrl_Left_Click.Name = "KEY_Ctrl_Left_Click";
			KEY_Ctrl_Left_Click.Size = new Size(94, 23);
			KEY_Ctrl_Left_Click.TabIndex = 69;
			KEY_Ctrl_Left_Click.Text = "Ctrl+";
			KEY_Ctrl_Left_Click.UseVisualStyleBackColor = true;
			KEY_Ctrl_Left_Click.Click += new EventHandler(KEY_Ctrl_Left_Click_Click);
			KEY_Shift_Left_Click.Location = new Point(206, 3);
			KEY_Shift_Left_Click.Name = "KEY_Shift_Left_Click";
			KEY_Shift_Left_Click.Size = new Size(97, 23);
			KEY_Shift_Left_Click.TabIndex = 70;
			KEY_Shift_Left_Click.Text = "Shift+";
			KEY_Shift_Left_Click.UseVisualStyleBackColor = true;
			KEY_Shift_Left_Click.Click += new EventHandler(KEY_Shift_Left_Click_Click);
			KEY_Alt_Left_Click.Location = new Point(103, 3);
			KEY_Alt_Left_Click.Name = "KEY_Alt_Left_Click";
			KEY_Alt_Left_Click.Size = new Size(97, 23);
			KEY_Alt_Left_Click.TabIndex = 71;
			KEY_Alt_Left_Click.Text = "Alt+";
			KEY_Alt_Left_Click.UseVisualStyleBackColor = true;
			KEY_Alt_Left_Click.Click += new EventHandler(KEY_Alt_Left_Click_Click);
			KEY_Win_Left_Click.Location = new Point(309, 3);
			KEY_Win_Left_Click.Name = "KEY_Win_Left_Click";
			KEY_Win_Left_Click.Size = new Size(88, 23);
			KEY_Win_Left_Click.TabIndex = 75;
			KEY_Win_Left_Click.Text = "Win+";
			KEY_Win_Left_Click.UseVisualStyleBackColor = true;
			KEY_Win_Left_Click.Click += new EventHandler(KEY_Win_Left_Click_Click);
			KEY_Ctrl_Right_Click.Location = new Point(3, 32);
			KEY_Ctrl_Right_Click.Name = "KEY_Ctrl_Right_Click";
			KEY_Ctrl_Right_Click.Size = new Size(94, 23);
			KEY_Ctrl_Right_Click.TabIndex = 74;
			KEY_Ctrl_Right_Click.Text = "Right  Ctrl+";
			KEY_Ctrl_Right_Click.UseVisualStyleBackColor = true;
			KEY_Ctrl_Right_Click.Click += new EventHandler(KEY_Ctrl_Right_Click_Click);
			KEY_Shift_Right_Click.Location = new Point(206, 32);
			KEY_Shift_Right_Click.Name = "KEY_Shift_Right_Click";
			KEY_Shift_Right_Click.Size = new Size(97, 23);
			KEY_Shift_Right_Click.TabIndex = 73;
			KEY_Shift_Right_Click.Text = "Right Shift+";
			KEY_Shift_Right_Click.UseVisualStyleBackColor = true;
			KEY_Shift_Right_Click.Click += new EventHandler(KEY_Shift_Right_Click_Click);
			KEY_Alt_Right_Click.Location = new Point(103, 32);
			KEY_Alt_Right_Click.Name = "KEY_Alt_Right_Click";
			KEY_Alt_Right_Click.Size = new Size(97, 23);
			KEY_Alt_Right_Click.TabIndex = 72;
			KEY_Alt_Right_Click.Text = "Right Alt+";
			KEY_Alt_Right_Click.UseVisualStyleBackColor = true;
			KEY_Alt_Right_Click.Click += new EventHandler(KEY_Alt_Right_Click_Click);
			KEY_Win_Right_Click.Location = new Point(309, 32);
			KEY_Win_Right_Click.Name = "KEY_Win_Right_Click";
			KEY_Win_Right_Click.Size = new Size(88, 23);
			KEY_Win_Right_Click.TabIndex = 76;
			KEY_Win_Right_Click.Text = "Right Win+";
			KEY_Win_Right_Click.UseVisualStyleBackColor = true;
			KEY_Win_Right_Click.Click += new EventHandler(KEY_Win_Right_Click_Click);

			KEY_Ctrl_Alt.Location = new Point(3, 61);
			KEY_Ctrl_Alt.Name = "KEY_Ctrl_Alt";
			KEY_Ctrl_Alt.Size = new Size(94, 23);
			KEY_Ctrl_Alt.TabIndex = 77;
			KEY_Ctrl_Alt.Text = "Ctrl+Alt+";
			KEY_Ctrl_Alt.UseVisualStyleBackColor = true;
			KEY_Ctrl_Alt.Click += new EventHandler(KEY_Ctrl_Alt_Click);
			KEY_Ctrl_Shift.Location = new Point(106, 61);
			KEY_Ctrl_Shift.Name = "KEY_Ctrl_Shift";
			KEY_Ctrl_Shift.Size = new Size(94, 23);
			KEY_Ctrl_Shift.TabIndex = 78;
			KEY_Ctrl_Shift.Text = "Ctrl+Shift+";
			KEY_Ctrl_Shift.UseVisualStyleBackColor = true;
			KEY_Ctrl_Shift.Click += new EventHandler(KEY_Ctrl_Shift_Click);
			KEY_Alt_Shift.Location = new Point(206, 61);
			KEY_Alt_Shift.Name = "KEY_Alt_Shift";
			KEY_Alt_Shift.Size = new Size(97, 23);
			KEY_Alt_Shift.TabIndex = 79;
			KEY_Alt_Shift.Text = "Alt+Shift+";
			KEY_Alt_Shift.UseVisualStyleBackColor = true;
			KEY_Alt_Shift.Click += new EventHandler(KEY_Alt_Shift_Click);
			KEY_Ctrl_Shift_Alt.Location = new Point(3, 90);
			KEY_Ctrl_Shift_Alt.Name = "KEY_Ctrl_Shift_Alt";
			KEY_Ctrl_Shift_Alt.Size = new Size(197, 23);
			KEY_Ctrl_Shift_Alt.TabIndex = 80;
			KEY_Ctrl_Shift_Alt.Text = "Ctrl+Shift+Alt+";
			KEY_Ctrl_Shift_Alt.UseVisualStyleBackColor = true;
			KEY_Ctrl_Shift_Alt.Click += new EventHandler(KEY_Ctrl_Shift_Alt_Click);
			KEY_Ctrl_Alt_Win.Location = new Point(206, 90);
			KEY_Ctrl_Alt_Win.Name = "KEY_Ctrl_Alt_Win";
			KEY_Ctrl_Alt_Win.Size = new Size(191, 23);
			KEY_Ctrl_Alt_Win.TabIndex = 81;
			KEY_Ctrl_Alt_Win.Text = "Ctrl+Alt+Win+";
			KEY_Ctrl_Alt_Win.UseVisualStyleBackColor = true;
			KEY_Ctrl_Alt_Win.Click += new EventHandler(KEY_Ctrl_Alt_Win_Click);
			KEY_Shift_Win.Location = new Point(309, 61);
			KEY_Shift_Win.Name = "KEY_Shift_Win";
			KEY_Shift_Win.Size = new Size(88, 23);
			KEY_Shift_Win.TabIndex = 82;
			KEY_Shift_Win.Text = "Shift+Win+";
			KEY_Shift_Win.UseVisualStyleBackColor = true;
			KEY_Shift_Win.Click += new EventHandler(KEY_Shift_Win_Click);
			KEY_Ctrl_Alt_Shift_Win.Location = new Point(3, 119);
			KEY_Ctrl_Alt_Shift_Win.Name = "KEY_Ctrl_Alt_Shift_Win";
			KEY_Ctrl_Alt_Shift_Win.Size = new Size(394, 23);
			KEY_Ctrl_Alt_Shift_Win.TabIndex = 83;
			KEY_Ctrl_Alt_Shift_Win.Text = "Ctrl+Alt+Shift+Win+";
			KEY_Ctrl_Alt_Shift_Win.UseVisualStyleBackColor = true;
			KEY_Ctrl_Alt_Shift_Win.Click += new EventHandler(KEY_Ctrl_Alt_Shift_Win_Click);
			KEY_Shift_And_1.Location = new Point(423, 3);
			KEY_Shift_And_1.Name = "KEY_Shift_And_1";
			KEY_Shift_And_1.Size = new Size(41, 23);
			KEY_Shift_And_1.TabIndex = 84;
			KEY_Shift_And_1.Text = "～";
			KEY_Shift_And_1.UseVisualStyleBackColor = true;
			KEY_Shift_And_1.Click += new EventHandler(KEY_Shift_And_1_Click);
			KEY_Shift_And_2.Location = new Point(470, 3);
			KEY_Shift_And_2.Name = "KEY_Shift_And_2";
			KEY_Shift_And_2.Size = new Size(41, 23);
			KEY_Shift_And_2.TabIndex = 85;
			KEY_Shift_And_2.Text = "！";
			KEY_Shift_And_2.UseVisualStyleBackColor = true;
			KEY_Shift_And_2.Click += new EventHandler(KEY_Shift_And_2_Click);
			KEY_Shift_And_3.Location = new Point(517, 3);
			KEY_Shift_And_3.Name = "KEY_Shift_And_3";
			KEY_Shift_And_3.Size = new Size(41, 23);
			KEY_Shift_And_3.TabIndex = 86;
			KEY_Shift_And_3.Text = "@";
			KEY_Shift_And_3.UseVisualStyleBackColor = true;
			KEY_Shift_And_3.Click += new EventHandler(KEY_Shift_And_3_Click);
			KEY_Shift_And_4.Location = new Point(564, 3);
			KEY_Shift_And_4.Name = "KEY_Shift_And_4";
			KEY_Shift_And_4.Size = new Size(41, 23);
			KEY_Shift_And_4.TabIndex = 87;
			KEY_Shift_And_4.Text = "#";
			KEY_Shift_And_4.UseVisualStyleBackColor = true;
			KEY_Shift_And_4.Click += new EventHandler(KEY_Shift_And_4_Click);
			KEY_Shift_And_5.Location = new Point(611, 3);
			KEY_Shift_And_5.Name = "KEY_Shift_And_5";
			KEY_Shift_And_5.Size = new Size(41, 23);
			KEY_Shift_And_5.TabIndex = 88;
			KEY_Shift_And_5.Text = "$";
			KEY_Shift_And_5.UseVisualStyleBackColor = true;
			KEY_Shift_And_5.Click += new EventHandler(KEY_Shift_And_5_Click);
			KEY_Shift_And_6.Location = new Point(423, 32);
			KEY_Shift_And_6.Name = "KEY_Shift_And_6";
			KEY_Shift_And_6.Size = new Size(41, 23);
			KEY_Shift_And_6.TabIndex = 89;
			KEY_Shift_And_6.Text = "%";
			KEY_Shift_And_6.UseVisualStyleBackColor = true;
			KEY_Shift_And_6.Click += new EventHandler(KEY_Shift_And_6_Click);
			KEY_Shift_And_7.Location = new Point(470, 32);
			KEY_Shift_And_7.Name = "KEY_Shift_And_7";
			KEY_Shift_And_7.Size = new Size(41, 23);
			KEY_Shift_And_7.TabIndex = 90;
			KEY_Shift_And_7.Text = "∧";
			KEY_Shift_And_7.UseVisualStyleBackColor = true;
			KEY_Shift_And_7.Click += new EventHandler(KEY_Shift_And_7_Click);
			KEY_Shift_And_8.Location = new Point(517, 32);
			KEY_Shift_And_8.Name = "KEY_Shift_And_8";
			KEY_Shift_And_8.Size = new Size(41, 23);
			KEY_Shift_And_8.TabIndex = 91;
			KEY_Shift_And_8.Text = "＆";
			KEY_Shift_And_8.UseVisualStyleBackColor = true;
			KEY_Shift_And_8.Click += new EventHandler(KEY_Shift_And_8_Click);
			KEY_Shift_And_9.Location = new Point(564, 32);
			KEY_Shift_And_9.Name = "KEY_Shift_And_9";
			KEY_Shift_And_9.Size = new Size(41, 23);
			KEY_Shift_And_9.TabIndex = 92;
			KEY_Shift_And_9.Text = "*";
			KEY_Shift_And_9.UseVisualStyleBackColor = true;
			KEY_Shift_And_9.Click += new EventHandler(KEY_Shift_And_9_Click);
			KEY_Shift_And_10.Location = new Point(611, 32);
			KEY_Shift_And_10.Name = "KEY_Shift_And_10";
			KEY_Shift_And_10.Size = new Size(41, 23);
			KEY_Shift_And_10.TabIndex = 93;
			KEY_Shift_And_10.Text = "(";
			KEY_Shift_And_10.UseVisualStyleBackColor = true;
			KEY_Shift_And_10.Click += new EventHandler(KEY_Shift_And_10_Click);
			KEY_Shift_And_11.Location = new Point(423, 61);
			KEY_Shift_And_11.Name = "KEY_Shift_And_11";
			KEY_Shift_And_11.Size = new Size(41, 23);
			KEY_Shift_And_11.TabIndex = 94;
			KEY_Shift_And_11.Text = ")";
			KEY_Shift_And_11.UseVisualStyleBackColor = true;
			KEY_Shift_And_11.Click += new EventHandler(KEY_Shift_And_11_Click);
			KEY_Shift_And_12.Location = new Point(470, 61);
			KEY_Shift_And_12.Name = "KEY_Shift_And_12";
			KEY_Shift_And_12.Size = new Size(41, 23);
			KEY_Shift_And_12.TabIndex = 95;
			KEY_Shift_And_12.Text = "￣";
			KEY_Shift_And_12.UseVisualStyleBackColor = true;
			KEY_Shift_And_12.Click += new EventHandler(KEY_Shift_And_12_Click);
			KEY_Shift_And_13.Location = new Point(517, 61);
			KEY_Shift_And_13.Name = "KEY_Shift_And_13";
			KEY_Shift_And_13.Size = new Size(41, 23);
			KEY_Shift_And_13.TabIndex = 96;
			KEY_Shift_And_13.Text = "＋";
			KEY_Shift_And_13.UseVisualStyleBackColor = true;
			KEY_Shift_And_13.Click += new EventHandler(KEY_Shift_And_13_Click);
			KEY_Shift_And_14.Location = new Point(564, 61);
			KEY_Shift_And_14.Name = "KEY_Shift_And_14";
			KEY_Shift_And_14.Size = new Size(41, 23);
			KEY_Shift_And_14.TabIndex = 97;
			KEY_Shift_And_14.Text = "{";
			KEY_Shift_And_14.UseVisualStyleBackColor = true;
			KEY_Shift_And_14.Click += new EventHandler(KEY_Shift_And_14_Click);
			KEY_Shift_And_15.Location = new Point(611, 61);
			KEY_Shift_And_15.Name = "KEY_Shift_And_15";
			KEY_Shift_And_15.Size = new Size(41, 23);
			KEY_Shift_And_15.TabIndex = 98;
			KEY_Shift_And_15.Text = "}";
			KEY_Shift_And_15.UseVisualStyleBackColor = true;
			KEY_Shift_And_15.Click += new EventHandler(KEY_Shift_And_15_Click);
			KEY_Shift_And_16.Location = new Point(423, 90);
			KEY_Shift_And_16.Name = "KEY_Shift_And_16";
			KEY_Shift_And_16.Size = new Size(41, 23);
			KEY_Shift_And_16.TabIndex = 99;
			KEY_Shift_And_16.Text = "|";
			KEY_Shift_And_16.UseVisualStyleBackColor = true;
			KEY_Shift_And_16.Click += new EventHandler(KEY_Shift_And_16_Click);
			KEY_Shift_And_17.Location = new Point(470, 90);
			KEY_Shift_And_17.Name = "KEY_Shift_And_17";
			KEY_Shift_And_17.Size = new Size(41, 23);
			KEY_Shift_And_17.TabIndex = 100;
			KEY_Shift_And_17.Text = "：";
			KEY_Shift_And_17.UseVisualStyleBackColor = true;
			KEY_Shift_And_17.Click += new EventHandler(KEY_Shift_And_17_Click);
			KEY_Shift_And_18.Location = new Point(517, 90);
			KEY_Shift_And_18.Name = "KEY_Shift_And_18";
			KEY_Shift_And_18.Size = new Size(41, 23);
			KEY_Shift_And_18.TabIndex = 101;
			KEY_Shift_And_18.Text = "＂";
			KEY_Shift_And_18.UseVisualStyleBackColor = true;
			KEY_Shift_And_18.Click += new EventHandler(KEY_Shift_And_18_Click);
			KEY_Shift_And_19.Location = new Point(564, 90);
			KEY_Shift_And_19.Name = "KEY_Shift_And_19";
			KEY_Shift_And_19.Size = new Size(41, 23);
			KEY_Shift_And_19.TabIndex = 102;
			KEY_Shift_And_19.Text = "＜";
			KEY_Shift_And_19.UseVisualStyleBackColor = true;
			KEY_Shift_And_19.Click += new EventHandler(KEY_Shift_And_19_Click);
			KEY_Shift_And_20.Location = new Point(611, 90);
			KEY_Shift_And_20.Name = "KEY_Shift_And_20";
			KEY_Shift_And_20.Size = new Size(41, 23);
			KEY_Shift_And_20.TabIndex = 103;
			KEY_Shift_And_20.Text = "＞";
			KEY_Shift_And_20.UseVisualStyleBackColor = true;
			KEY_Shift_And_20.Click += new EventHandler(KEY_Shift_And_20_Click);
			KEY_Shift_And_21.Location = new Point(423, 119);
			KEY_Shift_And_21.Name = "KEY_Shift_And_21";
			KEY_Shift_And_21.Size = new Size(41, 23);
			KEY_Shift_And_21.TabIndex = 104;
			KEY_Shift_And_21.Text = "？";
			KEY_Shift_And_21.UseVisualStyleBackColor = true;
			KEY_Shift_And_21.Click += new EventHandler(KEY_Shift_And_21_Click);

			AutoScaleDimensions = new SizeF(6f, 12f);
			AutoScaleMode = AutoScaleMode.Font;

			Controls.Add(KEY_Shift_And_21);
			Controls.Add(KEY_Shift_And_20);
			Controls.Add(KEY_Shift_And_19);
			Controls.Add(KEY_Shift_And_18);
			Controls.Add(KEY_Shift_And_17);
			Controls.Add(KEY_Shift_And_16);
			Controls.Add(KEY_Shift_And_15);
			Controls.Add(KEY_Shift_And_14);
			Controls.Add(KEY_Shift_And_13);
			Controls.Add(KEY_Shift_And_12);
			Controls.Add(KEY_Shift_And_11);
			Controls.Add(KEY_Shift_And_10);
			Controls.Add(KEY_Shift_And_9);
			Controls.Add(KEY_Shift_And_8);
			Controls.Add(KEY_Shift_And_7);
			Controls.Add(KEY_Shift_And_6);
			Controls.Add(KEY_Shift_And_5);
			Controls.Add(KEY_Shift_And_4);
			Controls.Add(KEY_Shift_And_3);
			Controls.Add(KEY_Shift_And_2);
			Controls.Add(KEY_Shift_And_1);
			Controls.Add(KEY_Ctrl_Alt_Shift_Win);
			Controls.Add(KEY_Shift_Win);
			Controls.Add(KEY_Ctrl_Alt_Win);
			Controls.Add(KEY_Ctrl_Shift_Alt);
			Controls.Add(KEY_Alt_Shift);
			Controls.Add(KEY_Ctrl_Shift);
			Controls.Add(KEY_Ctrl_Alt);
			Controls.Add(KEY_Win_Right_Click);
			Controls.Add(KEY_Alt_Right_Click);
			Controls.Add(KEY_Shift_Right_Click);
			Controls.Add(KEY_Ctrl_Right_Click);
			Controls.Add(KEY_Win_Left_Click);
			Controls.Add(KEY_Alt_Left_Click);
			Controls.Add(KEY_Shift_Left_Click);
			Controls.Add(KEY_Ctrl_Left_Click);

			Name = "Combination Keys";
			Size = new Size(858, 443);
			ResumeLayout(false);
		}
	}
}
