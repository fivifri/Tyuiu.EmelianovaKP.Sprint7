namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormChooseStatistic
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
            this.comboBoxSearchFilter_EKP = new System.Windows.Forms.ComboBox();
            this.labelSearchFilter_EKP = new System.Windows.Forms.Label();
            this.buttonFind_EKP = new System.Windows.Forms.Button();
            this.labelLegend_EKP = new System.Windows.Forms.Label();
            this.comboBoxLegend_EKP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSearchFilter_EKP
            // 
            this.comboBoxSearchFilter_EKP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchFilter_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchFilter_EKP.FormattingEnabled = true;
            this.comboBoxSearchFilter_EKP.Location = new System.Drawing.Point(236, 9);
            this.comboBoxSearchFilter_EKP.Name = "comboBoxSearchFilter_EKP";
            this.comboBoxSearchFilter_EKP.Size = new System.Drawing.Size(204, 24);
            this.comboBoxSearchFilter_EKP.TabIndex = 0;
            // 
            // labelSearchFilter_EKP
            // 
            this.labelSearchFilter_EKP.AutoSize = true;
            this.labelSearchFilter_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchFilter_EKP.Location = new System.Drawing.Point(10, 12);
            this.labelSearchFilter_EKP.Name = "labelSearchFilter_EKP";
            this.labelSearchFilter_EKP.Size = new System.Drawing.Size(203, 16);
            this.labelSearchFilter_EKP.TabIndex = 1;
            this.labelSearchFilter_EKP.Text = "Выберите колонку c данными:";
            // 
            // buttonFind_EKP
            // 
            this.buttonFind_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind_EKP.Location = new System.Drawing.Point(378, 69);
            this.buttonFind_EKP.Name = "buttonFind_EKP";
            this.buttonFind_EKP.Size = new System.Drawing.Size(62, 23);
            this.buttonFind_EKP.TabIndex = 4;
            this.buttonFind_EKP.Text = "Готово";
            this.buttonFind_EKP.UseVisualStyleBackColor = true;
            this.buttonFind_EKP.Click += new System.EventHandler(this.buttonFind_EKP_Click);
            // 
            // labelLegend_EKP
            // 
            this.labelLegend_EKP.AutoSize = true;
            this.labelLegend_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLegend_EKP.Location = new System.Drawing.Point(10, 42);
            this.labelLegend_EKP.Name = "labelLegend_EKP";
            this.labelLegend_EKP.Size = new System.Drawing.Size(216, 16);
            this.labelLegend_EKP.TabIndex = 6;
            this.labelLegend_EKP.Text = "Выберите колонку для легенды:";
            // 
            // comboBoxLegend_EKP
            // 
            this.comboBoxLegend_EKP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLegend_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLegend_EKP.FormattingEnabled = true;
            this.comboBoxLegend_EKP.Location = new System.Drawing.Point(236, 39);
            this.comboBoxLegend_EKP.Name = "comboBoxLegend_EKP";
            this.comboBoxLegend_EKP.Size = new System.Drawing.Size(204, 24);
            this.comboBoxLegend_EKP.TabIndex = 5;
            // 
            // FormChooseStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(450, 101);
            this.Controls.Add(this.labelLegend_EKP);
            this.Controls.Add(this.comboBoxLegend_EKP);
            this.Controls.Add(this.buttonFind_EKP);
            this.Controls.Add(this.labelSearchFilter_EKP);
            this.Controls.Add(this.comboBoxSearchFilter_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormChooseStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSearchFilter_EKP;
        private System.Windows.Forms.Label labelSearchFilter_EKP;
        private System.Windows.Forms.Button buttonFind_EKP;
        private System.Windows.Forms.Label labelLegend_EKP;
        private System.Windows.Forms.ComboBox comboBoxLegend_EKP;
    }
}