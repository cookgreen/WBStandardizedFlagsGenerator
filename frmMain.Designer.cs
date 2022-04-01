
namespace WBStandardizedBannerGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWBBannerDDS = new System.Windows.Forms.TextBox();
            this.btnBrowseDDS = new System.Windows.Forms.Button();
            this.btnSaveDDS = new System.Windows.Forms.Button();
            this.txtStandardBannerDDS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banner DDS File:";
            // 
            // txtWBBannerDDS
            // 
            this.txtWBBannerDDS.Location = new System.Drawing.Point(158, 24);
            this.txtWBBannerDDS.Name = "txtWBBannerDDS";
            this.txtWBBannerDDS.ReadOnly = true;
            this.txtWBBannerDDS.Size = new System.Drawing.Size(477, 27);
            this.txtWBBannerDDS.TabIndex = 1;
            // 
            // btnBrowseDDS
            // 
            this.btnBrowseDDS.Location = new System.Drawing.Point(641, 22);
            this.btnBrowseDDS.Name = "btnBrowseDDS";
            this.btnBrowseDDS.Size = new System.Drawing.Size(67, 29);
            this.btnBrowseDDS.TabIndex = 2;
            this.btnBrowseDDS.Text = "...";
            this.btnBrowseDDS.UseVisualStyleBackColor = true;
            this.btnBrowseDDS.Click += new System.EventHandler(this.btnBrowseDDS_Click);
            // 
            // btnSaveDDS
            // 
            this.btnSaveDDS.Location = new System.Drawing.Point(641, 68);
            this.btnSaveDDS.Name = "btnSaveDDS";
            this.btnSaveDDS.Size = new System.Drawing.Size(67, 29);
            this.btnSaveDDS.TabIndex = 5;
            this.btnSaveDDS.Text = "...";
            this.btnSaveDDS.UseVisualStyleBackColor = true;
            this.btnSaveDDS.Click += new System.EventHandler(this.btnSaveDDS_Click);
            // 
            // txtStandardBannerDDS
            // 
            this.txtStandardBannerDDS.Location = new System.Drawing.Point(158, 70);
            this.txtStandardBannerDDS.Name = "txtStandardBannerDDS";
            this.txtStandardBannerDDS.ReadOnly = true;
            this.txtStandardBannerDDS.Size = new System.Drawing.Size(477, 27);
            this.txtStandardBannerDDS.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output DDS File:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(570, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 68);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 183);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSaveDDS);
            this.Controls.Add(this.txtStandardBannerDDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseDDS);
            this.Controls.Add(this.txtWBBannerDDS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WB Standardized Banner Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWBBannerDDS;
        private System.Windows.Forms.Button btnBrowseDDS;
        private System.Windows.Forms.Button btnSaveDDS;
        private System.Windows.Forms.TextBox txtStandardBannerDDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
    }
}

