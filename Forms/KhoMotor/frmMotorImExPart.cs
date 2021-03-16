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

		void LoadDataToForm()
		{

			txbPartCode.Text = motorPart.PartCode;
			txbQuantity.Value = motorPart.Quantity;
			//cb
		}

		private void frmMotorImExPart_Load(object sender, EventArgs e)
		{

		}
	}
}
