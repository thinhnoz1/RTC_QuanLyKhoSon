using BMS.Business;
using BMS.Model;
using BMS.Utils;
using DevExpress.XtraCharts;
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
    public partial class frmImportPart : _Forms
    {
        public frmImportPart()
        {
            InitializeComponent();
            txbWorkerCode.Focus();

        }


        #region Method
        bool SaveData() {
            if (MessageBox.Show(String.Format("Bạn có chắc muốn lưu không?"), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txbQuantity.Value > 0)
                {
                    if (PartSonBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
                    {
                        int type;
                        if (txbType.Text == "Xuất khẩu")
                            type = 1;
                        else type = 0; // lap rap
                        TextUtils.ExcuteProcedure("spImportPart",
                                    new string[] { "@partCode", "@orderCode", "@quantity", "@workerCode", "@partType" },
                                    new object[] { txbPartCode.Text.Trim(), txbOrderCode.Text.Trim(), (int)txbQuantity.Value, txbWorkerCode.Text, type });
                        return true;
                    }
                    else {
                        MessageBox.Show("Mã linh kiện không tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

            }
            else return false;
        }
        void LoadDataToChart()
        {
            //string sql = "SELECT * FROM dbo.SONHistoryImEx WHERE DateImEx <= DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE)) AND DateImEx > DATEADD(DD, -30, CAST(CURRENT_TIMESTAMP AS DATE))";



            DataTable dt = TextUtils.LoadDataFromSP("spGetSonParImportDataByDate","A", new string[] { "@numofdate" }, new object[] { 30 });
            DataTable table = new DataTable();
            DataRow row = null;

            table.Columns.Add("Day", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            int sumQuantity = 0;

            //  Gian cach chart
            row = table.NewRow();
            row["Day"] = " ";
            row["Quantity"] = 0;
            table.Rows.Add(row);

            //  Lấy dữ liệu ta cần từ list data 
            //  Trong bang, cot thu [3] la DateImEx, [4] la Quantity
            for (int i = 0; i < 31; i++)
            {
                DateTime past = DateTime.Now.AddDays(-i);
                foreach (DataRow model in dt.Rows)
                {
                    DateTime day = (DateTime)model.ItemArray[3];
                    int quantity = (int)model.ItemArray[4];
                    if (day.Day == past.Day && day.Month == past.Month)
                    {
                        sumQuantity = sumQuantity + quantity;
                    }

                }
                row = table.NewRow();
                row["Day"] = past.Day.ToString() + "/" + past.Month.ToString();
                row["Quantity"] = sumQuantity;
                table.Rows.Add(row);
                sumQuantity = 0;
            }

            // Them 1 dong de gian cach cot cuoi voi vien` chart
            row = table.NewRow();
            row["Day"] = "->";
            row["Quantity"] = 0;
            table.Rows.Add(row);

            chartControl2.Series[0].DataSource = table;
            chartControl2.Series[0].ArgumentScaleType = ScaleType.Auto;
            chartControl2.Series[0].ArgumentDataMember = "Day";
            chartControl2.Series[0].ValueScaleType = ScaleType.Numerical;
            chartControl2.Series[0].ValueDataMembers.AddRange(new string[] { "Quantity" });
        }
        #endregion


        #region Event
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                LoadDataToChart();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void frmImportPart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                txbPartCode.Text = "";
                txbOrderCode.Text = "";
                txbCurrentQuantity.Text = "";
                txbQuantity.Value = 0;
                txbType.Text = "";
                LoadDataToChart();
                txbOrderCode.Focus();
            }
        }
        private void frmImportPart_Load(object sender, EventArgs e)
        {
            LoadDataToChart();
        }
        private void txbOrderCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                try
                {
                    txbType.Text = "";
                    txbCurrentQuantity.Text = "";
                    txbPartCode.Text = "";
                    if (SonPlanBO.Instance.CheckExist("OrderCode", txbOrderCode.Text.Trim()))
                    {
                        txbType.Text = "Xuất khẩu";
                        string str = txbOrderCode.Text.Trim();
                        ArrayList arrProduct = SonPlanBO.Instance.FindByAttribute("OrderCode", str);
                        SonPlanModel model = arrProduct[0] as SonPlanModel;
                        txbPartCode.Text = model.PartCode;

                        txbPartCode_KeyPress(new object(), new KeyPressEventArgs((char)13));
                    }
                    else
                    {
                        txbType.Text = "Lắp ráp";
                        txbPartCode.Focus();
                        txbPartCode.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void txbPartCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    txbCurrentQuantity.Text = "";
                    string query = string.Format("SELECT ISNULL((SELECT SUM(Quantity) FROM dbo.SONHistoryImEx WHERE PartCode = '{0}' AND DateImEx >= CAST(CURRENT_TIMESTAMP AS DATE) AND DateImEx < DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE))), -1)", txbPartCode.Text.Trim());
                    int quantity = (int)TextUtils.ExcuteScalar(query);
                    if (quantity == -1) {
                        txbQuantity.Focus();
                        txbQuantity.Select(0, txbQuantity.Text.Length);
                        txbCurrentQuantity.Text = "0";
                    }
                    else {
                        txbQuantity.Focus();
                        txbQuantity.Select(0, txbQuantity.Text.Length);
                        txbCurrentQuantity.Text = quantity.ToString();
                    }

                }
                catch (Exception er)
                {

                }
            }
        }
        #endregion
    }
}
