using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiniKeyboard48
{
	internal partial class LedFunctions : UserControl
	{
		private IContainer components;
		private Button KEY_LEDMode1;
		private Button KEY_LEDMode2;
		private Button KEY_LEDMode3;

		public LedFunctions()
		{
			InitializeComponent();
			KEY_Colour_Init();
		}

		private void KEY_Colour_Init()
		{
			int red = 152;
			int green = 251;
			int blue = 152;
			KEY_LEDMode1.BackColor = Color.FromArgb(red, green, blue);
			KEY_LEDMode2.BackColor = Color.FromArgb(red, green, blue);
			KEY_LEDMode3.BackColor = Color.FromArgb(red, green, blue);
		}

		private void LEDGeneral_Char_Set() => FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 8;

		private void KEY_LEDMode1_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeySet_KeyNum] = 176;
			LEDGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[2] = 0;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_LEDMode1.Text;
			KEY_Colour_Init();
			KEY_LEDMode1.BackColor = Color.FromArgb(byte.MaxValue, 48, 48);
		}

		private void KEY_LEDMode2_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeySet_KeyNum] = 176;
			LEDGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[2] = 1;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_LEDMode2.Text;
			KEY_Colour_Init();
			KEY_LEDMode2.BackColor = Color.FromArgb(byte.MaxValue, 48, 48);
		}

		private void KEY_LEDMode3_Click(object sender, EventArgs e)
		{
			FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeySet_KeyNum] = 176;
			LEDGeneral_Char_Set();
			FormMain.KeyParam.Data_Send_Buff[2] = 2;
			FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_LEDMode3.Text;
			KEY_Colour_Init();
			KEY_LEDMode3.BackColor = Color.FromArgb(byte.MaxValue, 48, 48);
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
			KEY_LEDMode1 = new Button();
			KEY_LEDMode2 = new Button();
			KEY_LEDMode3 = new Button();
			SuspendLayout();
			// 
			// KEY_LEDMode1
			// 
			KEY_LEDMode1.Location = new Point(5, 5);
			KEY_LEDMode1.Name = "KEY_LEDMode1";
			KEY_LEDMode1.Size = new Size(85, 35);
			KEY_LEDMode1.TabIndex = 2;
			KEY_LEDMode1.Text = "LED Mode 1";
			KEY_LEDMode1.UseVisualStyleBackColor = true;
			KEY_LEDMode1.Click += new EventHandler(KEY_LEDMode1_Click);
			// 
			// KEY_LEDMode2
			// 
			KEY_LEDMode2.Location = new Point(95, 5);
			KEY_LEDMode2.Name = "KEY_LEDMode2";
			KEY_LEDMode2.Size = new Size(85, 35);
			KEY_LEDMode2.TabIndex = 1;
			KEY_LEDMode2.Text = "LED Mode 2";
			KEY_LEDMode2.UseVisualStyleBackColor = true;
			KEY_LEDMode2.Click += new EventHandler(KEY_LEDMode2_Click);
			// 
			// KEY_LEDMode3
			// 
			KEY_LEDMode3.Location = new Point(190, 5);
			KEY_LEDMode3.Name = "KEY_LEDMode3";
			KEY_LEDMode3.Size = new Size(85, 35);
			KEY_LEDMode3.TabIndex = 0;
			KEY_LEDMode3.Text = "LED Mode 3";
			KEY_LEDMode3.UseVisualStyleBackColor = true;
			KEY_LEDMode3.Click += new EventHandler(KEY_LEDMode3_Click);
			// 
			// LedFunctions
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(KEY_LEDMode3);
			Controls.Add(KEY_LEDMode2);
			Controls.Add(KEY_LEDMode1);
			Name = "LedFunctions";
			Size = new Size(285, 45);
			ResumeLayout(false);

		}
	}
}
