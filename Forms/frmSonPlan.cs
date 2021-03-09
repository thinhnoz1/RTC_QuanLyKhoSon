using System;
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
    public partial class frmSonPlan : _Forms
    {
        public frmSonPlan()
        {
            InitializeComponent();
            LoadDataToForm();
        }

        #region Method
        void LoadDataToForm() {
            string sql = "select ROW_NUMBER() OVER (ORDER BY ID) AS STT, * from SonPlan";
            DataTable dt = TextUtils.Select(sql);
            dtgvSonPlan.DataSource = dt;
        }
        #endregion


		#region Event
		/// <summary>
		/// All form events
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnImportExcel_Click(object sender, EventArgs e)
		{
            frmImportExcel frm = new frmImportExcel();
            frm.ShowDialog();
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
            try
            {
                if (gvSonPlan.RowCount > 0)
                {
                    FolderBrowserDialog od = new FolderBrowserDialog();
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        TextUtils.ExportExcel(gvSonPlan, od.SelectedPath, string.Format("DanhSachKeHoachKhoSon_{0}", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
		private void frmSonPlan_Load(object sender, EventArgs e)
		{

		}
		#endregion

		private void btnCreatePlan_Click(object sender, EventArgs e)
		{

		}

		private void btnEditPlan_Click(object sender, EventArgs e)
		{

		}

		private void btnDelPlan_Click(object sender, EventArgs e)
		{

		}
	}
}
