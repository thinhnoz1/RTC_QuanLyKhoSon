﻿
namespace BMS
{
	partial class frmMotorImExPart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotorImExPart));
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txbWorkerCode = new System.Windows.Forms.TextBox();
			this.txbQuantity = new System.Windows.Forms.NumericUpDown();
			this.txbPartCode = new System.Windows.Forms.TextBox();
			this.cbPosition = new DevExpress.XtraEditors.LookUpEdit();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnSaveClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveNew = new System.Windows.Forms.ToolStripButton();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txbQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbPosition.Properties)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.mnuMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.tableLayoutPanel2);
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Location = new System.Drawing.Point(0, 54);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(889, 273);
			this.panel2.TabIndex = 222;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.txbWorkerCode, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.txbQuantity, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txbPartCode, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbPosition, 0, 2);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(375, -2);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 260);
			this.tableLayoutPanel2.TabIndex = 220;
			// 
			// txbWorkerCode
			// 
			this.txbWorkerCode.BackColor = System.Drawing.SystemColors.Window;
			this.txbWorkerCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txbWorkerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbWorkerCode.Location = new System.Drawing.Point(7, 199);
			this.txbWorkerCode.Margin = new System.Windows.Forms.Padding(4);
			this.txbWorkerCode.Name = "txbWorkerCode";
			this.txbWorkerCode.Size = new System.Drawing.Size(496, 53);
			this.txbWorkerCode.TabIndex = 220;
			this.txbWorkerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txbQuantity
			// 
			this.txbQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbQuantity.Location = new System.Drawing.Point(7, 71);
			this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
			this.txbQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txbQuantity.Name = "txbQuantity";
			this.txbQuantity.Size = new System.Drawing.Size(496, 53);
			this.txbQuantity.TabIndex = 218;
			this.txbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txbPartCode
			// 
			this.txbPartCode.BackColor = System.Drawing.SystemColors.Window;
			this.txbPartCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txbPartCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPartCode.Location = new System.Drawing.Point(7, 7);
			this.txbPartCode.Margin = new System.Windows.Forms.Padding(4);
			this.txbPartCode.Name = "txbPartCode";
			this.txbPartCode.Size = new System.Drawing.Size(496, 53);
			this.txbPartCode.TabIndex = 217;
			this.txbPartCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbPosition
			// 
			this.cbPosition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbPosition.Location = new System.Drawing.Point(6, 134);
			this.cbPosition.Name = "cbPosition";
			this.cbPosition.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
			this.cbPosition.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.cbPosition.Properties.Appearance.Options.UseFont = true;
			this.cbPosition.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPosition.Properties.AppearanceDropDown.Options.UseFont = true;
			this.cbPosition.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPosition.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.cbPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbPosition.Properties.NullText = "";
			this.cbPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cbPosition.Size = new System.Drawing.Size(498, 52);
			this.cbPosition.TabIndex = 219;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -2);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 260);
			this.tableLayoutPanel1.TabIndex = 219;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(7, 195);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 58);
			this.label1.TabIndex = 223;
			this.label1.Text = "Nhân viên";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(7, 131);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(359, 58);
			this.label5.TabIndex = 221;
			this.label5.Text = "Vị trí";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(7, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(361, 58);
			this.label2.TabIndex = 218;
			this.label2.Text = "Mã linh kiện";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Location = new System.Drawing.Point(7, 67);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(361, 58);
			this.label6.TabIndex = 222;
			this.label6.Text = "Số lượng";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.SystemColors.Control;
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveClose,
            this.toolStripSeparator2,
            this.btnSaveNew});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(889, 50);
			this.mnuMenu.TabIndex = 223;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSaveClose.ForeColor = System.Drawing.Color.Black;
			this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
			this.btnSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(109, 44);
			this.btnSaveClose.Tag = "frmProduct_AddProductH";
			this.btnSaveClose.Text = "Cất && Đóng";
			this.btnSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSaveNew
			// 
			this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSaveNew.ForeColor = System.Drawing.Color.Black;
			this.btnSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveNew.Image")));
			this.btnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new System.Drawing.Size(148, 44);
			this.btnSaveNew.Tag = "frmProduct_AddProductH";
			this.btnSaveNew.Text = "Cất && Thêm mới";
			this.btnSaveNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
			// 
			// frmMotorImExPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 337);
			this.Controls.Add(this.mnuMenu);
			this.Controls.Add(this.panel2);
			this.Name = "frmMotorImExPart";
			this.Text = "NHẬP/XUẤT";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMotorImExPart_FormClosing);
			this.Load += new System.EventHandler(this.frmMotorImExPart_Load);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txbQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbPosition.Properties)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.NumericUpDown txbQuantity;
		private System.Windows.Forms.TextBox txbPartCode;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnSaveClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnSaveNew;
		private DevExpress.XtraEditors.LookUpEdit cbPosition;
		private System.Windows.Forms.TextBox txbWorkerCode;
		private System.Windows.Forms.Label label1;
	}
}