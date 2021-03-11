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
				DataTable tbl = TextUtils.Select("Select * from MotorStorageList with(nolock) order by id");

				trdStorageList.DataSource = tbl;
				trdStorageList.KeyFieldName = "ID";
				trdStorageList.PreviewFieldName = "StorageName";
				trdStorageList.ExpandAll();

				DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = trdStorageList.FindNodeByFieldValue("ID", _curentNode);
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
	}
}
