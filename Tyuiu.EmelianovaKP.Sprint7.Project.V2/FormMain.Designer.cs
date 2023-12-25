
namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeft_EKP = new System.Windows.Forms.Panel();
            this.buttonStatistic_EKP = new System.Windows.Forms.Button();
            this.openFileDialogTask_EKP = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_EKP = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_EKP = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripTopMenu_EKP = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain_EKP = new System.Windows.Forms.DataGridView();
            this.panelRight_EKP = new System.Windows.Forms.Panel();
            this.buttonSort_EKP = new System.Windows.Forms.Button();
            this.buttonSaveFile_EKP = new System.Windows.Forms.Button();
            this.buttonOpenFile_EKP = new System.Windows.Forms.Button();
            this.buttonSearch_EKP = new System.Windows.Forms.Button();
            this.buttonDelete_EKP = new System.Windows.Forms.Button();
            this.buttonAdd_EKP = new System.Windows.Forms.Button();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft_EKP.SuspendLayout();
            this.menuStripTopMenu_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_EKP)).BeginInit();
            this.panelRight_EKP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_EKP
            // 
            this.panelLeft_EKP.BackColor = System.Drawing.Color.Azure;
            this.panelLeft_EKP.Controls.Add(this.buttonSort_EKP);
            this.panelLeft_EKP.Controls.Add(this.buttonStatistic_EKP);
            this.panelLeft_EKP.Controls.Add(this.buttonSaveFile_EKP);
            this.panelLeft_EKP.Controls.Add(this.buttonOpenFile_EKP);
            this.panelLeft_EKP.Controls.Add(this.buttonSearch_EKP);
            this.panelLeft_EKP.Controls.Add(this.buttonDelete_EKP);
            this.panelLeft_EKP.Controls.Add(this.buttonAdd_EKP);
            this.panelLeft_EKP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EKP.Location = new System.Drawing.Point(0, 24);
            this.panelLeft_EKP.Name = "panelLeft_EKP";
            this.panelLeft_EKP.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_EKP.Size = new System.Drawing.Size(85, 472);
            this.panelLeft_EKP.TabIndex = 0;
            // 
            // buttonStatistic_EKP
            // 
            this.buttonStatistic_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistic_EKP.Location = new System.Drawing.Point(7, 241);
            this.buttonStatistic_EKP.Name = "buttonStatistic_EKP";
            this.buttonStatistic_EKP.Size = new System.Drawing.Size(75, 23);
            this.buttonStatistic_EKP.TabIndex = 2;
            this.buttonStatistic_EKP.Text = "Статистика";
            this.toolTipButton_EKP.SetToolTip(this.buttonStatistic_EKP, "Показать статистику и график");
            this.buttonStatistic_EKP.UseVisualStyleBackColor = true;
            this.buttonStatistic_EKP.Visible = false;
            this.buttonStatistic_EKP.Click += new System.EventHandler(this.buttonStatistic_EKP_Click);
            // 
            // openFileDialogTask_EKP
            // 
            this.openFileDialogTask_EKP.FileName = "openFileDialog1";
            // 
            // toolTipButton_EKP
            // 
            this.toolTipButton_EKP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_EKP.ToolTipTitle = "Подсказка";
            // 
            // menuStripTopMenu_EKP
            // 
            this.menuStripTopMenu_EKP.BackColor = System.Drawing.Color.Azure;
            this.menuStripTopMenu_EKP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripTopMenu_EKP.Location = new System.Drawing.Point(0, 0);
            this.menuStripTopMenu_EKP.Name = "menuStripTopMenu_EKP";
            this.menuStripTopMenu_EKP.Size = new System.Drawing.Size(796, 24);
            this.menuStripTopMenu_EKP.TabIndex = 2;
            this.menuStripTopMenu_EKP.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // dataGridViewMain_EKP
            // 
            this.dataGridViewMain_EKP.AllowUserToAddRows = false;
            this.dataGridViewMain_EKP.AllowUserToDeleteRows = false;
            this.dataGridViewMain_EKP.AllowUserToOrderColumns = true;
            this.dataGridViewMain_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain_EKP.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewMain_EKP.Name = "dataGridViewMain_EKP";
            this.dataGridViewMain_EKP.Size = new System.Drawing.Size(701, 462);
            this.dataGridViewMain_EKP.TabIndex = 0;
            // 
            // panelRight_EKP
            // 
            this.panelRight_EKP.BackColor = System.Drawing.Color.Azure;
            this.panelRight_EKP.Controls.Add(this.dataGridViewMain_EKP);
            this.panelRight_EKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EKP.Location = new System.Drawing.Point(85, 24);
            this.panelRight_EKP.Name = "panelRight_EKP";
            this.panelRight_EKP.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_EKP.Size = new System.Drawing.Size(711, 472);
            this.panelRight_EKP.TabIndex = 0;
            // 
            // buttonSort_EKP
            // 
            this.buttonSort_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort_EKP.Image = global::Tyuiu.EmelianovaKP.Sprint7.Project.V2.Properties.Resources.sort;
            this.buttonSort_EKP.Location = new System.Drawing.Point(46, 202);
            this.buttonSort_EKP.Name = "buttonSort_EKP";
            this.buttonSort_EKP.Size = new System.Drawing.Size(34, 33);
            this.buttonSort_EKP.TabIndex = 3;
            this.toolTipButton_EKP.SetToolTip(this.buttonSort_EKP, "Отсортировать по выбранному столбцу по убыванию или по возрастанию");
            this.buttonSort_EKP.UseVisualStyleBackColor = true;
            this.buttonSort_EKP.Visible = false;
            this.buttonSort_EKP.Click += new System.EventHandler(this.buttonSort_EKP_Click);
            // 
            // buttonSaveFile_EKP
            // 
            this.buttonSaveFile_EKP.Enabled = false;
            this.buttonSaveFile_EKP.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_EKP.Image")));
            this.buttonSaveFile_EKP.Location = new System.Drawing.Point(8, 86);
            this.buttonSaveFile_EKP.Name = "buttonSaveFile_EKP";
            this.buttonSaveFile_EKP.Size = new System.Drawing.Size(72, 72);
            this.buttonSaveFile_EKP.TabIndex = 0;
            this.toolTipButton_EKP.SetToolTip(this.buttonSaveFile_EKP, "Сохранить файл");
            this.buttonSaveFile_EKP.UseVisualStyleBackColor = true;
            this.buttonSaveFile_EKP.Click += new System.EventHandler(this.buttonSaveFile_EKP_Click);
            // 
            // buttonOpenFile_EKP
            // 
            this.buttonOpenFile_EKP.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_EKP.Image")));
            this.buttonOpenFile_EKP.Location = new System.Drawing.Point(8, 8);
            this.buttonOpenFile_EKP.Name = "buttonOpenFile_EKP";
            this.buttonOpenFile_EKP.Size = new System.Drawing.Size(72, 72);
            this.buttonOpenFile_EKP.TabIndex = 0;
            this.toolTipButton_EKP.SetToolTip(this.buttonOpenFile_EKP, "Открыть файл");
            this.buttonOpenFile_EKP.UseVisualStyleBackColor = true;
            this.buttonOpenFile_EKP.Click += new System.EventHandler(this.buttonOpenFile_EKP_Click);
            // 
            // buttonSearch_EKP
            // 
            this.buttonSearch_EKP.BackgroundImage = global::Tyuiu.EmelianovaKP.Sprint7.Project.V2.Properties.Resources.searchh;
            this.buttonSearch_EKP.Location = new System.Drawing.Point(8, 163);
            this.buttonSearch_EKP.Name = "buttonSearch_EKP";
            this.buttonSearch_EKP.Size = new System.Drawing.Size(34, 33);
            this.buttonSearch_EKP.TabIndex = 1;
            this.toolTipButton_EKP.SetToolTip(this.buttonSearch_EKP, "Поиск\r\n");
            this.buttonSearch_EKP.UseVisualStyleBackColor = true;
            this.buttonSearch_EKP.Visible = false;
            this.buttonSearch_EKP.Click += new System.EventHandler(this.buttonSearch_EKP_Click);
            // 
            // buttonDelete_EKP
            // 
            this.buttonDelete_EKP.BackgroundImage = global::Tyuiu.EmelianovaKP.Sprint7.Project.V2.Properties.Resources.table_row_delete;
            this.buttonDelete_EKP.Location = new System.Drawing.Point(8, 202);
            this.buttonDelete_EKP.Name = "buttonDelete_EKP";
            this.buttonDelete_EKP.Size = new System.Drawing.Size(34, 33);
            this.buttonDelete_EKP.TabIndex = 0;
            this.toolTipButton_EKP.SetToolTip(this.buttonDelete_EKP, "Удалить строку");
            this.buttonDelete_EKP.UseVisualStyleBackColor = true;
            this.buttonDelete_EKP.Visible = false;
            this.buttonDelete_EKP.Click += new System.EventHandler(this.buttonDelete_EKP_Click);
            // 
            // buttonAdd_EKP
            // 
            this.buttonAdd_EKP.BackgroundImage = global::Tyuiu.EmelianovaKP.Sprint7.Project.V2.Properties.Resources.add;
            this.buttonAdd_EKP.Location = new System.Drawing.Point(46, 164);
            this.buttonAdd_EKP.Name = "buttonAdd_EKP";
            this.buttonAdd_EKP.Size = new System.Drawing.Size(34, 32);
            this.buttonAdd_EKP.TabIndex = 0;
            this.toolTipButton_EKP.SetToolTip(this.buttonAdd_EKP, "Добавить строку");
            this.buttonAdd_EKP.UseVisualStyleBackColor = true;
            this.buttonAdd_EKP.Visible = false;
            this.buttonAdd_EKP.Click += new System.EventHandler(this.buttonAdd_EKP_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.руководствоToolStripMenuItem});
            this.помощьToolStripMenuItem.Image = global::Tyuiu.EmelianovaKP.Sprint7.Project.V2.Properties.Resources.help;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.руководствоToolStripMenuItem.Text = "Руководство";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.руководствоToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.panelRight_EKP);
            this.Controls.Add(this.panelLeft_EKP);
            this.Controls.Add(this.menuStripTopMenu_EKP);
            this.MainMenuStrip = this.menuStripTopMenu_EKP;
            this.MinimumSize = new System.Drawing.Size(788, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сеть магазинов";
            this.panelLeft_EKP.ResumeLayout(false);
            this.menuStripTopMenu_EKP.ResumeLayout(false);
            this.menuStripTopMenu_EKP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_EKP)).EndInit();
            this.panelRight_EKP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_EKP;
        private System.Windows.Forms.Button buttonSaveFile_EKP;
        private System.Windows.Forms.Button buttonOpenFile_EKP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_EKP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_EKP;
        private System.Windows.Forms.ToolTip toolTipButton_EKP;
        private System.Windows.Forms.MenuStrip menuStripTopMenu_EKP;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        public System.Windows.Forms.Button buttonDelete_EKP;
        public System.Windows.Forms.DataGridView dataGridViewMain_EKP;
        private System.Windows.Forms.Panel panelRight_EKP;
        private System.Windows.Forms.Button buttonSearch_EKP;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonStatistic_EKP;
        public System.Windows.Forms.Button buttonAdd_EKP;
        private System.Windows.Forms.Button buttonSort_EKP;
    }
}

