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
	public partial class frmAddEditMotorPart : _Forms
	{
		public MotorPartListModel motorPart = new MotorPartListModel();
		private int type;
		private int currentStorageSelection;

		public int Type
		{
			get
			{
				return type;
			}

			set
			{
				type = value;
			}
		}

		public int CurrentStorageSelection
		{
			get
			{
				return currentStorageSelection;
			}

			set
			{
				currentStorageSelection = value;
			}
		}

		public frmAddEditMotorPart(int type)
		{
			InitializeComponent();
			Type = type;
			if (Type == 1) {
				this.Text = "THÊM DANH MỤC LINH KIỆN";
			}
			if (Type == 2)
			{
				this.Text = "SỬA DANH MỤC LINH KIỆN";
			}
		}


		void LoadStorage() {
			DataTable tbl = TextUtils.Select("Select * from MotorStorageList with(nolock) order by id asc");
			cbStorage.Properties.DataSource = tbl;
			cbStorage.Properties.DisplayMember = "StorageCode";
			cbStorage.Properties.ValueMember = "id";
		}

		void LoadDataToForm() {
			txbPartCode.Text = motorPart.PartCode;
			cbStorage.EditValue = motorPart.StorageID;
			txbDescription.Text = motorPart.Description;
			txbQuantity.Value = motorPart.Quantity;
		}

		private bool ValidateForm()
		{
			if (cbStorage.EditValue == null)
			{
				MessageBox.Show("Xin hãy chọn vị trí kho.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (string.IsNullOrEmpty(txbPartCode.Text.Trim()))
			{
				MessageBox.Show("Xin hãy nhập mã linh kiện.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			else
			{
				if (Type == 1) {
					if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim())) { 
						MessageBox.Show("Xin hãy nhập mã linh kiện.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return false;
					}
				}
			}
			return true;
		}

		bool SaveData() {
			if (!ValidateForm()) {
				return false;
			}
			DataRowView chooseData = (DataRowView)cbStorage.GetSelectedDataRow();
			
			motorPart.PartCode = txbPartCode.Text.Trim();
			motorPart.StorageID = TextUtils.ToInt(chooseData.Row.ItemArray[0]);
			motorPart.StorageCode = TextUtils.ToString(chooseData.Row.ItemArray[1]);
			motorPart.Description = txbDescription.Text;
			motorPart.Quantity = TextUtils.ToInt(txbQuantity.Value);
			if (Type == 1)
				motorPart.CreatedDate = DateTime.Now;
			if (Type == 2)
				motorPart.ModifiedDate = DateTime.Now;

			try
			{
				if (motorPart.Id > 0)
				{
					TextUtils.ExcuteProcedure("spMotorUpdatePart",
							new string[] { "@id", "@partCode", "@storageID", "@storageCode", "@description", "@quantity", "@modifiedDate" },
							new object[] { motorPart.Id, motorPart.PartCode, motorPart.StorageID, motorPart.StorageCode, motorPart.Description, motorPart.Quantity, motorPart.ModifiedDate});
				}
				else { 
					decimal test = MotorPartListBO.Instance.Insert(motorPart);
				}

			}
			catch (Exception e) {
				return false;
			}
			return true;
		}

		private void frmAddEditMotorPart_Load(object sender, EventArgs e)
		{
			LoadStorage();
			if (CurrentStorageSelection > 0)
			{
				cbStorage.EditValue = CurrentStorageSelection;
			}
			if (Type == 2)
				LoadDataToForm();
		}

		private void frmAddEditMotorPart_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;

		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			if (SaveData())
				this.DialogResult = DialogResult.OK;
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				motorPart = new MotorPartListModel();
				LoadDataToForm();
			}
		}

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveClose_Click(null, null);
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}
	}
}
