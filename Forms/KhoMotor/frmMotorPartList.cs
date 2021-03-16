﻿using System;
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
	public partial class frmMotorPartList : _Forms
	{
		int _curentNode = 0;
		int _catID = 0;
		int _rowHandle = 0;
		int prevRow;

		public frmMotorPartList()
		{
			InitializeComponent();
		}

		void LoadPartList()
		{

			int id = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
			if (id > 0)
			{
				DataTable arr = TextUtils.LoadDataFromSP("spGetMotorPartListWithFilter"
									  , "A"
									  , new string[] { "@keyword", "@positionID" }
									   , new object[] { txbSearch.Text.Trim(), id }
						);
				dtgvMotorList.DataSource = arr;
			}
		}

		void LoadPositionList() {
			ArrayList arr = MotorPositionListBO.Instance.FindAll();
			treeData.DataSource = arr;
		}

		private void frmMotorPartList_Load(object sender, EventArgs e)
		{
			LoadPositionList();
			LoadPartList();
		}

		private void btnCreatePart_Click(object sender, EventArgs e)
		{
			frmAddEditMotorPart frm = new frmAddEditMotorPart(1);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadPartList();
			}
		}
		private void btnEditPart_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvMotor.GetFocusedRowCellValue(colID));
			if (id == 0) return;
			//  Lay so dong da chon
			prevRow = gvMotor.GetSelectedRows()[0];
			MotorPartListModel model = (MotorPartListModel)MotorPartListBO.Instance.FindByPK(id);

			frmAddEditMotorPart frm = new frmAddEditMotorPart(2);
			frm.motorPart = model;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadPartList();
				gvMotor.FocusedRowHandle = prevRow;
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
			frmMotorHistoryImEx frm = new frmMotorHistoryImEx();
			frm.ShowDialog();
		}

		private void btnFindAll_Click(object sender, EventArgs e)
		{

		}

		private void gvMotor_DoubleClick(object sender, EventArgs e)
		{
			btnEditPart_Click(null, null);
		}

		private void btnImportPart_Click(object sender, EventArgs e)
		{

		}

		private void treeData_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			try
			{
				int id = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
				if (id > 0)
				{
					txbSearch.Text = "";
					LoadPartList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadPartList();
			LoadPositionList();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadPartList();
		}

		private void btnCancelSearch_Click(object sender, EventArgs e)
		{
			txbSearch.Text = "";
			LoadPartList();
		}
	}
}
