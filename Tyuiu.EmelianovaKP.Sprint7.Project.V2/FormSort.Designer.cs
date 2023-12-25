namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormSort
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
            this.labelSearchFilter_EKP = new System.Windows.Forms.Label();
            this.comboBoxSort_EKP = new System.Windows.Forms.ComboBox();
            this.buttonFind_EKP = new System.Windows.Forms.Button();
            this.labelSortDirection_EKP = new System.Windows.Forms.Label();
            this.comboBoxSortDirection_EKP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSearchFilter_EKP
            // 
            this.labelSearchFilter_EKP.AutoSize = true;
            this.labelSearchFilter_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchFilter_EKP.Location = new System.Drawing.Point(6, 15);
            this.labelSearchFilter_EKP.Name = "labelSearchFilter_EKP";
            this.labelSearchFilter_EKP.Size = new System.Drawing.Size(132, 16);
            this.labelSearchFilter_EKP.TabIndex = 3;
            this.labelSearchFilter_EKP.Text = "Выберите колонку:";
            // 
            // comboBoxSort_EKP
            // 
            this.comboBoxSort_EKP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort_EKP.FormattingEnabled = true;
            this.comboBoxSort_EKP.Location = new System.Drawing.Point(144, 12);
            this.comboBoxSort_EKP.Name = "comboBoxSort_EKP";
            this.comboBoxSort_EKP.Size = new System.Drawing.Size(204, 24);
            this.comboBoxSort_EKP.TabIndex = 2;
            // 
            // buttonFind_EKP
            // 
            this.buttonFind_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind_EKP.Location = new System.Drawing.Point(286, 72);
            this.buttonFind_EKP.Name = "buttonFind_EKP";
            this.buttonFind_EKP.Size = new System.Drawing.Size(62, 23);
            this.buttonFind_EKP.TabIndex = 5;
            this.buttonFind_EKP.Text = "Готово";
            this.buttonFind_EKP.UseVisualStyleBackColor = true;
            this.buttonFind_EKP.Click += new System.EventHandler(this.buttonFind_EKP_Click);
            // 
            // labelSortDirection_EKP
            // 
            this.labelSortDirection_EKP.AutoSize = true;
            this.labelSortDirection_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortDirection_EKP.Location = new System.Drawing.Point(6, 45);
            this.labelSortDirection_EKP.Name = "labelSortDirection_EKP";
            this.labelSortDirection_EKP.Size = new System.Drawing.Size(115, 16);
            this.labelSortDirection_EKP.TabIndex = 7;
            this.labelSortDirection_EKP.Text = "Сортировать по:";
            // 
            // comboBoxSortDirection_EKP
            // 
            this.comboBoxSortDirection_EKP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortDirection_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortDirection_EKP.FormattingEnabled = true;
            this.comboBoxSortDirection_EKP.Location = new System.Drawing.Point(144, 42);
            this.comboBoxSortDirection_EKP.Name = "comboBoxSortDirection_EKP";
            this.comboBoxSortDirection_EKP.Size = new System.Drawing.Size(204, 24);
            this.comboBoxSortDirection_EKP.TabIndex = 6;
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 105);
            this.Controls.Add(this.labelSortDirection_EKP);
            this.Controls.Add(this.comboBoxSortDirection_EKP);
            this.Controls.Add(this.buttonFind_EKP);
            this.Controls.Add(this.labelSearchFilter_EKP);
            this.Controls.Add(this.comboBoxSort_EKP);
            this.Name = "FormSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.FormSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchFilter_EKP;
        private System.Windows.Forms.ComboBox comboBoxSort_EKP;
        private System.Windows.Forms.Button buttonFind_EKP;
        private System.Windows.Forms.Label labelSortDirection_EKP;
        private System.Windows.Forms.ComboBox comboBoxSortDirection_EKP;
    }
}