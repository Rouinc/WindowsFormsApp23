namespace WindowsFormsApp23
{
    partial class FormHasil
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
            this.cboxhome = new System.Windows.Forms.ComboBox();
            this.cboxaway = new System.Windows.Forms.ComboBox();
            this.lblmanager1 = new System.Windows.Forms.Label();
            this.lblmanager2 = new System.Windows.Forms.Label();
            this.lblcaptain2 = new System.Windows.Forms.Label();
            this.lblcaptain1 = new System.Windows.Forms.Label();
            this.lblstadium = new System.Windows.Forms.Label();
            this.lblcapacity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxhome
            // 
            this.cboxhome.FormattingEnabled = true;
            this.cboxhome.Location = new System.Drawing.Point(41, 79);
            this.cboxhome.Name = "cboxhome";
            this.cboxhome.Size = new System.Drawing.Size(148, 28);
            this.cboxhome.TabIndex = 0;
            this.cboxhome.SelectedIndexChanged += new System.EventHandler(this.cboxhome_SelectedIndexChanged);
            // 
            // cboxaway
            // 
            this.cboxaway.FormattingEnabled = true;
            this.cboxaway.Location = new System.Drawing.Point(433, 79);
            this.cboxaway.Name = "cboxaway";
            this.cboxaway.Size = new System.Drawing.Size(148, 28);
            this.cboxaway.TabIndex = 1;
            this.cboxaway.SelectedIndexChanged += new System.EventHandler(this.cboxaway_SelectedIndexChanged);
            // 
            // lblmanager1
            // 
            this.lblmanager1.AutoSize = true;
            this.lblmanager1.Location = new System.Drawing.Point(37, 126);
            this.lblmanager1.Name = "lblmanager1";
            this.lblmanager1.Size = new System.Drawing.Size(76, 20);
            this.lblmanager1.TabIndex = 2;
            this.lblmanager1.Text = "Manager:";
            this.lblmanager1.Click += new System.EventHandler(this.lblmanager1_Click);
            // 
            // lblmanager2
            // 
            this.lblmanager2.AutoSize = true;
            this.lblmanager2.Location = new System.Drawing.Point(429, 126);
            this.lblmanager2.Name = "lblmanager2";
            this.lblmanager2.Size = new System.Drawing.Size(76, 20);
            this.lblmanager2.TabIndex = 3;
            this.lblmanager2.Text = "Manager:";
            // 
            // lblcaptain2
            // 
            this.lblcaptain2.AutoSize = true;
            this.lblcaptain2.Location = new System.Drawing.Point(429, 176);
            this.lblcaptain2.Name = "lblcaptain2";
            this.lblcaptain2.Size = new System.Drawing.Size(68, 20);
            this.lblcaptain2.TabIndex = 4;
            this.lblcaptain2.Text = "Captain:";
            // 
            // lblcaptain1
            // 
            this.lblcaptain1.AutoSize = true;
            this.lblcaptain1.Location = new System.Drawing.Point(37, 176);
            this.lblcaptain1.Name = "lblcaptain1";
            this.lblcaptain1.Size = new System.Drawing.Size(68, 20);
            this.lblcaptain1.TabIndex = 5;
            this.lblcaptain1.Text = "Captain:";
            // 
            // lblstadium
            // 
            this.lblstadium.AutoSize = true;
            this.lblstadium.Location = new System.Drawing.Point(181, 250);
            this.lblstadium.Name = "lblstadium";
            this.lblstadium.Size = new System.Drawing.Size(69, 20);
            this.lblstadium.TabIndex = 6;
            this.lblstadium.Text = "stadium:";
            // 
            // lblcapacity
            // 
            this.lblcapacity.AutoSize = true;
            this.lblcapacity.Location = new System.Drawing.Point(181, 296);
            this.lblcapacity.Name = "lblcapacity";
            this.lblcapacity.Size = new System.Drawing.Size(71, 20);
            this.lblcapacity.TabIndex = 7;
            this.lblcapacity.Text = "capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "VS";
            // 
            // FormHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblcapacity);
            this.Controls.Add(this.lblstadium);
            this.Controls.Add(this.lblcaptain1);
            this.Controls.Add(this.lblcaptain2);
            this.Controls.Add(this.lblmanager2);
            this.Controls.Add(this.lblmanager1);
            this.Controls.Add(this.cboxaway);
            this.Controls.Add(this.cboxhome);
            this.Name = "FormHasil";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxhome;
        private System.Windows.Forms.ComboBox cboxaway;
        private System.Windows.Forms.Label lblmanager1;
        private System.Windows.Forms.Label lblmanager2;
        private System.Windows.Forms.Label lblcaptain2;
        private System.Windows.Forms.Label lblcaptain1;
        private System.Windows.Forms.Label lblstadium;
        private System.Windows.Forms.Label lblcapacity;
        private System.Windows.Forms.Label label7;
    }
}

