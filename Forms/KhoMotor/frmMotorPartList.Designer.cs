﻿
namespace Forms.KhoMotor
{
	partial class frmMotorPartList
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotorPartList));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnNewGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDeleteGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSungLuc = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnUpdateStepCode = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeData = new DevExpress.XtraTreeList.TreeList();
			this.btnFindAll = new DevExpress.XtraEditors.SimpleButton();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGroup = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRatioCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colXuatLucSealCap = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLoaiMoNapDau = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLoaiMoBomHopSo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLucCheckGear = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGunNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBuLongNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShootNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtyOcBanGa = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSetForce = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMotorCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCoilCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDienAp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanSo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDongDien = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNhapLucWo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVongQuay = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTiengOn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDoRungFFT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGoal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.mnuMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewGroup,
            this.toolStripSeparator9,
            this.btnEditGroup,
            this.toolStripSeparator8,
            this.btnDeleteGroup,
            this.toolStripSeparator1,
            this.btnAdd,
            this.toolStripSeparator6,
            this.btnEdit,
            this.toolStripSeparator4,
            this.btnDel,
            this.toolStripSeparator10,
            this.btnSungLuc,
            this.toolStripSeparator5,
            this.btnExcel,
            this.toolStripSeparator3,
            this.btnImportExcel,
            this.toolStripSeparator2,
            this.btnUpdateStepCode});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(1403, 52);
			this.mnuMenu.TabIndex = 21;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnNewGroup
			// 
			this.btnNewGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGroup.Image")));
			this.btnNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNewGroup.Name = "btnNewGroup";
			this.btnNewGroup.Size = new System.Drawing.Size(104, 41);
			this.btnNewGroup.Tag = "";
			this.btnNewGroup.Text = "&Tạo nhóm SP";
			this.btnNewGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditGroup
			// 
			this.btnEditGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnEditGroup.Image")));
			this.btnEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditGroup.Name = "btnEditGroup";
			this.btnEditGroup.Size = new System.Drawing.Size(105, 41);
			this.btnEditGroup.Tag = "";
			this.btnEditGroup.Text = "Sửa nhóm SP";
			this.btnEditGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDeleteGroup
			// 
			this.btnDeleteGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteGroup.Image")));
			this.btnDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDeleteGroup.Name = "btnDeleteGroup";
			this.btnDeleteGroup.Size = new System.Drawing.Size(105, 41);
			this.btnDeleteGroup.Tag = "";
			this.btnDeleteGroup.Text = "Xóa nhóm SP";
			this.btnDeleteGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(109, 41);
			this.btnAdd.Tag = "";
			this.btnAdd.Text = "Tạo sản phẩm";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(110, 41);
			this.btnEdit.Tag = "";
			this.btnEdit.Text = "Sửa sản phẩm";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
			this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(110, 41);
			this.btnDel.Tag = "";
			this.btnDel.Text = "Xóa sản phẩm";
			this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.AutoSize = false;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSungLuc
			// 
			this.btnSungLuc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSungLuc.Image = ((System.Drawing.Image)(resources.GetObject("btnSungLuc.Image")));
			this.btnSungLuc.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSungLuc.Name = "btnSungLuc";
			this.btnSungLuc.Size = new System.Drawing.Size(77, 41);
			this.btnSungLuc.Tag = "";
			this.btnSungLuc.Text = "Súng Lực";
			this.btnSungLuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(84, 41);
			this.btnExcel.Tag = "";
			this.btnExcel.Text = "Xuất Excel";
			this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.Image")));
			this.btnImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.Size = new System.Drawing.Size(88, 41);
			this.btnImportExcel.Tag = "";
			this.btnImportExcel.Text = "Nhập Excel";
			this.btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// btnUpdateStepCode
			// 
			this.btnUpdateStepCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateStepCode.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStepCode.Image")));
			this.btnUpdateStepCode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUpdateStepCode.Name = "btnUpdateStepCode";
			this.btnUpdateStepCode.Size = new System.Drawing.Size(195, 41);
			this.btnUpdateStepCode.Tag = "";
			this.btnUpdateStepCode.Text = "Cập nhật lại mã công đoạn";
			this.btnUpdateStepCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(0, 55);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnFindAll);
			this.splitContainer1.Panel2.Controls.Add(this.txtName);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.labelControl2);
			this.splitContainer1.Panel2.Controls.Add(this.grdData);
			this.splitContainer1.Size = new System.Drawing.Size(1403, 586);
			this.splitContainer1.SplitterDistance = 345;
			this.splitContainer1.TabIndex = 25;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.treeData);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 580);
			this.panel1.TabIndex = 0;
			// 
			// treeData
			// 
			this.treeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.treeData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.treeData.Location = new System.Drawing.Point(1, 2);
			this.treeData.Margin = new System.Windows.Forms.Padding(4);
			this.treeData.Name = "treeData";
			this.treeData.OptionsBehavior.AllowExpandOnDblClick = false;
			this.treeData.OptionsBehavior.DragNodes = true;
			this.treeData.OptionsBehavior.Editable = false;
			this.treeData.Size = new System.Drawing.Size(337, 579);
			this.treeData.TabIndex = 18;
			// 
			// btnFindAll
			// 
			this.btnFindAll.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindAll.Appearance.Options.UseFont = true;
			this.btnFindAll.Location = new System.Drawing.Point(882, 5);
			this.btnFindAll.Margin = new System.Windows.Forms.Padding(4);
			this.btnFindAll.Name = "btnFindAll";
			this.btnFindAll.Size = new System.Drawing.Size(100, 28);
			this.btnFindAll.TabIndex = 26;
			this.btnFindAll.Text = "Tìm kiếm";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(478, 6);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(385, 27);
			this.txtName.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(406, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "Từ khóa:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Location = new System.Drawing.Point(121, 9);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(166, 20);
			this.labelControl2.TabIndex = 23;
			this.labelControl2.Text = "Danh sách linh kiện";
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.grdData.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdData.Location = new System.Drawing.Point(4, 41);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4);
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(1046, 541);
			this.grdData.TabIndex = 22;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.grvData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.grvData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.Options.UseBackColor = true;
			this.grvData.ColumnPanelRowHeight = 40;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colCode,
            this.colGroup,
            this.colProductTypeCode,
            this.colRatioCode,
            this.colCreatedDate,
            this.colProductDate,
            this.colXuatLucSealCap,
            this.colLoaiMoNapDau,
            this.colLoaiMoBomHopSo,
            this.colLucCheckGear,
            this.colGunNumber,
            this.colJobNumber,
            this.colBuLongNumber,
            this.colShootNumber,
            this.colQtyOcBanGa,
            this.colSetForce,
            this.colMotorCode,
            this.colCoilCode,
            this.colDienAp,
            this.colTanSo,
            this.colDongDien,
            this.colNhapLucWo,
            this.colVongQuay,
            this.colTiengOn,
            this.colDoRungFFT,
            this.colGoal,
            this.colProductGroupCode});
			this.grvData.GridControl = this.grdData;
			this.grvData.HorzScrollStep = 5;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AutoExpandAllGroups = true;
			this.grvData.OptionsCustomization.AllowRowSizing = true;
			this.grvData.OptionsFind.AlwaysVisible = true;
			this.grvData.OptionsFind.ShowCloseButton = false;
			this.grvData.OptionsSelection.MultiSelect = true;
			this.grvData.OptionsView.ColumnAutoWidth = false;
			this.grvData.OptionsView.RowAutoHeight = true;
			this.grvData.OptionsView.ShowAutoFilterRow = true;
			this.grvData.OptionsView.ShowFooter = true;
			this.grvData.OptionsView.ShowGroupPanel = false;
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceHeader.Options.UseTextOptions = true;
			this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colName
			// 
			this.colName.AppearanceCell.Options.UseTextOptions = true;
			this.colName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colName.AppearanceHeader.Options.UseFont = true;
			this.colName.AppearanceHeader.Options.UseTextOptions = true;
			this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colName.Caption = "Tên";
			this.colName.FieldName = "ProductName";
			this.colName.Name = "colName";
			this.colName.OptionsColumn.AllowEdit = false;
			this.colName.OptionsColumn.AllowSize = false;
			this.colName.Visible = true;
			this.colName.VisibleIndex = 1;
			this.colName.Width = 251;
			// 
			// colCode
			// 
			this.colCode.AppearanceCell.Options.UseTextOptions = true;
			this.colCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colCode.AppearanceHeader.Options.UseFont = true;
			this.colCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCode.Caption = "Mã";
			this.colCode.FieldName = "ProductCode";
			this.colCode.Name = "colCode";
			this.colCode.OptionsColumn.AllowEdit = false;
			this.colCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 0;
			this.colCode.Width = 101;
			// 
			// colGroup
			// 
			this.colGroup.AppearanceCell.Options.UseTextOptions = true;
			this.colGroup.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colGroup.AppearanceHeader.Options.UseTextOptions = true;
			this.colGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGroup.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colGroup.Caption = "Nhóm";
			this.colGroup.FieldName = "ProductGroupID";
			this.colGroup.Name = "colGroup";
			this.colGroup.OptionsColumn.AllowEdit = false;
			// 
			// colProductTypeCode
			// 
			this.colProductTypeCode.AppearanceCell.Options.UseTextOptions = true;
			this.colProductTypeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductTypeCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductTypeCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductTypeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductTypeCode.AppearanceHeader.Options.UseFont = true;
			this.colProductTypeCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductTypeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductTypeCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductTypeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductTypeCode.Caption = "LOẠI\nSẢN PHẨM\n";
			this.colProductTypeCode.FieldName = "ProductTypeCode";
			this.colProductTypeCode.Name = "colProductTypeCode";
			this.colProductTypeCode.OptionsColumn.AllowEdit = false;
			this.colProductTypeCode.Visible = true;
			this.colProductTypeCode.VisibleIndex = 3;
			// 
			// colRatioCode
			// 
			this.colRatioCode.AppearanceCell.Options.UseTextOptions = true;
			this.colRatioCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRatioCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRatioCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colRatioCode.AppearanceHeader.Options.UseFont = true;
			this.colRatioCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colRatioCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRatioCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRatioCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRatioCode.Caption = "GIẢM TỐC";
			this.colRatioCode.FieldName = "RatioCode";
			this.colRatioCode.Name = "colRatioCode";
			this.colRatioCode.OptionsColumn.AllowEdit = false;
			this.colRatioCode.Visible = true;
			this.colRatioCode.VisibleIndex = 4;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.AppearanceCell.Options.UseTextOptions = true;
			this.colCreatedDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCreatedDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCreatedDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colCreatedDate.AppearanceHeader.Options.UseFont = true;
			this.colCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCreatedDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCreatedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCreatedDate.Caption = "NGÀY LẬP";
			this.colCreatedDate.FieldName = "CreatedDate";
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.OptionsColumn.AllowEdit = false;
			// 
			// colProductDate
			// 
			this.colProductDate.AppearanceCell.Options.UseTextOptions = true;
			this.colProductDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductDate.AppearanceHeader.Options.UseFont = true;
			this.colProductDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductDate.Caption = "Ngày lập";
			this.colProductDate.FieldName = "ProductDate";
			this.colProductDate.Name = "colProductDate";
			this.colProductDate.OptionsColumn.AllowEdit = false;
			this.colProductDate.Visible = true;
			this.colProductDate.VisibleIndex = 25;
			// 
			// colXuatLucSealCap
			// 
			this.colXuatLucSealCap.AppearanceCell.Options.UseTextOptions = true;
			this.colXuatLucSealCap.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colXuatLucSealCap.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colXuatLucSealCap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colXuatLucSealCap.AppearanceHeader.Options.UseFont = true;
			this.colXuatLucSealCap.AppearanceHeader.Options.UseTextOptions = true;
			this.colXuatLucSealCap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colXuatLucSealCap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colXuatLucSealCap.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colXuatLucSealCap.Caption = "HƯỚNG TRỤC XUẤT LỰC\nSEAL CAP";
			this.colXuatLucSealCap.FieldName = "XuatLucSealCap";
			this.colXuatLucSealCap.Name = "colXuatLucSealCap";
			this.colXuatLucSealCap.OptionsColumn.AllowEdit = false;
			this.colXuatLucSealCap.Visible = true;
			this.colXuatLucSealCap.VisibleIndex = 5;
			// 
			// colLoaiMoNapDau
			// 
			this.colLoaiMoNapDau.AppearanceCell.Options.UseTextOptions = true;
			this.colLoaiMoNapDau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLoaiMoNapDau.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLoaiMoNapDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colLoaiMoNapDau.AppearanceHeader.Options.UseFont = true;
			this.colLoaiMoNapDau.AppearanceHeader.Options.UseTextOptions = true;
			this.colLoaiMoNapDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLoaiMoNapDau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLoaiMoNapDau.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLoaiMoNapDau.Caption = "LOẠI MỠ NẮP DẦU";
			this.colLoaiMoNapDau.FieldName = "LoaiMoNapDau";
			this.colLoaiMoNapDau.Name = "colLoaiMoNapDau";
			this.colLoaiMoNapDau.OptionsColumn.AllowEdit = false;
			this.colLoaiMoNapDau.Visible = true;
			this.colLoaiMoNapDau.VisibleIndex = 6;
			// 
			// colLoaiMoBomHopSo
			// 
			this.colLoaiMoBomHopSo.AppearanceCell.Options.UseTextOptions = true;
			this.colLoaiMoBomHopSo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLoaiMoBomHopSo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLoaiMoBomHopSo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colLoaiMoBomHopSo.AppearanceHeader.Options.UseFont = true;
			this.colLoaiMoBomHopSo.AppearanceHeader.Options.UseTextOptions = true;
			this.colLoaiMoBomHopSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLoaiMoBomHopSo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLoaiMoBomHopSo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLoaiMoBomHopSo.Caption = "LOẠI MỠ BƠM HỘP SỐ";
			this.colLoaiMoBomHopSo.FieldName = "LoaiMoBomHopSo";
			this.colLoaiMoBomHopSo.Name = "colLoaiMoBomHopSo";
			this.colLoaiMoBomHopSo.OptionsColumn.AllowEdit = false;
			this.colLoaiMoBomHopSo.Visible = true;
			this.colLoaiMoBomHopSo.VisibleIndex = 7;
			// 
			// colLucCheckGear
			// 
			this.colLucCheckGear.AppearanceCell.Options.UseTextOptions = true;
			this.colLucCheckGear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLucCheckGear.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLucCheckGear.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLucCheckGear.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colLucCheckGear.AppearanceHeader.Options.UseFont = true;
			this.colLucCheckGear.AppearanceHeader.Options.UseTextOptions = true;
			this.colLucCheckGear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLucCheckGear.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLucCheckGear.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLucCheckGear.Caption = "LỰC CHECK 1\nNẮP - HỘP\n( N.m )";
			this.colLucCheckGear.FieldName = "LucCheckGear";
			this.colLucCheckGear.Name = "colLucCheckGear";
			this.colLucCheckGear.OptionsColumn.AllowEdit = false;
			this.colLucCheckGear.Visible = true;
			this.colLucCheckGear.VisibleIndex = 8;
			// 
			// colGunNumber
			// 
			this.colGunNumber.AppearanceCell.Options.UseTextOptions = true;
			this.colGunNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGunNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colGunNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colGunNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colGunNumber.AppearanceHeader.Options.UseFont = true;
			this.colGunNumber.AppearanceHeader.Options.UseTextOptions = true;
			this.colGunNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGunNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colGunNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colGunNumber.Caption = "SÚNG";
			this.colGunNumber.FieldName = "GunNumber";
			this.colGunNumber.Name = "colGunNumber";
			this.colGunNumber.OptionsColumn.AllowEdit = false;
			this.colGunNumber.Visible = true;
			this.colGunNumber.VisibleIndex = 9;
			// 
			// colJobNumber
			// 
			this.colJobNumber.AppearanceCell.Options.UseTextOptions = true;
			this.colJobNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colJobNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colJobNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colJobNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colJobNumber.AppearanceHeader.Options.UseFont = true;
			this.colJobNumber.AppearanceHeader.Options.UseTextOptions = true;
			this.colJobNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colJobNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colJobNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colJobNumber.Caption = "JOB";
			this.colJobNumber.FieldName = "JobNumber";
			this.colJobNumber.Name = "colJobNumber";
			this.colJobNumber.OptionsColumn.AllowEdit = false;
			this.colJobNumber.Visible = true;
			this.colJobNumber.VisibleIndex = 10;
			// 
			// colBuLongNumber
			// 
			this.colBuLongNumber.AppearanceCell.Options.UseTextOptions = true;
			this.colBuLongNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colBuLongNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colBuLongNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colBuLongNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colBuLongNumber.AppearanceHeader.Options.UseFont = true;
			this.colBuLongNumber.AppearanceHeader.Options.UseTextOptions = true;
			this.colBuLongNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colBuLongNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colBuLongNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colBuLongNumber.Caption = "SỐ LUỢNG BULONG";
			this.colBuLongNumber.FieldName = "BuLongNumber";
			this.colBuLongNumber.Name = "colBuLongNumber";
			this.colBuLongNumber.OptionsColumn.AllowEdit = false;
			this.colBuLongNumber.Visible = true;
			this.colBuLongNumber.VisibleIndex = 11;
			// 
			// colShootNumber
			// 
			this.colShootNumber.AppearanceCell.Options.UseTextOptions = true;
			this.colShootNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShootNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShootNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colShootNumber.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colShootNumber.AppearanceHeader.Options.UseFont = true;
			this.colShootNumber.AppearanceHeader.Options.UseTextOptions = true;
			this.colShootNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShootNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShootNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colShootNumber.Caption = "SỐ LẦN BẮN\r\n";
			this.colShootNumber.FieldName = "ShootNumber";
			this.colShootNumber.Name = "colShootNumber";
			this.colShootNumber.OptionsColumn.AllowEdit = false;
			this.colShootNumber.Visible = true;
			this.colShootNumber.VisibleIndex = 12;
			// 
			// colQtyOcBanGa
			// 
			this.colQtyOcBanGa.AppearanceCell.Options.UseTextOptions = true;
			this.colQtyOcBanGa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyOcBanGa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQtyOcBanGa.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQtyOcBanGa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colQtyOcBanGa.AppearanceHeader.Options.UseFont = true;
			this.colQtyOcBanGa.AppearanceHeader.Options.UseTextOptions = true;
			this.colQtyOcBanGa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyOcBanGa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQtyOcBanGa.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQtyOcBanGa.Caption = "BẮN GÁ\r\n";
			this.colQtyOcBanGa.FieldName = "QtyOcBanGa";
			this.colQtyOcBanGa.Name = "colQtyOcBanGa";
			this.colQtyOcBanGa.OptionsColumn.AllowEdit = false;
			this.colQtyOcBanGa.Visible = true;
			this.colQtyOcBanGa.VisibleIndex = 13;
			// 
			// colSetForce
			// 
			this.colSetForce.AppearanceCell.Options.UseTextOptions = true;
			this.colSetForce.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSetForce.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSetForce.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSetForce.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colSetForce.AppearanceHeader.Options.UseFont = true;
			this.colSetForce.AppearanceHeader.Options.UseTextOptions = true;
			this.colSetForce.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSetForce.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSetForce.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSetForce.Caption = "ĐẶT LỰC\r\n";
			this.colSetForce.FieldName = "SetForce";
			this.colSetForce.Name = "colSetForce";
			this.colSetForce.OptionsColumn.AllowEdit = false;
			this.colSetForce.Visible = true;
			this.colSetForce.VisibleIndex = 14;
			// 
			// colMotorCode
			// 
			this.colMotorCode.AppearanceCell.Options.UseTextOptions = true;
			this.colMotorCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMotorCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMotorCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colMotorCode.AppearanceHeader.Options.UseFont = true;
			this.colMotorCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colMotorCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMotorCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMotorCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMotorCode.Caption = "MÃ MOTOR\r\n";
			this.colMotorCode.FieldName = "MotorCode";
			this.colMotorCode.Name = "colMotorCode";
			this.colMotorCode.OptionsColumn.AllowEdit = false;
			this.colMotorCode.Visible = true;
			this.colMotorCode.VisibleIndex = 15;
			// 
			// colCoilCode
			// 
			this.colCoilCode.AppearanceCell.Options.UseTextOptions = true;
			this.colCoilCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCoilCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCoilCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colCoilCode.AppearanceHeader.Options.UseFont = true;
			this.colCoilCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colCoilCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCoilCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCoilCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCoilCode.Caption = "MÃ COIL\r\n";
			this.colCoilCode.FieldName = "CoilCode";
			this.colCoilCode.Name = "colCoilCode";
			this.colCoilCode.OptionsColumn.AllowEdit = false;
			this.colCoilCode.Visible = true;
			this.colCoilCode.VisibleIndex = 16;
			// 
			// colDienAp
			// 
			this.colDienAp.AppearanceCell.Options.UseTextOptions = true;
			this.colDienAp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDienAp.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDienAp.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDienAp.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colDienAp.AppearanceHeader.Options.UseFont = true;
			this.colDienAp.AppearanceHeader.Options.UseTextOptions = true;
			this.colDienAp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDienAp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDienAp.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDienAp.Caption = "Điện áp (V)\r\n";
			this.colDienAp.FieldName = "DienAp";
			this.colDienAp.Name = "colDienAp";
			this.colDienAp.OptionsColumn.AllowEdit = false;
			this.colDienAp.Visible = true;
			this.colDienAp.VisibleIndex = 17;
			// 
			// colTanSo
			// 
			this.colTanSo.AppearanceCell.Options.UseTextOptions = true;
			this.colTanSo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTanSo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colTanSo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colTanSo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colTanSo.AppearanceHeader.Options.UseFont = true;
			this.colTanSo.AppearanceHeader.Options.UseTextOptions = true;
			this.colTanSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTanSo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colTanSo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colTanSo.Caption = "Tần số (Hz)\r\n";
			this.colTanSo.FieldName = "TanSo";
			this.colTanSo.Name = "colTanSo";
			this.colTanSo.OptionsColumn.AllowEdit = false;
			this.colTanSo.Visible = true;
			this.colTanSo.VisibleIndex = 18;
			// 
			// colDongDien
			// 
			this.colDongDien.AppearanceCell.Options.UseTextOptions = true;
			this.colDongDien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDongDien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDongDien.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDongDien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colDongDien.AppearanceHeader.Options.UseFont = true;
			this.colDongDien.AppearanceHeader.Options.UseTextOptions = true;
			this.colDongDien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDongDien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDongDien.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDongDien.Caption = "Dòng điện Io\r\n";
			this.colDongDien.FieldName = "DongDien";
			this.colDongDien.Name = "colDongDien";
			this.colDongDien.OptionsColumn.AllowEdit = false;
			this.colDongDien.Visible = true;
			this.colDongDien.VisibleIndex = 19;
			// 
			// colNhapLucWo
			// 
			this.colNhapLucWo.AppearanceCell.Options.UseTextOptions = true;
			this.colNhapLucWo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNhapLucWo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNhapLucWo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colNhapLucWo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colNhapLucWo.AppearanceHeader.Options.UseFont = true;
			this.colNhapLucWo.AppearanceHeader.Options.UseTextOptions = true;
			this.colNhapLucWo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNhapLucWo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNhapLucWo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colNhapLucWo.Caption = "Nhập lực Wo\r\n";
			this.colNhapLucWo.FieldName = "NhapLucWo";
			this.colNhapLucWo.Name = "colNhapLucWo";
			this.colNhapLucWo.OptionsColumn.AllowEdit = false;
			this.colNhapLucWo.Visible = true;
			this.colNhapLucWo.VisibleIndex = 20;
			// 
			// colVongQuay
			// 
			this.colVongQuay.AppearanceCell.Options.UseTextOptions = true;
			this.colVongQuay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colVongQuay.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colVongQuay.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colVongQuay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colVongQuay.AppearanceHeader.Options.UseFont = true;
			this.colVongQuay.AppearanceHeader.Options.UseTextOptions = true;
			this.colVongQuay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colVongQuay.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colVongQuay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colVongQuay.Caption = "Vòng quay";
			this.colVongQuay.FieldName = "VongQuay";
			this.colVongQuay.Name = "colVongQuay";
			this.colVongQuay.OptionsColumn.AllowEdit = false;
			this.colVongQuay.Visible = true;
			this.colVongQuay.VisibleIndex = 21;
			// 
			// colTiengOn
			// 
			this.colTiengOn.AppearanceCell.Options.UseTextOptions = true;
			this.colTiengOn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTiengOn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colTiengOn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colTiengOn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colTiengOn.AppearanceHeader.Options.UseFont = true;
			this.colTiengOn.AppearanceHeader.Options.UseTextOptions = true;
			this.colTiengOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTiengOn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colTiengOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colTiengOn.Caption = "Tiếng ồn dB";
			this.colTiengOn.FieldName = "TiengOn";
			this.colTiengOn.Name = "colTiengOn";
			this.colTiengOn.OptionsColumn.AllowEdit = false;
			this.colTiengOn.Visible = true;
			this.colTiengOn.VisibleIndex = 22;
			// 
			// colDoRungFFT
			// 
			this.colDoRungFFT.AppearanceCell.Options.UseTextOptions = true;
			this.colDoRungFFT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDoRungFFT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDoRungFFT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDoRungFFT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colDoRungFFT.AppearanceHeader.Options.UseFont = true;
			this.colDoRungFFT.AppearanceHeader.Options.UseTextOptions = true;
			this.colDoRungFFT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDoRungFFT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDoRungFFT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDoRungFFT.Caption = "Độ rung FFT\r\n";
			this.colDoRungFFT.FieldName = "DoRungFFT";
			this.colDoRungFFT.Name = "colDoRungFFT";
			this.colDoRungFFT.OptionsColumn.AllowEdit = false;
			this.colDoRungFFT.Visible = true;
			this.colDoRungFFT.VisibleIndex = 23;
			// 
			// colGoal
			// 
			this.colGoal.AppearanceCell.Options.UseTextOptions = true;
			this.colGoal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGoal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colGoal.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colGoal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colGoal.AppearanceHeader.Options.UseFont = true;
			this.colGoal.AppearanceHeader.Options.UseTextOptions = true;
			this.colGoal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGoal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colGoal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colGoal.Caption = "ĐÍCH ĐẾN";
			this.colGoal.FieldName = "Goal";
			this.colGoal.Name = "colGoal";
			this.colGoal.OptionsColumn.AllowEdit = false;
			this.colGoal.Visible = true;
			this.colGoal.VisibleIndex = 24;
			// 
			// colProductGroupCode
			// 
			this.colProductGroupCode.AppearanceCell.Options.UseTextOptions = true;
			this.colProductGroupCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductGroupCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductGroupCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductGroupCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductGroupCode.AppearanceHeader.Options.UseFont = true;
			this.colProductGroupCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductGroupCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductGroupCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductGroupCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductGroupCode.Caption = "Nhóm sản phẩm";
			this.colProductGroupCode.FieldName = "ProductGroupCode";
			this.colProductGroupCode.Name = "colProductGroupCode";
			this.colProductGroupCode.OptionsColumn.AllowEdit = false;
			this.colProductGroupCode.OptionsFilter.AllowAutoFilter = false;
			this.colProductGroupCode.Visible = true;
			this.colProductGroupCode.VisibleIndex = 2;
			// 
			// frmMotorPartList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1403, 642);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.mnuMenu);
			this.Name = "frmMotorPartList";
			this.Text = "DANH SÁCH LINH KIỆN MOTOR";
			this.Load += new System.EventHandler(this.frmMotorPartList_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnNewGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton btnEditGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton btnDeleteGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnDel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripButton btnSungLuc;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton btnExcel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnImportExcel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnUpdateStepCode;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraTreeList.TreeList treeData;
		private DevExpress.XtraEditors.SimpleButton btnFindAll;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colCode;
		private DevExpress.XtraGrid.Columns.GridColumn colGroup;
		private DevExpress.XtraGrid.Columns.GridColumn colProductTypeCode;
		private DevExpress.XtraGrid.Columns.GridColumn colRatioCode;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
		private DevExpress.XtraGrid.Columns.GridColumn colProductDate;
		private DevExpress.XtraGrid.Columns.GridColumn colXuatLucSealCap;
		private DevExpress.XtraGrid.Columns.GridColumn colLoaiMoNapDau;
		private DevExpress.XtraGrid.Columns.GridColumn colLoaiMoBomHopSo;
		private DevExpress.XtraGrid.Columns.GridColumn colLucCheckGear;
		private DevExpress.XtraGrid.Columns.GridColumn colGunNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colJobNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colBuLongNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colShootNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colQtyOcBanGa;
		private DevExpress.XtraGrid.Columns.GridColumn colSetForce;
		private DevExpress.XtraGrid.Columns.GridColumn colMotorCode;
		private DevExpress.XtraGrid.Columns.GridColumn colCoilCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDienAp;
		private DevExpress.XtraGrid.Columns.GridColumn colTanSo;
		private DevExpress.XtraGrid.Columns.GridColumn colDongDien;
		private DevExpress.XtraGrid.Columns.GridColumn colNhapLucWo;
		private DevExpress.XtraGrid.Columns.GridColumn colVongQuay;
		private DevExpress.XtraGrid.Columns.GridColumn colTiengOn;
		private DevExpress.XtraGrid.Columns.GridColumn colDoRungFFT;
		private DevExpress.XtraGrid.Columns.GridColumn colGoal;
		private DevExpress.XtraGrid.Columns.GridColumn colProductGroupCode;
	}
}