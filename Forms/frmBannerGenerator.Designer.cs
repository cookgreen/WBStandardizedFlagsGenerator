namespace WBBannerConverter
{
	partial class frmBannerGenerator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBannerGenerator));
			this.listBannerImages = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.rbGenerateStandardVerticalBanner = new System.Windows.Forms.RadioButton();
			this.rbGenerateWBDefaultBanner = new System.Windows.Forms.RadioButton();
			this.rbGenerateStandardHorizontalBanner = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBannerImages
			// 
			this.listBannerImages.FormattingEnabled = true;
			this.listBannerImages.ItemHeight = 20;
			this.listBannerImages.Location = new System.Drawing.Point(12, 12);
			this.listBannerImages.Name = "listBannerImages";
			this.listBannerImages.Size = new System.Drawing.Size(565, 424);
			this.listBannerImages.TabIndex = 0;
			this.listBannerImages.SelectedIndexChanged += new System.EventHandler(this.listBannerImages_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(593, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(187, 68);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(593, 100);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(187, 68);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(593, 481);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(187, 89);
			this.btnGenerate.TabIndex = 4;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.rbGenerateStandardVerticalBanner);
			this.groupBox1.Controls.Add(this.rbGenerateWBDefaultBanner);
			this.groupBox1.Controls.Add(this.rbGenerateStandardHorizontalBanner);
			this.groupBox1.Location = new System.Drawing.Point(14, 445);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(563, 125);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(267, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(137, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Flip 90 Degree";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// rbGenerateStandardVerticalBanner
			// 
			this.rbGenerateStandardVerticalBanner.AutoSize = true;
			this.rbGenerateStandardVerticalBanner.Location = new System.Drawing.Point(16, 60);
			this.rbGenerateStandardVerticalBanner.Name = "rbGenerateStandardVerticalBanner";
			this.rbGenerateStandardVerticalBanner.Size = new System.Drawing.Size(209, 24);
			this.rbGenerateStandardVerticalBanner.TabIndex = 2;
			this.rbGenerateStandardVerticalBanner.Text = "Standard Vertical Banner";
			this.rbGenerateStandardVerticalBanner.UseVisualStyleBackColor = true;
			// 
			// rbGenerateWBDefaultBanner
			// 
			this.rbGenerateWBDefaultBanner.AutoSize = true;
			this.rbGenerateWBDefaultBanner.Location = new System.Drawing.Point(16, 96);
			this.rbGenerateWBDefaultBanner.Name = "rbGenerateWBDefaultBanner";
			this.rbGenerateWBDefaultBanner.Size = new System.Drawing.Size(164, 24);
			this.rbGenerateWBDefaultBanner.TabIndex = 1;
			this.rbGenerateWBDefaultBanner.Text = "WB Default Banner";
			this.rbGenerateWBDefaultBanner.UseVisualStyleBackColor = true;
			// 
			// rbGenerateStandardHorizontalBanner
			// 
			this.rbGenerateStandardHorizontalBanner.AutoSize = true;
			this.rbGenerateStandardHorizontalBanner.Checked = true;
			this.rbGenerateStandardHorizontalBanner.Location = new System.Drawing.Point(16, 24);
			this.rbGenerateStandardHorizontalBanner.Name = "rbGenerateStandardHorizontalBanner";
			this.rbGenerateStandardHorizontalBanner.Size = new System.Drawing.Size(230, 24);
			this.rbGenerateStandardHorizontalBanner.TabIndex = 0;
			this.rbGenerateStandardHorizontalBanner.TabStop = true;
			this.rbGenerateStandardHorizontalBanner.Text = "Standard Horizontal Banner";
			this.rbGenerateStandardHorizontalBanner.UseVisualStyleBackColor = true;
			// 
			// frmBannerGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 595);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.listBannerImages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBannerGenerator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WB Banner Generator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBannerImages;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbGenerateStandardVerticalBanner;
		private System.Windows.Forms.RadioButton rbGenerateWBDefaultBanner;
		private System.Windows.Forms.RadioButton rbGenerateStandardHorizontalBanner;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}