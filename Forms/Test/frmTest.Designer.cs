
namespace BMS
{
	partial class frmTest
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
			this.cbOptions = new System.Windows.Forms.ComboBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbOptions
			// 
			this.cbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbOptions.FormattingEnabled = true;
			this.cbOptions.Items.AddRange(new object[] {
            "Kho sơn",
            "Kho motor"});
			this.cbOptions.Location = new System.Drawing.Point(12, 12);
			this.cbOptions.Name = "cbOptions";
			this.cbOptions.Size = new System.Drawing.Size(776, 33);
			this.cbOptions.TabIndex = 0;
			// 
			// btnRun
			// 
			this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRun.Location = new System.Drawing.Point(346, 106);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(108, 34);
			this.btnRun.TabIndex = 1;
			this.btnRun.Text = "Chạy";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// frmTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 198);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.cbOptions);
			this.Name = "frmTest";
			this.Text = "frmTest";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTest_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbOptions;
		private System.Windows.Forms.Button btnRun;
	}
}