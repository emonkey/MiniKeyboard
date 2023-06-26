using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiniKeyboard48
{
	internal partial class MediaKeys : UserControl
	{
		private IContainer components;
		private Button KEY_Play;
		private Button KEY_VolumeUP;
		private Button KEY_VolumeDOWN;
		private Button KEY_PrevSong;
		private Button KEY_NextSong;
		private Button KEY_Mute;

		public MediaKeys() => InitializeComponent();

		private void MULGeneral_Char_Set() => FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.KeyType_Num] |= 2;

		private void KEY_Play_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.ReportID == 0)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 64;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Play.Text;
				MULGeneral_Char_Set();
			}
			else if (FormMain.KeyParam.ReportID == 2)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 4;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Play.Text;
				MULGeneral_Char_Set();
			}
			else
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 205;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Play.Text;
				MULGeneral_Char_Set();
			}
		}

		private void KEY_PrevSong_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.ReportID == 0)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 128;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_PrevSong.Text;
				MULGeneral_Char_Set();
			}
			else if (FormMain.KeyParam.ReportID == 2)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 11;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_PrevSong.Text;
				MULGeneral_Char_Set();
			}
			else
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 182;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_PrevSong.Text;
				MULGeneral_Char_Set();
			}
		}

		private void KEY_NextSong_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.ReportID == 0)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 1;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_NextSong.Text;
				MULGeneral_Char_Set();
			}
			else if (FormMain.KeyParam.ReportID == 2)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 10;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_NextSong.Text;
				MULGeneral_Char_Set();
			}
			else
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 181;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_NextSong.Text;
				MULGeneral_Char_Set();
			}
		}

		private void KEY_Mute_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.ReportID == 0)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 4;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Mute.Text;
				MULGeneral_Char_Set();
			}
			else if (FormMain.KeyParam.ReportID == 2)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num + 1] = 1;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Mute.Text;
				MULGeneral_Char_Set();
			}
			else
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 226;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_Mute.Text;
				MULGeneral_Char_Set();
			}
		}

		private void KEY_VolumeUP_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.ReportID == 0)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 2;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_VolumeUP.Text;
				MULGeneral_Char_Set();
			}
			else if (FormMain.KeyParam.ReportID == 2)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 64;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_VolumeUP.Text;
				MULGeneral_Char_Set();
			}
			else
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 233;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_VolumeUP.Text;
				MULGeneral_Char_Set();
			}
		}

		private void KEY_VolumeDOWN_Click(object sender, EventArgs e)
		{
			if (FormMain.KeyParam.ReportID == 0)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 1;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_VolumeDOWN.Text;
				MULGeneral_Char_Set();
			}
			else if (FormMain.KeyParam.ReportID == 2)
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 128;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_VolumeDOWN.Text;
				MULGeneral_Char_Set();
			}
			else
			{
				FormMain.KeyParam.Data_Send_Buff[FormMain.KeyParam.Key_Char_Num] = 234;
				FormMain.KeyParam.KeyChar[FormMain.KeyParam.Key_Char_Num - 5] = KEY_VolumeDOWN.Text;
				MULGeneral_Char_Set();
			}
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
			KEY_Play = new Button();
			KEY_VolumeUP = new Button();
			KEY_VolumeDOWN = new Button();
			KEY_PrevSong = new Button();
			KEY_NextSong = new Button();
			KEY_Mute = new Button();
			SuspendLayout();
			// 
			// KEY_Play
			// 
			KEY_Play.Location = new Point(5, 5);
			KEY_Play.Name = "KEY_Play";
			KEY_Play.Size = new Size(85, 25);
			KEY_Play.TabIndex = 1;
			KEY_Play.Text = "Play/Pause";
			KEY_Play.UseVisualStyleBackColor = true;
			KEY_Play.Click += new EventHandler(KEY_Play_Click);
			// 
			// KEY_VolumeUP
			// 
			KEY_VolumeUP.Location = new Point(95, 35);
			KEY_VolumeUP.Name = "KEY_VolumeUP";
			KEY_VolumeUP.Size = new Size(85, 25);
			KEY_VolumeUP.TabIndex = 5;
			KEY_VolumeUP.Text = "Volume +";
			KEY_VolumeUP.UseVisualStyleBackColor = true;
			KEY_VolumeUP.Click += new EventHandler(KEY_VolumeUP_Click);
			// 
			// KEY_VolumeDOWN
			// 
			KEY_VolumeDOWN.Location = new Point(185, 35);
			KEY_VolumeDOWN.Name = "KEY_VolumeDOWN";
			KEY_VolumeDOWN.Size = new Size(85, 25);
			KEY_VolumeDOWN.TabIndex = 6;
			KEY_VolumeDOWN.Text = "Volume -";
			KEY_VolumeDOWN.UseVisualStyleBackColor = true;
			KEY_VolumeDOWN.Click += new EventHandler(KEY_VolumeDOWN_Click);
			// 
			// KEY_PrevSong
			// 
			KEY_PrevSong.Location = new Point(95, 5);
			KEY_PrevSong.Name = "KEY_PrevSong";
			KEY_PrevSong.Size = new Size(85, 25);
			KEY_PrevSong.TabIndex = 2;
			KEY_PrevSong.Text = "Previous";
			KEY_PrevSong.UseVisualStyleBackColor = true;
			KEY_PrevSong.Click += new EventHandler(KEY_PrevSong_Click);
			// 
			// KEY_NextSong
			// 
			KEY_NextSong.Location = new Point(185, 5);
			KEY_NextSong.Name = "KEY_NextSong";
			KEY_NextSong.Size = new Size(85, 25);
			KEY_NextSong.TabIndex = 3;
			KEY_NextSong.Text = "Next";
			KEY_NextSong.UseVisualStyleBackColor = true;
			KEY_NextSong.Click += new EventHandler(KEY_NextSong_Click);
			// 
			// KEY_Mute
			// 
			KEY_Mute.Location = new Point(5, 35);
			KEY_Mute.Name = "KEY_Mute";
			KEY_Mute.Size = new Size(85, 25);
			KEY_Mute.TabIndex = 4;
			KEY_Mute.Text = "Mute";
			KEY_Mute.UseVisualStyleBackColor = true;
			KEY_Mute.Click += new EventHandler(KEY_Mute_Click);
			// 
			// MediaKeys
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(KEY_Mute);
			Controls.Add(KEY_NextSong);
			Controls.Add(KEY_PrevSong);
			Controls.Add(KEY_VolumeDOWN);
			Controls.Add(KEY_VolumeUP);
			Controls.Add(KEY_Play);
			Name = "MediaKeys";
			Size = new Size(275, 65);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
