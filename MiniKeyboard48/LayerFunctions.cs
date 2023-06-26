using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MiniKeyboard48
{
	internal partial class LayerFunctions : UserControl
	{
		private IContainer components;

		private RadioButton KEY_func_LAYER1;
		private RadioButton KEY_func_LAYER2;
		private RadioButton KEY_func_LAYER3;

		public LayerFunctions() => InitializeComponent();

		private void KEY_func_LAYER1_CheckedChanged(object sender, EventArgs e)
		{
			if (!KEY_func_LAYER1.Checked)
				return;
			FormMain.KeyParam.KEY_Cur_Layer = 1;
			FormMain.KeyParam.ShouldClearConfigBuffers = true;
		}

		private void KEY_func_LAYER2_CheckedChanged(object sender, EventArgs e)
		{
			if (!KEY_func_LAYER2.Checked)
				return;
			FormMain.KeyParam.KEY_Cur_Layer = 2;
			FormMain.KeyParam.ShouldClearConfigBuffers = true;
		}

		private void KEY_func_LAYER3_CheckedChanged(object sender, EventArgs e)
		{
			if (!KEY_func_LAYER3.Checked)
				return;
			FormMain.KeyParam.KEY_Cur_Layer = 3;
			FormMain.KeyParam.ShouldClearConfigBuffers = true;
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
			KEY_func_LAYER1 = new RadioButton();
			KEY_func_LAYER2 = new RadioButton();
			KEY_func_LAYER3 = new RadioButton();
			SuspendLayout();
			// 
			// KEY_func_LAYER1
			// 
			KEY_func_LAYER1.AutoSize = true;
			KEY_func_LAYER1.Checked = true;
			KEY_func_LAYER1.Location = new Point(3, 3);
			KEY_func_LAYER1.Name = "KEY_func_LAYER1";
			KEY_func_LAYER1.Size = new Size(60, 17);
			KEY_func_LAYER1.TabIndex = 0;
			KEY_func_LAYER1.TabStop = true;
			KEY_func_LAYER1.Text = "Layer 1";
			KEY_func_LAYER1.UseVisualStyleBackColor = true;
			KEY_func_LAYER1.CheckedChanged += new EventHandler(KEY_func_LAYER1_CheckedChanged);
			// 
			// KEY_func_LAYER2
			// 
			KEY_func_LAYER2.AutoSize = true;
			KEY_func_LAYER2.Location = new Point(90, 3);
			KEY_func_LAYER2.Name = "KEY_func_LAYER2";
			KEY_func_LAYER2.Size = new Size(60, 17);
			KEY_func_LAYER2.TabIndex = 1;
			KEY_func_LAYER2.TabStop = true;
			KEY_func_LAYER2.Text = "Layer 2";
			KEY_func_LAYER2.UseVisualStyleBackColor = true;
			KEY_func_LAYER2.CheckedChanged += new EventHandler(KEY_func_LAYER2_CheckedChanged);
			// 
			// KEY_func_LAYER3
			// 
			KEY_func_LAYER3.AutoSize = true;
			KEY_func_LAYER3.Location = new Point(180, 3);
			KEY_func_LAYER3.Name = "KEY_func_LAYER3";
			KEY_func_LAYER3.Size = new Size(60, 17);
			KEY_func_LAYER3.TabIndex = 2;
			KEY_func_LAYER3.TabStop = true;
			KEY_func_LAYER3.Text = "Layer 3";
			KEY_func_LAYER3.UseVisualStyleBackColor = true;
			KEY_func_LAYER3.CheckedChanged += new EventHandler(KEY_func_LAYER3_CheckedChanged);
			// 
			// LayerFunctions
			// 
			Controls.Add(KEY_func_LAYER3);
			Controls.Add(KEY_func_LAYER2);
			Controls.Add(KEY_func_LAYER1);
			Name = "LayerFunctions";
			Size = new Size(250, 25);
			ResumeLayout(false);
			PerformLayout();

		}
	}
}
