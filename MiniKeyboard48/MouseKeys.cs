using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiniKeyboard48
{
	internal partial class MouseKeys :UserControl
	{
		private IContainer components;
		private Button KEY_Mouse_Left;
		private Button KEY_Mouse_Right;
		private Button KEY_Mouse_Centre;
		private Button KEY_MOUSE_WHEEL_UP;
		private Button KEY_MOUSE_WHEEL_DOWN;
		private Button Ctrl_Mouse_wheel_Up;
		private Button Ctrl_Mouse_wheel_Down;
		private Button Shift_Mouse_wheel_Up;
		private Button Shift_Mouse_wheel_Down;
		private Button Alt_Mouse_wheel_Up;
		private Button Alt_Mouse_wheel_Down;

		public MouseKeys() => InitializeComponent();

		private void KEY_Colour_Init()
		{
			int red = 152;
			int green = 251;
			int blue = 152;
			KEY_Mouse_Left.BackColor = Color.FromArgb(red, green, blue);
			KEY_Mouse_Centre.BackColor = Color.FromArgb(red, green, blue);
			KEY_Mouse_Right.BackColor = Color.FromArgb(red, green, blue);
			KEY_MOUSE_WHEEL_UP.BackColor = Color.FromArgb(red, green, blue);
			KEY_MOUSE_WHEEL_DOWN.BackColor = Color.FromArgb(red, green, blue);
		}

		private void MouseGeneral_Char_Set() => FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 3;

		private void KEY_Mouse_Left_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 1;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 0;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Mouse_Left.Text;
		}

		private void KEY_Mouse_Centre_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 4;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 0;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Mouse_Centre.Text;
		}

		private void KEY_Mouse_Right_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 2;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 0;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Mouse_Right.Text;
		}

		private void KEY_MOUSE_WHEEL_UP_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 1;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_MOUSE_WHEEL_UP.Text;
		}

		private void KEY_MOUSE_WHEEL_DOWN_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = byte.MaxValue;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_MOUSE_WHEEL_DOWN.Text;
		}

		private void Ctrl_Mouse_wheel_Up_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 1;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 4] = 1;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = Ctrl_Mouse_wheel_Up.Text;
		}

		private void Ctrl_Mouse_wheel_Down_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = byte.MaxValue;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 4] = 1;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = Ctrl_Mouse_wheel_Down.Text;
		}

		private void Shift_Mouse_wheel_Up_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 1;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 4] = 2;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = Shift_Mouse_wheel_Up.Text;
		}

		private void Shift_Mouse_wheel_Down_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = byte.MaxValue;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 4] = 2;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = Shift_Mouse_wheel_Down.Text;
		}

		private void Alt_Mouse_wheel_Up_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = 1;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 4] = 4;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = Alt_Mouse_wheel_Up.Text;
		}

		private void Alt_Mouse_wheel_Down_Click(object sender, EventArgs e)
		{
			MouseGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 2] = 0;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 3] = byte.MaxValue;
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 4] = 4;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = Alt_Mouse_wheel_Down.Text;
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
			KEY_Mouse_Left = new Button();
			KEY_Mouse_Right = new Button();
			KEY_Mouse_Centre = new Button();
			KEY_MOUSE_WHEEL_UP = new Button();
			KEY_MOUSE_WHEEL_DOWN = new Button();
			Ctrl_Mouse_wheel_Up = new Button();
			Ctrl_Mouse_wheel_Down = new Button();
			Shift_Mouse_wheel_Up = new Button();
			Shift_Mouse_wheel_Down = new Button();
			Alt_Mouse_wheel_Up = new Button();
			Alt_Mouse_wheel_Down = new Button();
			SuspendLayout();
			// 
			// KEY_Mouse_Left
			// 
			KEY_Mouse_Left.Location = new Point(5, 5);
			KEY_Mouse_Left.Name = "KEY_Mouse_Left";
			KEY_Mouse_Left.Size = new Size(110, 25);
			KEY_Mouse_Left.TabIndex = 1;
			KEY_Mouse_Left.Text = "Mouse Left";
			KEY_Mouse_Left.UseVisualStyleBackColor = true;
			KEY_Mouse_Left.Click += new EventHandler(KEY_Mouse_Left_Click);
			// 
			// KEY_Mouse_Centre
			// 
			KEY_Mouse_Centre.Location = new Point(120, 5);
			KEY_Mouse_Centre.Name = "KEY_Mouse_Centre";
			KEY_Mouse_Centre.Size = new Size(110, 25);
			KEY_Mouse_Centre.TabIndex = 2;
			KEY_Mouse_Centre.Text = "Mouse Center";
			KEY_Mouse_Centre.UseVisualStyleBackColor = true;
			KEY_Mouse_Centre.Click += new EventHandler(KEY_Mouse_Centre_Click);
			// 
			// KEY_Mouse_Right
			// 
			KEY_Mouse_Right.Location = new Point(235, 5);
			KEY_Mouse_Right.Name = "KEY_Mouse_Right";
			KEY_Mouse_Right.Size = new Size(110, 25);
			KEY_Mouse_Right.TabIndex = 3;
			KEY_Mouse_Right.Text = "Mouse Right";
			KEY_Mouse_Right.UseVisualStyleBackColor = true;
			KEY_Mouse_Right.Click += new EventHandler(KEY_Mouse_Right_Click);
			// 
			// KEY_MOUSE_WHEEL_UP
			// 
			KEY_MOUSE_WHEEL_UP.Location = new Point(5, 35);
			KEY_MOUSE_WHEEL_UP.Name = "KEY_MOUSE_WHEEL_UP";
			KEY_MOUSE_WHEEL_UP.Size = new Size(165, 25);
			KEY_MOUSE_WHEEL_UP.TabIndex = 4;
			KEY_MOUSE_WHEEL_UP.Text = "Mouse Wheel Up";
			KEY_MOUSE_WHEEL_UP.UseVisualStyleBackColor = true;
			KEY_MOUSE_WHEEL_UP.Click += new EventHandler(KEY_MOUSE_WHEEL_UP_Click);
			// 
			// KEY_MOUSE_WHEEL_DOWN
			// 
			KEY_MOUSE_WHEEL_DOWN.Location = new Point(180, 35);
			KEY_MOUSE_WHEEL_DOWN.Name = "KEY_MOUSE_WHEEL_DOWN";
			KEY_MOUSE_WHEEL_DOWN.Size = new Size(165, 25);
			KEY_MOUSE_WHEEL_DOWN.TabIndex = 5;
			KEY_MOUSE_WHEEL_DOWN.Text = "Mouse Wheel Down";
			KEY_MOUSE_WHEEL_DOWN.UseVisualStyleBackColor = true;
			KEY_MOUSE_WHEEL_DOWN.Click += new EventHandler(KEY_MOUSE_WHEEL_DOWN_Click);
			// 
			// Ctrl_Mouse_wheel_Up
			// 
			Ctrl_Mouse_wheel_Up.Location = new Point(5, 65);
			Ctrl_Mouse_wheel_Up.Name = "Ctrl_Mouse_wheel_Up";
			Ctrl_Mouse_wheel_Up.Size = new Size(165, 25);
			Ctrl_Mouse_wheel_Up.TabIndex = 6;
			Ctrl_Mouse_wheel_Up.Text = "Ctrl + Mouse Wheel Up";
			Ctrl_Mouse_wheel_Up.Click += new EventHandler(Ctrl_Mouse_wheel_Up_Click);
			// 
			// Ctrl_Mouse_wheel_Down
			// 
			Ctrl_Mouse_wheel_Down.Location = new Point(180, 65);
			Ctrl_Mouse_wheel_Down.Name = "Ctrl_Mouse_wheel_Down";
			Ctrl_Mouse_wheel_Down.Size = new Size(165, 25);
			Ctrl_Mouse_wheel_Down.TabIndex = 7;
			Ctrl_Mouse_wheel_Down.Text = "Ctrl + Mouse Wheel Down";
			Ctrl_Mouse_wheel_Down.Click += new EventHandler(Ctrl_Mouse_wheel_Down_Click);
			// 
			// Shift_Mouse_wheel_Up
			// 
			Shift_Mouse_wheel_Up.Location = new Point(5, 95);
			Shift_Mouse_wheel_Up.Name = "Shift_Mouse_wheel_Up";
			Shift_Mouse_wheel_Up.Size = new Size(165, 25);
			Shift_Mouse_wheel_Up.TabIndex = 8;
			Shift_Mouse_wheel_Up.Text = "Shift + Mouse Wheel Up";
			Shift_Mouse_wheel_Up.Click += new EventHandler(Shift_Mouse_wheel_Up_Click);
			// 
			// Shift_Mouse_wheel_Down
			// 
			Shift_Mouse_wheel_Down.Location = new Point(180, 95);
			Shift_Mouse_wheel_Down.Name = "Shift_Mouse_wheel_Down";
			Shift_Mouse_wheel_Down.Size = new Size(165, 25);
			Shift_Mouse_wheel_Down.TabIndex = 9;
			Shift_Mouse_wheel_Down.Text = "Shift + Mouse Wheel Down";
			Shift_Mouse_wheel_Down.Click += new EventHandler(Shift_Mouse_wheel_Down_Click);
			// 
			// Alt_Mouse_wheel_Up
			// 
			Alt_Mouse_wheel_Up.Location = new Point(5, 125);
			Alt_Mouse_wheel_Up.Name = "Alt_Mouse_wheel_Up";
			Alt_Mouse_wheel_Up.Size = new Size(165, 25);
			Alt_Mouse_wheel_Up.TabIndex = 10;
			Alt_Mouse_wheel_Up.Text = "Alt + Mouse Wheel Up";
			Alt_Mouse_wheel_Up.Click += new EventHandler(Alt_Mouse_wheel_Up_Click);
			// 
			// Alt_Mouse_wheel_Down
			// 
			Alt_Mouse_wheel_Down.Location = new Point(180, 125);
			Alt_Mouse_wheel_Down.Name = "Alt_Mouse_wheel_Down";
			Alt_Mouse_wheel_Down.Size = new Size(165, 25);
			Alt_Mouse_wheel_Down.TabIndex = 11;
			Alt_Mouse_wheel_Down.Text = "Alt + Mouse Wheel Down";
			Alt_Mouse_wheel_Down.Click += new EventHandler(Alt_Mouse_wheel_Down_Click);
			// 
			// MouseKeys
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(Alt_Mouse_wheel_Down);
			Controls.Add(Alt_Mouse_wheel_Up);
			Controls.Add(Shift_Mouse_wheel_Down);
			Controls.Add(Shift_Mouse_wheel_Up);
			Controls.Add(Ctrl_Mouse_wheel_Down);
			Controls.Add(Ctrl_Mouse_wheel_Up);
			Controls.Add(KEY_MOUSE_WHEEL_DOWN);
			Controls.Add(KEY_MOUSE_WHEEL_UP);
			Controls.Add(KEY_Mouse_Centre);
			Controls.Add(KEY_Mouse_Right);
			Controls.Add(KEY_Mouse_Left);
			Name = "MouseKeys";
			Size = new Size(350, 155);
			ResumeLayout(false);

			PerformLayout();
		}
	}
}
