using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.Business;
using BMS.Model;

namespace BMS
{
	public partial class frmMotorPartDetails : _Forms
	{
		public MotorPartListModel motorPartList = new MotorPartListModel();
		public frmMotorPartDetails()
		{
			InitializeComponent();
		}

		void GetPartDetails() {
			if (motorPartList != null)
			{
				string sql = string.Format("select ROW_NUMBER() OVER (ORDER BY ID) AS STT, * from MotorPartListDetails where PartID = {0}", motorPartList.ID);
				DataTable tb = TextUtils.Select(sql);
				dtgvMotorDetails.DataSource = tb;
			}
			else
				MessageBox.Show("Không tải được dữ liệu !");
		}
		private void frmMotorPartDetails_Load(object sender, EventArgs e)
		{
			GetPartDetails();
		}

		private void btnEditPart_Click(object sender, EventArgs e)
		{
			frmAddEditMotorPart frm = new frmAddEditMotorPart(2);
			frm.motorPart = motorPartList;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				GetPartDetails();
			}
		}

		private void frmMotorPartDetails_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
