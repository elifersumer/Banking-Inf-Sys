
namespace Staj_Projesi
{
    partial class BankerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankerForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfoOutput = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(45, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Banker Information";
            // 
            // lblInfoOutput
            // 
            this.lblInfoOutput.AutoSize = true;
            this.lblInfoOutput.BackColor = System.Drawing.Color.White;
            this.lblInfoOutput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfoOutput.Location = new System.Drawing.Point(161, 100);
            this.lblInfoOutput.Name = "lblInfoOutput";
            this.lblInfoOutput.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.lblInfoOutput.Size = new System.Drawing.Size(0, 117);
            this.lblInfoOutput.TabIndex = 2;
            // 
            // gbx
            // 
            this.gbx.BackColor = System.Drawing.Color.Azure;
            this.gbx.Controls.Add(this.lblInfoName);
            this.gbx.Controls.Add(this.lblTitle);
            this.gbx.Controls.Add(this.lblInfoOutput);
            this.gbx.Location = new System.Drawing.Point(216, 62);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(381, 338);
            this.gbx.TabIndex = 8;
            this.gbx.TabStop = false;
            // 
            // lblInfoName
            // 
            this.lblInfoName.AutoSize = true;
            this.lblInfoName.BackColor = System.Drawing.Color.White;
            this.lblInfoName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfoName.Location = new System.Drawing.Point(45, 100);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.lblInfoName.Size = new System.Drawing.Size(0, 117);
            this.lblInfoName.TabIndex = 3;
            // 
            // BankerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx);
            this.Name = "BankerForm";
            this.Text = "BankerForm";
            this.Load += new System.EventHandler(this.BankerForm_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfoOutput;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblInfoName;
    }
}