
namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            this.buttonOk_EKP = new System.Windows.Forms.Button();
            this.textBoxInstruction_EKP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk_EKP
            // 
            this.buttonOk_EKP.Location = new System.Drawing.Point(713, 377);
            this.buttonOk_EKP.Name = "buttonOk_EKP";
            this.buttonOk_EKP.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_EKP.TabIndex = 0;
            this.buttonOk_EKP.Text = "OK";
            this.buttonOk_EKP.UseVisualStyleBackColor = true;
            this.buttonOk_EKP.Click += new System.EventHandler(this.buttonOk_EKP_Click);
            // 
            // textBoxInstruction_EKP
            // 
            this.textBoxInstruction_EKP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInstruction_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInstruction_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstruction_EKP.Location = new System.Drawing.Point(12, 12);
            this.textBoxInstruction_EKP.Multiline = true;
            this.textBoxInstruction_EKP.Name = "textBoxInstruction_EKP";
            this.textBoxInstruction_EKP.ReadOnly = true;
            this.textBoxInstruction_EKP.Size = new System.Drawing.Size(596, 298);
            this.textBoxInstruction_EKP.TabIndex = 1;
            this.textBoxInstruction_EKP.TabStop = false;
            this.textBoxInstruction_EKP.Text = resources.GetString("textBoxInstruction_EKP.Text");
            // 
            // FormInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(610, 312);
            this.Controls.Add(this.textBoxInstruction_EKP);
            this.Controls.Add(this.buttonOk_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_EKP;
        private System.Windows.Forms.TextBox textBoxInstruction_EKP;
    }
}