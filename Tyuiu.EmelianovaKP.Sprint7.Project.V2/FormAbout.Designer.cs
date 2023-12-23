
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonDone_EKP = new System.Windows.Forms.Button();
            this.pictureBoxDeveloper_EKP = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(190, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 155);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 238);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}