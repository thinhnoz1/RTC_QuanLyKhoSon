using BMS.Business;
using BMS.Model;
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
    public partial class frmPartImExHistory : _Forms
    {
        public frmPartImExHistory()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string keyword = txbSearchHistory.Text;
            DataTable dataTable = TextUtils.LoadDataFromSP("spGetHistoryByDate", "VS", new string[] { "@dateFrom", "@dateTo", "@keyword" }, new object[] { dtpFrom.Value.ToString("yyyy/MM/dd HH:mm:ss")
                                        , dtpTo.Value.ToString("yyyy/MM/dd HH:mm:ss")
                                        , keyword
                           });
            dtgvHistory.DataSource = dataTable;
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmPartImExHistory_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddHours(00).AddMinutes(00).AddSeconds(00);
            dtpTo.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            LoadData();

        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            string keyword = txbSearchHistory.Text;
            DataTable dataTable = TextUtils.LoadDataFromSP("spGetHistoryByDate", "VS", new string[] { "@dateFrom", "@dateTo", "@keyword" }, new object[] { dtpFrom.Value.ToString("yyyy/MM/dd HH:mm:ss")
                                        , dtpTo.Value.ToString("yyyy/MM/dd HH:mm:ss")
                                        , keyword
                           });
            dtgvHistory.DataSource = dataTable;
        }

        private void btnDelPart_Click(object sender, EventArgs e)
        {
            if (!gvHistory.IsDataRow(gvHistory.FocusedRowHandle))
                return;
            int strID = TextUtils.ToInt(gvHistory.GetFocusedRowCellValue("ID"));
            string str = TextUtils.ToString(gvHistory.GetFocusedRowCellValue("PartCode"));

            try
            {
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa lịch sử sản phẩm [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SONHistoryImExBO.Instance.Delete(strID);
                    LoadData();                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void btnEditPart_Click(object sender, EventArgs e)
        {
            int id = TextUtils.ToInt(gvHistory.GetFocusedRowCellValue(colID));
            if (id == 0) return;
            SONHistoryImExModel model = (SONHistoryImExModel)SONHistoryImExBO.Instance.FindByPK(id);
            frmAddEditHistory form = new frmAddEditHistory(); // Sua thong tin san pham
            form.model = model;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        
    }
}
