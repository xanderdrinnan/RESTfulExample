namespace Interface
{
    partial class ServiceForm
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
            this.locationBtn = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.outputRich = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // locationBtn
            // 
            this.locationBtn.Location = new System.Drawing.Point(303, 26);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(150, 23);
            this.locationBtn.TabIndex = 0;
            this.locationBtn.Text = "Get weather";
            this.locationBtn.UseVisualStyleBackColor = true;
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(16, 29);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(281, 20);
            this.locationBox.TabIndex = 1;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(284, 81);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 13);
            this.infoLbl.TabIndex = 2;
            // 
            // outputRich
            // 
            this.outputRich.Location = new System.Drawing.Point(16, 60);
            this.outputRich.Name = "outputRich";
            this.outputRich.Size = new System.Drawing.Size(437, 282);
            this.outputRich.TabIndex = 3;
            this.outputRich.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter location (e.g. Conestoga College Waterloo)";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputRich);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationBtn);
            this.MaximizeBox = false;
            this.Name = "ServiceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.RichTextBox outputRich;
        private System.Windows.Forms.Label label1;
    }
}

