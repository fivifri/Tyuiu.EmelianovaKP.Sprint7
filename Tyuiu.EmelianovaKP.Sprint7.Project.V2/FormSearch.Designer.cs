
namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormSearch
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
            this.labelFind_EKP = new System.Windows.Forms.Label();
            this.textBoxFind_EKP = new System.Windows.Forms.TextBox();
            this.buttonFind_EKP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSearchFilter_EKP
            // 
            this.comboBoxSearchFilter_EKP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchFilter_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchFilter_EKP.FormattingEnabled = true;
            this.comboBoxSearchFilter_EKP.Items.AddRange(new object[] {
            "Идентификатор",
            "Название",
            "Адрес",
            "Номер телефона",
            "Капитал владельца"});
            this.comboBoxSearchFilter_EKP.Location = new System.Drawing.Point(148, 9);
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
            this.labelSearchFilter_EKP.Size = new System.Drawing.Size(132, 16);
            this.labelSearchFilter_EKP.TabIndex = 1;
            this.labelSearchFilter_EKP.Text = "Выберите колонку:";
            // 
            // labelFind_EKP
            // 
            this.labelFind_EKP.AutoSize = true;
            this.labelFind_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFind_EKP.Location = new System.Drawing.Point(370, 12);
            this.labelFind_EKP.Name = "labelFind_EKP";
            this.labelFind_EKP.Size = new System.Drawing.Size(191, 16);
            this.labelFind_EKP.TabIndex = 2;
            this.labelFind_EKP.Text = "Введите запрос для поиска:";
            // 
            // textBoxFind_EKP
            // 
            this.textBoxFind_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind_EKP.Location = new System.Drawing.Point(567, 9);
            this.textBoxFind_EKP.Name = "textBoxFind_EKP";
            this.textBoxFind_EKP.Size = new System.Drawing.Size(168, 22);
            this.textBoxFind_EKP.TabIndex = 3;
            // 
            // buttonFind_EKP
            // 
            this.buttonFind_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind_EKP.Location = new System.Drawing.Point(673, 37);
            this.buttonFind_EKP.Name = "buttonFind_EKP";
            this.buttonFind_EKP.Size = new System.Drawing.Size(62, 23);
            this.buttonFind_EKP.TabIndex = 4;
            this.buttonFind_EKP.Text = "Поиск";
            this.buttonFind_EKP.UseVisualStyleBackColor = true;
            this.buttonFind_EKP.Click += new System.EventHandler(this.buttonFind_EKP_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(745, 71);
            this.Controls.Add(this.buttonFind_EKP);
            this.Controls.Add(this.textBoxFind_EKP);
            this.Controls.Add(this.labelFind_EKP);
            this.Controls.Add(this.labelSearchFilter_EKP);
            this.Controls.Add(this.comboBoxSearchFilter_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchFilter_EKP;
        private System.Windows.Forms.Label labelSearchFilter_EKP;
        private System.Windows.Forms.Label labelFind_EKP;
        private System.Windows.Forms.TextBox textBoxFind_EKP;
        private System.Windows.Forms.Button buttonFind_EKP;
    }
}