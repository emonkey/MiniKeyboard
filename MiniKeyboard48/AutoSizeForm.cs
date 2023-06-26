using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MiniKeyboard48
{
	internal class AutoSizeForm
	{
		public List<controlRect> oldCtrl = new List<controlRect>();

		private int ctrlNo;

		public void controllInitializeSize(Control mForm)
		{
			controlRect controlRect;
			controlRect.Left = mForm.Left;
			controlRect.Top = mForm.Top;
			controlRect.Width = mForm.Width;
			controlRect.Height = mForm.Height;
			oldCtrl.Add(controlRect);
			AddControl(mForm);
		}

		private void AddControl(Control ctl)
		{
			foreach (Control control in (ArrangedElementCollection)ctl.Controls)
			{
				controlRect controlRect;
				controlRect.Left = control.Left;
				controlRect.Top = control.Top;
				controlRect.Width = control.Width;
				controlRect.Height = control.Height;
				oldCtrl.Add(controlRect);
				if (control.Controls.Count > 0)
					AddControl(control);
			}
		}

		public void controlAutoSize(Control mForm)
		{
			if (ctrlNo == 0)
			{
				controlRect controlRect;
				controlRect.Left = 0;
				controlRect.Top = 0;
				controlRect.Width = mForm.PreferredSize.Width;
				controlRect.Height = mForm.PreferredSize.Height;
				oldCtrl.Add(controlRect);
				AddControl(mForm);
			}
			float wScale = mForm.Width / (float)oldCtrl[0].Width;
			float hScale = mForm.Height / (float)oldCtrl[0].Height;
			ctrlNo = 1;
			AutoScaleControl(mForm, wScale, hScale);
		}

		private void AutoScaleControl(Control ctl, float wScale, float hScale)
		{
			foreach (Control control in (ArrangedElementCollection)ctl.Controls)
			{
				int left = oldCtrl[ctrlNo].Left;
				int top = oldCtrl[ctrlNo].Top;
				int width1 = oldCtrl[ctrlNo].Width;
				int height = oldCtrl[ctrlNo].Height;
				control.Left = (int)(left * (double)wScale);
				control.Top = (int)(top * (double)hScale);
				control.Width = (int)(width1 * (double)wScale);
				control.Height = (int)(height * (double)hScale);
				++ctrlNo;
				if (control.Controls.Count > 0)
					AutoScaleControl(control, wScale, hScale);
				if (ctl is DataGridView)
				{
					DataGridView dataGridView = ctl as DataGridView;
					Cursor.Current = Cursors.WaitCursor;
					int num1 = 0;
					for (int index = 0; index < dataGridView.Columns.Count; ++index)
					{
						dataGridView.AutoResizeColumn(index, DataGridViewAutoSizeColumnMode.AllCells);
						num1 += dataGridView.Columns[index].Width;
					}
					int num2 = num1;
					int width2 = ctl.Size.Width;
					dataGridView.AutoSizeColumnsMode = num2 < width2 ? DataGridViewAutoSizeColumnsMode.Fill : DataGridViewAutoSizeColumnsMode.DisplayedCells;
					Cursor.Current = Cursors.Default;
				}
			}
		}

		public struct controlRect
		{
			public int Left;
			public int Top;
			public int Width;
			public int Height;
		}
	}
}
