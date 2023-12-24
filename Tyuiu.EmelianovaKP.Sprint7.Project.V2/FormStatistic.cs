using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.EmelianovaKP.Sprint7.Project.V2.Lib;

namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    public partial class FormStatistic : Form
    {
        FormMain fmain;
        public FormStatistic(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        DataService ds = new DataService();

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            int rows = fmain.dataGridViewMain_EKP.RowCount;

            int[] arrayCapitals = new int[rows];
            string[] seriesArray = new string[rows];

            try 
            {
                for (int i = 0; i < rows; i++)
                {
                    arrayCapitals[i] = Convert.ToInt32(fmain.dataGridViewMain_EKP.Rows[i].Cells[4].Value);
                    string shop = fmain.dataGridViewMain_EKP.Rows[i].Cells[1].Value.ToString();
                    string id = fmain.dataGridViewMain_EKP.Rows[i].Cells[0].Value.ToString();
                    seriesArray[i] = String.Format("Название: {0,-30} Идентификатор: {1,-100}", shop, id);
                }

                this.textBoxCountShops_EKP.Text = rows.ToString();
                this.textBoxSumCapitals_EKP.Text = ds.SumCapital(ref arrayCapitals).ToString();
                this.textBoxMinCapital_EKP.Text = ds.MinCapital(ref arrayCapitals).ToString();
                this.textBoxMaxCapital_EKP.Text = ds.MaxCapital(ref arrayCapitals).ToString();
                this.textBoxMeanCapital_EKP.Text = ds.MeanCapital(ref arrayCapitals).ToString();

                this.chartCapital_EKP.Titles.Add("Капиталы владельцев");
                this.chartCapital_EKP.Series.Clear();

                for (int i = 0; i < seriesArray.Length; i++)
                {
                    Series series = this.chartCapital_EKP.Series.Add(seriesArray[i]);

                    series.Points.Add(arrayCapitals[i]);
                }
            }
            catch
            {
                MessageBox.Show("Данные некорректы! Невозможно отобразить статистику!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
