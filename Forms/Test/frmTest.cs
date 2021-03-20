using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmTest : Form
	{
		public frmTest()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			if (cbOptions.SelectedIndex == 0) {
				BMS.frmProductListSON frm = new BMS.frmProductListSON();
				frm.Show();
			}
			if (cbOptions.SelectedIndex == 1)
			{
				BMS.frmMotorPartList frm = new BMS.frmMotorPartList();
				frm.Show();
			}
		}

		private void frmTest_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
	}
}
