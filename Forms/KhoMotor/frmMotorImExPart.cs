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
using BMS.Business;
using BMS.Model;
namespace BMS
{
	public partial class frmMotorImExPart : _Forms
	{
		public MotorPartListModel motorPart = new MotorPartListModel();
		private int type;
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

		/// <summary>
		/// Type = 1 <=> Xuất khẩu
		/// Type = 2 <=> Nhập khẩu
		/// </summary>
		/// <param name="type"></param>
		public frmMotorImExPart(int type)
		{
			InitializeComponent();
			Type = type;
			if (Type == 1)
			{
				this.Text = "Xuất linh kiện";
			}
			if (Type == 2)
			{
				this.Text = "Nhập linh kiện";
			}
		}

		void LoadPosition() {
			DataTable dt = TextUtils.Select("Select * from MotorPositionList");
			cbPosition.Properties.DataSource = dt;
			cbPosition.Properties.DisplayMember = "PositionCode";
			cbPosition.Properties.ValueMember = "ID";
		}
		void LoadDataToForm()
		{
			txbPartCode.Text = motorPart.PartCode;
			txbQuantity.Value = motorPart.Quantity;
		}

		bool SaveData() {
			if (cbPosition.EditValue == null) {
				MessageBox.Show("Vui lòng chọn vị trí!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (MessageBox.Show(String.Format("Bạn có chắc muốn lưu không?"), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (txbQuantity.Value > 0)
				{

					motorPart.PartCode = txbPartCode.Text.Trim();
					
					if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
					{
						TextUtils.ExcuteProcedure("spMotorImportPart",
									new string[] { "@partID" , "@partCode" , "@positionID" , "@quantity" , "@workerCode"  },
									new object[] { motorPart.ID, motorPart.PartCode, TextUtils.ToInt(cbPosition.EditValue), txbQuantity.Value, txbWorkerCode.Text});
						return true;
					}
					else
					{
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

		private void frmMotorImExPart_Load(object sender, EventArgs e)
		{
			LoadPosition();
			LoadDataToForm();
		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			if (motorPart.ID != 0)
			{
				if (SaveData())
				{
					this.DialogResult = DialogResult.OK;
				}
				else { 
					MessageBox.Show("Lưu thất bại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			else {
				if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
				{
					ArrayList arrProduct = SonPlanBO.Instance.FindByAttribute("PartCode", txbPartCode.Text.Trim());
					MotorPartListModel model = arrProduct[0] as MotorPartListModel;
					motorPart.ID = model.ID;
					if (SaveData())
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("Lưu thất bại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
			}
		}

	

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (motorPart.ID != 0)
			{
				if (SaveData())
				{
					motorPart = new MotorPartListModel();
					LoadDataToForm();
				}
				else
				{
					MessageBox.Show("Lưu thất bại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			else
			{
				if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
				{
					ArrayList arrProduct = SonPlanBO.Instance.FindByAttribute("PartCode", txbPartCode.Text.Trim());
					MotorPartListModel model = arrProduct[0] as MotorPartListModel;
					motorPart.ID = model.ID;
					if (SaveData())
					{
						motorPart = new MotorPartListModel();
						LoadDataToForm();
					}
					else
					{
						MessageBox.Show("Lưu thất bại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
			}
		}

		private void frmMotorImExPart_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
