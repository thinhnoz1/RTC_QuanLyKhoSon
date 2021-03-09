﻿
namespace BMS

{
    partial class frmAddEditProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditProduct));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnSaveClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveNew = new System.Windows.Forms.ToolStripButton();
			this.txtAsQuantity = new System.Windows.Forms.NumericUpDown();
			this.txtExQuantity = new System.Windows.Forms.NumericUpDown();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtPartName = new System.Windows.Forms.TextBox();
			this.txtPartCode = new System.Windows.Forms.TextBox();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.txtPartDescription = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.mnuMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAsQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExQuantity)).BeginInit();
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
            this.btnSaveClose,
            this.toolStripSeparator2,
            this.btnSaveNew});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(977, 50);
			this.mnuMenu.TabIndex = 1;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
			this.btnSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(93, 41);
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
			this.btnSaveNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveNew.Image")));
			this.btnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new System.Drawing.Size(123, 41);
			this.btnSaveNew.Tag = "frmProduct_AddProductH";
			this.btnSaveNew.Text = "Cất && Thêm mới";
			this.btnSaveNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
			// 
			// txtAsQuantity
			// 
			this.txtAsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAsQuantity.Location = new System.Drawing.Point(341, 302);
			this.txtAsQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAsQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txtAsQuantity.Name = "txtAsQuantity";
			this.txtAsQuantity.Size = new System.Drawing.Size(243, 41);
			this.txtAsQuantity.TabIndex = 189;
			// 
			// txtExQuantity
			// 
			this.txtExQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExQuantity.Location = new System.Drawing.Point(341, 250);
			this.txtExQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtExQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.txtExQuantity.Name = "txtExQuantity";
			this.txtExQuantity.Size = new System.Drawing.Size(243, 41);
			this.txtExQuantity.TabIndex = 188;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Location = new System.Drawing.Point(39, 255);
			this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(265, 36);
			this.labelControl7.TabIndex = 187;
			this.labelControl7.Text = "Số lượng xuất khẩu:";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Location = new System.Drawing.Point(39, 306);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(227, 36);
			this.labelControl6.TabIndex = 186;
			this.labelControl6.Text = "Số lượng lắp ráp:";
			// 
			// txtPartName
			// 
			this.txtPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPartName.Location = new System.Drawing.Point(341, 69);
			this.txtPartName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPartName.Name = "txtPartName";
			this.txtPartName.Size = new System.Drawing.Size(607, 41);
			this.txtPartName.TabIndex = 180;
			// 
			// txtPartCode
			// 
			this.txtPartCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPartCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPartCode.Location = new System.Drawing.Point(341, 117);
			this.txtPartCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPartCode.Name = "txtPartCode";
			this.txtPartCode.Size = new System.Drawing.Size(607, 41);
			this.txtPartCode.TabIndex = 181;
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl9.Location = new System.Drawing.Point(39, 122);
			this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(168, 36);
			this.labelControl9.TabIndex = 185;
			this.labelControl9.Text = "Mã linh kiện:";
			// 
			// txtPartDescription
			// 
			this.txtPartDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPartDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPartDescription.Location = new System.Drawing.Point(341, 162);
			this.txtPartDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPartDescription.Multiline = true;
			this.txtPartDescription.Name = "txtPartDescription";
			this.txtPartDescription.Size = new System.Drawing.Size(607, 75);
			this.txtPartDescription.TabIndex = 182;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Location = new System.Drawing.Point(39, 178);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(82, 36);
			this.labelControl4.TabIndex = 184;
			this.labelControl4.Text = "Mô tả:";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Location = new System.Drawing.Point(39, 75);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(186, 36);
			this.labelControl3.TabIndex = 183;
			this.labelControl3.Text = "Tên linh kiện: ";
			// 
			// frmAddEditProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(977, 393);
			this.Controls.Add(this.txtAsQuantity);
			this.Controls.Add(this.txtExQuantity);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.txtPartName);
			this.Controls.Add(this.txtPartCode);
			this.Controls.Add(this.labelControl9);
			this.Controls.Add(this.txtPartDescription);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.mnuMenu);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmAddEditProduct";
			this.Text = "frmAddEdit";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditProduct_FormClosing);
			this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAsQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSaveNew;
        private System.Windows.Forms.ToolStripButton btnSaveClose;
		private System.Windows.Forms.NumericUpDown txtAsQuantity;
		private System.Windows.Forms.NumericUpDown txtExQuantity;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private System.Windows.Forms.TextBox txtPartName;
		private System.Windows.Forms.TextBox txtPartCode;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private System.Windows.Forms.TextBox txtPartDescription;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
	}
}