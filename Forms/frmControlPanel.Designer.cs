namespace WBBannerConverter
{
	partial class frmControlPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlPanel));
			this.btnStartConverter = new System.Windows.Forms.Button();
			this.btnStartGenerator = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStartConverter
			// 
			this.btnStartConverter.Location = new System.Drawing.Point(30, 28);
			this.btnStartConverter.Name = "btnStartConverter";
			this.btnStartConverter.Size = new System.Drawing.Size(384, 145);
			this.btnStartConverter.TabIndex = 0;
			this.btnStartConverter.Text = "Converter";
			this.btnStartConverter.UseVisualStyleBackColor = true;
			this.btnStartConverter.Click += new System.EventHandler(this.btnStartConverter_Click);
			// 
			// btnStartGenerator
			// 
			this.btnStartGenerator.Location = new System.Drawing.Point(30, 220);
			this.btnStartGenerator.Name = "btnStartGenerator";
			this.btnStartGenerator.Size = new System.Drawing.Size(384, 158);
			this.btnStartGenerator.TabIndex = 1;
			this.btnStartGenerator.Text = "Generator";
			this.btnStartGenerator.UseVisualStyleBackColor = true;
			this.btnStartGenerator.Click += new System.EventHandler(this.btnStartGenerator_Click);
			// 
			// frmControlPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 430);
			this.Controls.Add(this.btnStartGenerator);
			this.Controls.Add(this.btnStartConverter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmControlPanel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control Panel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStartConverter;
		private System.Windows.Forms.Button btnStartGenerator;
	}
}