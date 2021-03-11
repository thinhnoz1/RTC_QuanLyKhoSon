
namespace BMS
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.trdStorageList = new DevExpress.XtraTreeList.TreeList();
			this.tlID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.tlStorageCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.tlStorageName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.dtgvMotorList = new DevExpress.XtraGrid.GridControl();
			this.gvMotor = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnFindAll = new DevExpress.XtraEditors.SimpleButton();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.tlStorageCode2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.btnCreatePart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportEx = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.btnHistory = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSonPlan = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDeleteStore = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCreateStore = new System.Windows.Forms.ToolStripButton();
			this.btnEditStore = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trdStorageList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMotor)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Location = new System.Drawing.Point(0, 55);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Salmon;
			this.splitContainer1.Panel2.Controls.Add(this.dtgvMotorList);
			this.splitContainer1.Panel2.Controls.Add(this.btnFindAll);
			this.splitContainer1.Panel2.Controls.Add(this.txtName);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.labelControl2);
			this.splitContainer1.Size = new System.Drawing.Size(1400, 587);
			this.splitContainer1.SplitterDistance = 275;
			this.splitContainer1.TabIndex = 25;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.trdStorageList);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 579);
			this.panel1.TabIndex = 0;
			// 
			// trdStorageList
			// 
			this.trdStorageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trdStorageList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.trdStorageList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.trdStorageList.Appearance.FocusedRow.Options.UseBackColor = true;
			this.trdStorageList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.trdStorageList.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.trdStorageList.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.trdStorageList.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trdStorageList.Appearance.Row.Options.UseFont = true;
			this.trdStorageList.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trdStorageList.AppearancePrint.HeaderPanel.Options.UseFont = true;
			this.trdStorageList.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trdStorageList.AppearancePrint.Row.Options.UseFont = true;
			this.trdStorageList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlID,
            this.tlStorageCode,
            this.tlStorageName});
			this.trdStorageList.Location = new System.Drawing.Point(1, 54);
			this.trdStorageList.Margin = new System.Windows.Forms.Padding(4);
			this.trdStorageList.Name = "trdStorageList";
			this.trdStorageList.OptionsBehavior.AllowExpandOnDblClick = false;
			this.trdStorageList.OptionsBehavior.Editable = false;
			this.trdStorageList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2});
			this.trdStorageList.Size = new System.Drawing.Size(268, 524);
			this.trdStorageList.TabIndex = 25;
			this.trdStorageList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.trdStorageList_FocusedNodeChanged);
			// 
			// tlID
			// 
			this.tlID.Caption = "Mã nhóm";
			this.tlID.FieldName = "id";
			this.tlID.Name = "tlID";
			// 
			// tlStorageCode
			// 
			this.tlStorageCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tlStorageCode.AppearanceHeader.Options.UseFont = true;
			this.tlStorageCode.AppearanceHeader.Options.UseTextOptions = true;
			this.tlStorageCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.tlStorageCode.Caption = "Mã kho";
			this.tlStorageCode.ColumnEdit = this.repositoryItemMemoEdit2;
			this.tlStorageCode.FieldName = "StorageCode";
			this.tlStorageCode.Name = "tlStorageCode";
			this.tlStorageCode.OptionsColumn.AllowEdit = false;
			this.tlStorageCode.OptionsColumn.AllowFocus = false;
			this.tlStorageCode.Visible = true;
			this.tlStorageCode.VisibleIndex = 0;
			this.tlStorageCode.Width = 299;
			// 
			// repositoryItemMemoEdit2
			// 
			this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
			// 
			// tlStorageName
			// 
			this.tlStorageName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tlStorageName.AppearanceHeader.Options.UseFont = true;
			this.tlStorageName.AppearanceHeader.Options.UseTextOptions = true;
			this.tlStorageName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.tlStorageName.Caption = "Tên kho";
			this.tlStorageName.FieldName = "StorageName";
			this.tlStorageName.Name = "tlStorageName";
			this.tlStorageName.OptionsColumn.AllowEdit = false;
			this.tlStorageName.OptionsColumn.AllowFocus = false;
			this.tlStorageName.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			this.tlStorageName.Visible = true;
			this.tlStorageName.VisibleIndex = 1;
			this.tlStorageName.Width = 386;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LightYellow;
			this.labelControl1.Location = new System.Drawing.Point(61, 15);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(144, 25);
			this.labelControl1.TabIndex = 24;
			this.labelControl1.Text = "Danh sách kho";
			// 
			// dtgvMotorList
			// 
			this.dtgvMotorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvMotorList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMotorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvMotorList.Location = new System.Drawing.Point(4, 57);
			this.dtgvMotorList.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
			this.dtgvMotorList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
			this.dtgvMotorList.LookAndFeel.UseDefaultLookAndFeel = false;
			this.dtgvMotorList.MainView = this.gvMotor;
			this.dtgvMotorList.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMotorList.Name = "dtgvMotorList";
			this.dtgvMotorList.Size = new System.Drawing.Size(1111, 524);
			this.dtgvMotorList.TabIndex = 29;
			this.dtgvMotorList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMotor});
			// 
			// gvMotor
			// 
			this.gvMotor.ColumnPanelRowHeight = 40;
			this.gvMotor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPartCode,
            this.colDescription,
            this.colQuantity,
            this.colSTT});
			this.gvMotor.GridControl = this.dtgvMotorList;
			this.gvMotor.Name = "gvMotor";
			this.gvMotor.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotor.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotor.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotor.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvMotor.OptionsBehavior.Editable = false;
			this.gvMotor.OptionsFind.AlwaysVisible = true;
			this.gvMotor.OptionsFind.ShowCloseButton = false;
			this.gvMotor.OptionsView.ShowGroupPanel = false;
			this.gvMotor.PaintStyleName = "Web";
			this.gvMotor.RowHeight = 25;
			this.gvMotor.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "id";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colPartCode
			// 
			this.colPartCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPartCode.AppearanceCell.Options.UseFont = true;
			this.colPartCode.AppearanceCell.Options.UseTextOptions = true;
			this.colPartCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartCode.AppearanceHeader.BackColor = System.Drawing.Color.MediumPurple;
			this.colPartCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPartCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colPartCode.AppearanceHeader.Options.UseBackColor = true;
			this.colPartCode.AppearanceHeader.Options.UseFont = true;
			this.colPartCode.AppearanceHeader.Options.UseForeColor = true;
			this.colPartCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colPartCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartCode.Caption = "Mã linh kiện";
			this.colPartCode.FieldName = "PartCode";
			this.colPartCode.Name = "colPartCode";
			this.colPartCode.OptionsColumn.AllowEdit = false;
			this.colPartCode.Visible = true;
			this.colPartCode.VisibleIndex = 1;
			this.colPartCode.Width = 258;
			// 
			// colDescription
			// 
			this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDescription.AppearanceCell.Options.UseFont = true;
			this.colDescription.AppearanceCell.Options.UseTextOptions = true;
			this.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.AppearanceHeader.BackColor = System.Drawing.Color.MediumPurple;
			this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDescription.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colDescription.AppearanceHeader.Options.UseBackColor = true;
			this.colDescription.AppearanceHeader.Options.UseFont = true;
			this.colDescription.AppearanceHeader.Options.UseForeColor = true;
			this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
			this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescription.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.Caption = "Mô tả";
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.OptionsColumn.AllowEdit = false;
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			this.colDescription.Width = 245;
			// 
			// colQuantity
			// 
			this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantity.AppearanceCell.Options.UseFont = true;
			this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantity.AppearanceHeader.BackColor = System.Drawing.Color.MediumPurple;
			this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
			this.colQuantity.AppearanceHeader.Options.UseFont = true;
			this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
			this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantity.Caption = "Số lượng";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.OptionsColumn.AllowEdit = false;
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 3;
			this.colQuantity.Width = 120;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colSTT.AppearanceCell.Options.UseFont = true;
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.BackColor = System.Drawing.Color.MediumPurple;
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colSTT.AppearanceHeader.Options.UseBackColor = true;
			this.colSTT.AppearanceHeader.Options.UseFont = true;
			this.colSTT.AppearanceHeader.Options.UseForeColor = true;
			this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.Caption = "STT";
			this.colSTT.FieldName = "STT";
			this.colSTT.Name = "colSTT";
			this.colSTT.Visible = true;
			this.colSTT.VisibleIndex = 0;
			this.colSTT.Width = 74;
			// 
			// btnFindAll
			// 
			this.btnFindAll.Appearance.BackColor = System.Drawing.Color.LightPink;
			this.btnFindAll.Appearance.BackColor2 = System.Drawing.Color.LightPink;
			this.btnFindAll.Appearance.BorderColor = System.Drawing.Color.LightPink;
			this.btnFindAll.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindAll.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnFindAll.Appearance.Options.UseBackColor = true;
			this.btnFindAll.Appearance.Options.UseBorderColor = true;
			this.btnFindAll.Appearance.Options.UseFont = true;
			this.btnFindAll.Appearance.Options.UseForeColor = true;
			this.btnFindAll.Location = new System.Drawing.Point(928, 12);
			this.btnFindAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
			this.btnFindAll.LookAndFeel.UseDefaultLookAndFeel = false;
			this.btnFindAll.Margin = new System.Windows.Forms.Padding(4);
			this.btnFindAll.Name = "btnFindAll";
			this.btnFindAll.Size = new System.Drawing.Size(119, 30);
			this.btnFindAll.TabIndex = 26;
			this.btnFindAll.Text = "Tìm kiếm";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(524, 12);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(385, 30);
			this.txtName.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LightYellow;
			this.label2.Location = new System.Drawing.Point(418, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 25);
			this.label2.TabIndex = 24;
			this.label2.Text = "Từ khóa";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.LightYellow;
			this.labelControl2.Location = new System.Drawing.Point(121, 15);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(189, 25);
			this.labelControl2.TabIndex = 23;
			this.labelControl2.Text = "Danh sách linh kiện";
			// 
			// tlStorageCode2
			// 
			this.tlStorageCode2.AppearanceHeader.BackColor = System.Drawing.Color.MediumPurple;
			this.tlStorageCode2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.tlStorageCode2.AppearanceHeader.Options.UseBackColor = true;
			this.tlStorageCode2.AppearanceHeader.Options.UseFont = true;
			this.tlStorageCode2.AppearanceHeader.Options.UseTextOptions = true;
			this.tlStorageCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.tlStorageCode2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.tlStorageCode2.Caption = "Mã kho";
			this.tlStorageCode2.FieldName = "StorageCode";
			this.tlStorageCode2.Name = "tlStorageCode2";
			this.tlStorageCode2.Visible = true;
			this.tlStorageCode2.VisibleIndex = 1;
			this.tlStorageCode2.Width = 366;
			// 
			// btnCreatePart
			// 
			this.btnCreatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreatePart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCreatePart.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatePart.Image")));
			this.btnCreatePart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreatePart.Name = "btnCreatePart";
			this.btnCreatePart.Size = new System.Drawing.Size(120, 44);
			this.btnCreatePart.Tag = "frmProduct_AddProductH";
			this.btnCreatePart.Text = "Tạo linh kiện";
			this.btnCreatePart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditPart
			// 
			this.btnEditPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditPart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditPart.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPart.Image")));
			this.btnEditPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditPart.Name = "btnEditPart";
			this.btnEditPart.Size = new System.Drawing.Size(121, 44);
			this.btnEditPart.Tag = "frmProduct_EditProductH";
			this.btnEditPart.Text = "Sửa linh kiện";
			this.btnEditPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelPart
			// 
			this.btnDelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelPart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelPart.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPart.Image")));
			this.btnDelPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelPart.Name = "btnDelPart";
			this.btnDelPart.Size = new System.Drawing.Size(121, 44);
			this.btnDelPart.Tag = "frmProduct_DeleteProductH";
			this.btnDelPart.Text = "Xóa linh kiện";
			this.btnDelPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.AutoSize = false;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 40);
			// 
			// btnImportPart
			// 
			this.btnImportPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportPart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnImportPart.Image = ((System.Drawing.Image)(resources.GetObject("btnImportPart.Image")));
			this.btnImportPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportPart.Name = "btnImportPart";
			this.btnImportPart.Size = new System.Drawing.Size(91, 44);
			this.btnImportPart.Tag = "frmProduct_GunH";
			this.btnImportPart.Text = "Nhập kho";
			this.btnImportPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator13
			// 
			this.toolStripSeparator13.AutoSize = false;
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new System.Drawing.Size(6, 40);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
			this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(103, 44);
			this.btnExportExcel.Tag = "";
			this.btnExportExcel.Text = "Xuất Excel";
			this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
			// 
			// btnImportEx
			// 
			this.btnImportEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportEx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnImportEx.Image = ((System.Drawing.Image)(resources.GetObject("btnImportEx.Image")));
			this.btnImportEx.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportEx.Name = "btnImportEx";
			this.btnImportEx.Size = new System.Drawing.Size(108, 44);
			this.btnImportEx.Tag = "";
			this.btnImportEx.Text = "Nhập Excel";
			this.btnImportEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.AutoSize = false;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(6, 40);
			// 
			// btnHistory
			// 
			this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
			this.btnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(112, 44);
			this.btnHistory.Tag = "frmProduct_UpdateCDH";
			this.btnHistory.Text = "Xem lịch sử";
			this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.AutoSize = false;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSonPlan
			// 
			this.btnSonPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSonPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSonPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnSonPlan.Image")));
			this.btnSonPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSonPlan.Name = "btnSonPlan";
			this.btnSonPlan.Size = new System.Drawing.Size(131, 44);
			this.btnSonPlan.Tag = "frmProduct_UpdateCDH";
			this.btnSonPlan.Text = "Xem kế hoạch";
			this.btnSonPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreatePart,
            this.toolStripSeparator1,
            this.btnEditPart,
            this.toolStripSeparator7,
            this.btnDelPart,
            this.toolStripSeparator8,
            this.btnImportPart,
            this.toolStripSeparator13,
            this.btnCreateStore,
            this.toolStripSeparator4,
            this.btnDeleteStore,
            this.toolStripSeparator3,
            this.btnEditStore,
            this.toolStripSeparator5,
            this.btnExportExcel,
            this.toolStripSeparator11,
            this.btnImportEx,
            this.toolStripSeparator12,
            this.btnHistory,
            this.toolStripSeparator9,
            this.btnSonPlan,
            this.toolStripSeparator2});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1403, 57);
			this.toolStrip1.TabIndex = 27;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnDeleteStore
			// 
			this.btnDeleteStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDeleteStore.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStore.Image")));
			this.btnDeleteStore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDeleteStore.Name = "btnDeleteStore";
			this.btnDeleteStore.Size = new System.Drawing.Size(80, 44);
			this.btnDeleteStore.Tag = "frmProduct_DeleteProductH";
			this.btnDeleteStore.Text = "Xóa kho";
			this.btnDeleteStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
			// 
			// btnCreateStore
			// 
			this.btnCreateStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCreateStore.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateStore.Image")));
			this.btnCreateStore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreateStore.Name = "btnCreateStore";
			this.btnCreateStore.Size = new System.Drawing.Size(79, 44);
			this.btnCreateStore.Tag = "frmProduct_AddProductH";
			this.btnCreateStore.Text = "Tạo kho";
			this.btnCreateStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnEditStore
			// 
			this.btnEditStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditStore.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStore.Image")));
			this.btnEditStore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditStore.Name = "btnEditStore";
			this.btnEditStore.Size = new System.Drawing.Size(80, 44);
			this.btnEditStore.Tag = "frmProduct_EditProductH";
			this.btnEditStore.Text = "Sửa kho";
			this.btnEditStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AutoSize = false;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
			// 
			// frmMotorPartList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(1403, 642);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmMotorPartList";
			this.Text = "DANH SÁCH LINH KIỆN MOTOR";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMotorPartList_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trdStorageList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMotor)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.SimpleButton btnFindAll;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraGrid.GridControl dtgvMotorList;
		private DevExpress.XtraGrid.Views.Grid.GridView gvMotor;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraTreeList.TreeList trdStorageList;
		private DevExpress.XtraTreeList.Columns.TreeListColumn tlID;
		private DevExpress.XtraTreeList.Columns.TreeListColumn tlStorageCode;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
		private DevExpress.XtraTreeList.Columns.TreeListColumn tlStorageName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn tlStorageCode2;
		private System.Windows.Forms.ToolStripButton btnCreatePart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnEditPart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton btnDelPart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton btnImportPart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.ToolStripButton btnExportExcel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripButton btnImportEx;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripButton btnHistory;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton btnSonPlan;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnCreateStore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnDeleteStore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnEditStore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
	}
}