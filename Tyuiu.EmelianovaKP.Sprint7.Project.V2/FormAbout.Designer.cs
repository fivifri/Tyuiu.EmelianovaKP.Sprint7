
namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormAbout
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
            this.buttonDone_EKP = new System.Windows.Forms.Button();
            this.pictureBoxDeveloper_EKP = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_EKP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_EKP
            // 
            this.buttonDone_EKP.Location = new System.Drawing.Point(471, 203);
            this.buttonDone_EKP.Name = "buttonDone_EKP";
            this.buttonDone_EKP.Size = new System.Drawing.Size(77, 31);
            this.buttonDone_EKP.TabIndex = 5;
            this.buttonDone_EKP.TabStop = false;
            this.buttonDone_EKP.Text = "OK";
            this.buttonDone_EKP.UseVisualStyleBackColor = true;
            this.buttonDone_EKP.Click += new System.EventHandler(this.buttonDone_EKP_Click);
            // 
            // pictureBoxDeveloper_EKP
            // 
            this.pictureBoxDeveloper_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint7.Project.V2.Properties.Resources.me;
            this.pictureBoxDeveloper_EKP.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxDeveloper_EKP.Name = "pictureBoxDeveloper_EKP";
            this.pictureBoxDeveloper_EKP.Size = new System.Drawing.Size(171, 225);
            this.pictureBoxDeveloper_EKP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeveloper_EKP.TabIndex = 3;
            this.pictureBoxDeveloper_EKP.TabStop = false;
            // 
            // textBoxAbout_EKP
            // 
            this.textBoxAbout_EKP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAbout_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_EKP.Enabled = false;
            this.textBoxAbout_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAbout_EKP.ForeColor = System.Drawing.Color.Black;
            this.textBoxAbout_EKP.Location = new System.Drawing.Point(190, 12);
            this.textBoxAbout_EKP.Multiline = true;
            this.textBoxAbout_EKP.Name = "textBoxAbout_EKP";
            this.textBoxAbout_EKP.Size = new System.Drawing.Size(358, 155);
            this.textBoxAbout_EKP.TabIndex = 0;
            this.textBoxAbout_EKP.TabStop = false;
            this.textBoxAbout_EKP.WordWrap = false;
            this.textBoxAbout_EKP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 238);
            this.Controls.Add(this.textBoxAbout_EKP);
            this.Controls.Add(this.buttonDone_EKP);
            this.Controls.Add(this.pictureBoxDeveloper_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_EKP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_EKP;
        private System.Windows.Forms.PictureBox pictureBoxDeveloper_EKP;
        private System.Windows.Forms.TextBox textBoxAbout_EKP;
    }
}