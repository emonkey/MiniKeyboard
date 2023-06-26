using System;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;

namespace MiniKeyboard48
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

			InitializeComponent();

			hidOps.DataReceived += new EventHandler<Report>(myhid_DataReceived);
			hidOps.DeviceRemoved += new EventHandler(myhid_DeviceRemoved);

			MenuList();
			Colour_Init();
			StartIntervalTimer();
			Hide_Dowload_Text();
			LayerFunctionsList();
		}
	}
}
