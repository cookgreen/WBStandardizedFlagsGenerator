
namespace WBBannerConverter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.label1 = new System.Windows.Forms.Label();
			this.txtBannerInput = new System.Windows.Forms.TextBox();
			this.btnBrowseDDS = new System.Windows.Forms.Button();
			this.btnSaveDDS = new System.Windows.Forms.Button();
			this.txtBannerOutput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnChangeMode = new System.Windows.Forms.Button();
			this.buttonImageList = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbBannerMode = new System.Windows.Forms.ComboBox();
			this.lbBannerMode = new System.Windows.Forms.Label();
			this.chkStandardized = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Banner Image File:";
			// 
			// txtBannerInput
			// 
			this.txtBannerInput.Location = new System.Drawing.Point(174, 167);
			this.txtBannerInput.Name = "txtBannerInput";
			this.txtBannerInput.ReadOnly = true;
			this.txtBannerInput.Size = new System.Drawing.Size(463, 27);
			this.txtBannerInput.TabIndex = 1;
			// 
			// btnBrowseDDS
			// 
			this.btnBrowseDDS.Location = new System.Drawing.Point(653, 160);
			this.btnBrowseDDS.Name = "btnBrowseDDS";
			this.btnBrowseDDS.Size = new System.Drawing.Size(67, 41);
			this.btnBrowseDDS.TabIndex = 2;
			this.btnBrowseDDS.Text = "...";
			this.btnBrowseDDS.UseVisualStyleBackColor = true;
			this.btnBrowseDDS.Click += new System.EventHandler(this.btnBrowseDDS_Click);
			// 
			// btnSaveDDS
			// 
			this.btnSaveDDS.Location = new System.Drawing.Point(653, 213);
			this.btnSaveDDS.Name = "btnSaveDDS";
			this.btnSaveDDS.Size = new System.Drawing.Size(67, 39);
			this.btnSaveDDS.TabIndex = 5;
			this.btnSaveDDS.Text = "...";
			this.btnSaveDDS.UseVisualStyleBackColor = true;
			this.btnSaveDDS.Click += new System.EventHandler(this.btnSaveDDS_Click);
			// 
			// txtBannerOutput
			// 
			this.txtBannerOutput.Location = new System.Drawing.Point(176, 219);
			this.txtBannerOutput.Name = "txtBannerOutput";
			this.txtBannerOutput.ReadOnly = true;
			this.txtBannerOutput.Size = new System.Drawing.Size(463, 27);
			this.txtBannerOutput.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 222);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Output Image File:";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(582, 276);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(138, 68);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnChangeMode
			// 
			this.btnChangeMode.ImageIndex = 1;
			this.btnChangeMode.ImageList = this.buttonImageList;
			this.btnChangeMode.Location = new System.Drawing.Point(314, 12);
			this.btnChangeMode.Name = "btnChangeMode";
			this.btnChangeMode.Size = new System.Drawing.Size(130, 130);
			this.btnChangeMode.TabIndex = 7;
			this.btnChangeMode.UseVisualStyleBackColor = true;
			this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
			// 
			// buttonImageList
			// 
			this.buttonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.buttonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImageList.ImageStream")));
			this.buttonImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.buttonImageList.Images.SetKeyName(0, "arrow-left.png");
			this.buttonImageList.Images.SetKeyName(1, "arrow-right.png");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(84, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(130, 130);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(546, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(130, 130);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// cmbBannerMode
			// 
			this.cmbBannerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBannerMode.Enabled = false;
			this.cmbBannerMode.FormattingEnabled = true;
			this.cmbBannerMode.Items.AddRange(new object[] {
            "banners_a",
            "banners_b",
            "banners_c",
            "banners_d",
            "banners_e",
            "banners_f",
            "banners_g"});
			this.cmbBannerMode.Location = new System.Drawing.Point(303, 276);
			this.cmbBannerMode.Name = "cmbBannerMode";
			this.cmbBannerMode.Size = new System.Drawing.Size(151, 28);
			this.cmbBannerMode.TabIndex = 10;
			// 
			// lbBannerMode
			// 
			this.lbBannerMode.AutoSize = true;
			this.lbBannerMode.Enabled = false;
			this.lbBannerMode.Location = new System.Drawing.Point(186, 279);
			this.lbBannerMode.Name = "lbBannerMode";
			this.lbBannerMode.Size = new System.Drawing.Size(111, 20);
			this.lbBannerMode.TabIndex = 11;
			this.lbBannerMode.Text = "Banner Mode:";
			// 
			// chkStandardized
			// 
			this.chkStandardized.AutoSize = true;
			this.chkStandardized.Checked = true;
			this.chkStandardized.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkStandardized.Location = new System.Drawing.Point(31, 278);
			this.chkStandardized.Name = "chkStandardized";
			this.chkStandardized.Size = new System.Drawing.Size(149, 24);
			this.chkStandardized.TabIndex = 12;
			this.chkStandardized.Text = "Is Standardized?";
			this.chkStandardized.UseVisualStyleBackColor = true;
			this.chkStandardized.CheckedChanged += new System.EventHandler(this.chkStandardized_CheckedChanged);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 359);
			this.Controls.Add(this.chkStandardized);
			this.Controls.Add(this.lbBannerMode);
			this.Controls.Add(this.cmbBannerMode);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnChangeMode);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnSaveDDS);
			this.Controls.Add(this.txtBannerOutput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBrowseDDS);
			this.Controls.Add(this.txtBannerInput);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WB Banner Converter";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBannerInput;
        private System.Windows.Forms.Button btnBrowseDDS;
        private System.Windows.Forms.Button btnSaveDDS;
        private System.Windows.Forms.TextBox txtBannerOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnChangeMode;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ImageList buttonImageList;
		private System.Windows.Forms.ComboBox cmbBannerMode;
		private System.Windows.Forms.Label lbBannerMode;
		private System.Windows.Forms.CheckBox chkStandardized;
	}
}

