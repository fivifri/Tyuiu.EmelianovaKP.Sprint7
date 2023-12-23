namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxCountShops_EKP = new System.Windows.Forms.TextBox();
            this.labelCountShops_EKP = new System.Windows.Forms.Label();
            this.labelSumCapitals_EKP = new System.Windows.Forms.Label();
            this.textBoxSumCapitals_EKP = new System.Windows.Forms.TextBox();
            this.labelMinCapital_EKP = new System.Windows.Forms.Label();
            this.textBoxMinCapital_EKP = new System.Windows.Forms.TextBox();
            this.labelMaxCapital_EKP = new System.Windows.Forms.Label();
            this.textBoxMaxCapital_EKP = new System.Windows.Forms.TextBox();
            this.labelMeanCapital_EKP = new System.Windows.Forms.Label();
            this.textBoxMeanCapital_EKP = new System.Windows.Forms.TextBox();
            this.chartCapital_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCapital_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCountShops_EKP
            // 
            this.textBoxCountShops_EKP.Location = new System.Drawing.Point(15, 35);
            this.textBoxCountShops_EKP.Name = "textBoxCountShops_EKP";
            this.textBoxCountShops_EKP.ReadOnly = true;
            this.textBoxCountShops_EKP.Size = new System.Drawing.Size(124, 20);
            this.textBoxCountShops_EKP.TabIndex = 0;
            this.textBoxCountShops_EKP.TabStop = false;
            // 
            // labelCountShops_EKP
            // 
            this.labelCountShops_EKP.AutoSize = true;
            this.labelCountShops_EKP.Location = new System.Drawing.Point(12, 19);
            this.labelCountShops_EKP.Name = "labelCountShops_EKP";
            this.labelCountShops_EKP.Size = new System.Drawing.Size(127, 13);
            this.labelCountShops_EKP.TabIndex = 1;
            this.labelCountShops_EKP.Text = "Количество магазинов:";
            // 
            // labelSumCapitals_EKP
            // 
            this.labelSumCapitals_EKP.AutoSize = true;
            this.labelSumCapitals_EKP.Location = new System.Drawing.Point(153, 19);
            this.labelSumCapitals_EKP.Name = "labelSumCapitals_EKP";
            this.labelSumCapitals_EKP.Size = new System.Drawing.Size(100, 13);
            this.labelSumCapitals_EKP.TabIndex = 3;
            this.labelSumCapitals_EKP.Text = "Сумма капиталов:";
            // 
            // textBoxSumCapitals_EKP
            // 
            this.textBoxSumCapitals_EKP.Location = new System.Drawing.Point(156, 35);
            this.textBoxSumCapitals_EKP.Name = "textBoxSumCapitals_EKP";
            this.textBoxSumCapitals_EKP.ReadOnly = true;
            this.textBoxSumCapitals_EKP.Size = new System.Drawing.Size(120, 20);
            this.textBoxSumCapitals_EKP.TabIndex = 2;
            this.textBoxSumCapitals_EKP.TabStop = false;
            // 
            // labelMinCapital_EKP
            // 
            this.labelMinCapital_EKP.AutoSize = true;
            this.labelMinCapital_EKP.Location = new System.Drawing.Point(290, 19);
            this.labelMinCapital_EKP.Name = "labelMinCapital_EKP";
            this.labelMinCapital_EKP.Size = new System.Drawing.Size(127, 13);
            this.labelMinCapital_EKP.TabIndex = 5;
            this.labelMinCapital_EKP.Text = "Минимальный капитал:";
            // 
            // textBoxMinCapital_EKP
            // 
            this.textBoxMinCapital_EKP.Location = new System.Drawing.Point(293, 35);
            this.textBoxMinCapital_EKP.Name = "textBoxMinCapital_EKP";
            this.textBoxMinCapital_EKP.ReadOnly = true;
            this.textBoxMinCapital_EKP.Size = new System.Drawing.Size(120, 20);
            this.textBoxMinCapital_EKP.TabIndex = 4;
            this.textBoxMinCapital_EKP.TabStop = false;
            // 
            // labelMaxCapital_EKP
            // 
            this.labelMaxCapital_EKP.AutoSize = true;
            this.labelMaxCapital_EKP.Location = new System.Drawing.Point(429, 19);
            this.labelMaxCapital_EKP.Name = "labelMaxCapital_EKP";
            this.labelMaxCapital_EKP.Size = new System.Drawing.Size(133, 13);
            this.labelMaxCapital_EKP.TabIndex = 7;
            this.labelMaxCapital_EKP.Text = "Максимальный капитал:";
            // 
            // textBoxMaxCapital_EKP
            // 
            this.textBoxMaxCapital_EKP.Location = new System.Drawing.Point(432, 35);
            this.textBoxMaxCapital_EKP.Name = "textBoxMaxCapital_EKP";
            this.textBoxMaxCapital_EKP.ReadOnly = true;
            this.textBoxMaxCapital_EKP.Size = new System.Drawing.Size(130, 20);
            this.textBoxMaxCapital_EKP.TabIndex = 6;
            this.textBoxMaxCapital_EKP.TabStop = false;
            // 
            // labelMeanCapital_EKP
            // 
            this.labelMeanCapital_EKP.AutoSize = true;
            this.labelMeanCapital_EKP.Location = new System.Drawing.Point(577, 19);
            this.labelMeanCapital_EKP.Name = "labelMeanCapital_EKP";
            this.labelMeanCapital_EKP.Size = new System.Drawing.Size(97, 13);
            this.labelMeanCapital_EKP.TabIndex = 9;
            this.labelMeanCapital_EKP.Text = "Средний капитал:";
            // 
            // textBoxMeanCapital_EKP
            // 
            this.textBoxMeanCapital_EKP.Location = new System.Drawing.Point(580, 35);
            this.textBoxMeanCapital_EKP.Name = "textBoxMeanCapital_EKP";
            this.textBoxMeanCapital_EKP.ReadOnly = true;
            this.textBoxMeanCapital_EKP.Size = new System.Drawing.Size(124, 20);
            this.textBoxMeanCapital_EKP.TabIndex = 8;
            this.textBoxMeanCapital_EKP.TabStop = false;
            // 
            // chartCapital_EKP
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCapital_EKP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCapital_EKP.Legends.Add(legend1);
            this.chartCapital_EKP.Location = new System.Drawing.Point(15, 74);
            this.chartCapital_EKP.Name = "chartCapital_EKP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCapital_EKP.Series.Add(series1);
            this.chartCapital_EKP.Size = new System.Drawing.Size(692, 368);
            this.chartCapital_EKP.TabIndex = 10;
            this.chartCapital_EKP.Text = "Капитал";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 454);
            this.Controls.Add(this.chartCapital_EKP);
            this.Controls.Add(this.labelMeanCapital_EKP);
            this.Controls.Add(this.textBoxMeanCapital_EKP);
            this.Controls.Add(this.labelMaxCapital_EKP);
            this.Controls.Add(this.textBoxMaxCapital_EKP);
            this.Controls.Add(this.labelMinCapital_EKP);
            this.Controls.Add(this.textBoxMinCapital_EKP);
            this.Controls.Add(this.labelSumCapitals_EKP);
            this.Controls.Add(this.textBoxSumCapitals_EKP);
            this.Controls.Add(this.labelCountShops_EKP);
            this.Controls.Add(this.textBoxCountShops_EKP);
            this.Name = "FormStatistic";
            this.Text = "Статистика по капиталу";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCapital_EKP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountShops_EKP;
        private System.Windows.Forms.Label labelCountShops_EKP;
        private System.Windows.Forms.Label labelSumCapitals_EKP;
        private System.Windows.Forms.TextBox textBoxSumCapitals_EKP;
        private System.Windows.Forms.Label labelMinCapital_EKP;
        private System.Windows.Forms.TextBox textBoxMinCapital_EKP;
        private System.Windows.Forms.Label labelMaxCapital_EKP;
        private System.Windows.Forms.TextBox textBoxMaxCapital_EKP;
        private System.Windows.Forms.Label labelMeanCapital_EKP;
        private System.Windows.Forms.TextBox textBoxMeanCapital_EKP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapital_EKP;
    }
}