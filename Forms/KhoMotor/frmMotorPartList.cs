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
	public partial class frmMotorPartList : _Forms
	{
		int _curentNode = 0;
		int _catID = 0;
		int _rowHandle = 0;

		public frmMotorPartList()
		{
			InitializeComponent();
		}

		void LoadPartList()
		{
			_catID = TextUtils.ToInt(trdStorageList.FocusedNode.GetValue(tlID));
			//paraName[0] = "@GroupID"; paraValue[0] = _catID;
			//paraName[1] = "@TextFilter"; paraValue[1] = txtName.Text.Trim();

			DataTable arr = TextUtils.LoadDataFromSP("spGetMotorPartListWithFilter"
								  , "A"
								  , new string[] { "@storageID", "@keyword" }
								   , new object[] { _catID, txtName.Text.Trim() }
					);
			dtgvMotorList.DataSource = arr;
		}

		void loadTree()
		{
			try
			{
				DataTable tbl = TextUtils.Select("Select * from MotorStorageList with(nolock) order by id asc");

				trdStorageList.DataSource = tbl;
				/*trdStorageList.KeyFieldName = "ID";
				trdStorageList.PreviewFieldName = "StorageName";*/
				trdStorageList.ExpandAll();

				DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = trdStorageList.FindNodeByFieldValue("id", _curentNode);
				trdStorageList.SetFocusedNode(currentNode);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void frmMotorPartList_Load(object sender, EventArgs e)
		{
			loadTree();

		}


		private void trdStorageList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			try
			{
				int id = TextUtils.ToInt(trdStorageList.FocusedNode.GetValue(tlID));
				if (id > 0)
				{
					txtName.Text = txtName.Text = "";
					LoadPartList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnCreatePart_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(trdStorageList.FocusedNode.GetValue(tlID));
			frmAddEditMotorPart frm = new frmAddEditMotorPart(1);
			frm.CurrentStorageSelection= id;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadPartList();
			}
		}

		private void btnEditPart_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvMotor.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			MotorPartListModel model = (MotorPartListModel)MotorPartListBO.Instance.FindByPK(id);
			int catId = TextUtils.ToInt(gvMotor.GetFocusedRowCellValue(colStorageID));
			_rowHandle = gvMotor.FocusedRowHandle;

			frmAddEditMotorPart frm = new frmAddEditMotorPart(2);
			frm.CurrentStorageSelection = catId;
			frm.motorPart = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadPartList();
			}
		}

		private void btnDelPart_Click(object sender, EventArgs e)
		{
			if (!gvMotor.IsDataRow(gvMotor.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvMotor.GetFocusedRowCellValue(colID));
			string str = TextUtils.ToString(gvMotor.GetFocusedRowCellValue("PartCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa linh kiện [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (MotorHistoryImExBO.Instance.CheckExist("PartID", strID))
					{
						MessageBox.Show("Linh kiện này đã có lịch sử xuất/nhập nên không thể xóa được!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}
					else
					{
						MotorPartListBO.Instance.Delete(strID);
						gvMotor.DeleteRow(gvMotor.FocusedRowHandle);
						MessageBox.Show("Xoá thành công", TextUtils.Caption);
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvMotor.RowCount > 0)
				{
					FolderBrowserDialog od = new FolderBrowserDialog();
					if (od.ShowDialog() == DialogResult.OK)
					{
						TextUtils.ExportExcel(gvMotor, od.SelectedPath, string.Format("DslinhkienMotor_{0}", DateTime.Now.ToString("yyyy_MM_dd")));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnHistory_Click(object sender, EventArgs e)
		{

		}
	}
}
