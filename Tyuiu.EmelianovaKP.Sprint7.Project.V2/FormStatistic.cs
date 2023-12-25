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
        int j;
        int k;

        FormMain fmain;
        public FormStatistic(FormMain form, int index, int index2)
        {
            InitializeComponent();
            this.fmain = form;
            j = index;
            k = index2;
        }

        DataService ds = new DataService();

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            int rows = fmain.dataGridViewMain_EKP.RowCount;

            int[] array = new int[rows];
            string[] arrayLegend = new string[rows];

            try 
            {
                for (int i = 0; i < rows; i++)
                {
                    array[i] = Convert.ToInt32(fmain.dataGridViewMain_EKP.Rows[i].Cells[j].Value);
                    arrayLegend[i] = fmain.dataGridViewMain_EKP.Rows[i].Cells[k].Value.ToString();
                    
                }

                this.textBoxCountShops_EKP.Text = rows.ToString();
                this.textBoxSumCapitals_EKP.Text = ds.SumCapital(ref array).ToString();
                this.textBoxMinCapital_EKP.Text = ds.MinCapital(ref array).ToString();
                this.textBoxMaxCapital_EKP.Text = ds.MaxCapital(ref array).ToString();
                this.textBoxMeanCapital_EKP.Text = ds.MeanCapital(ref array).ToString();

                this.chartCapital_EKP.Titles.Add("Статистика по столбцу \"" + fmain.dataGridViewMain_EKP.Columns[j].HeaderText + "\".");
                this.chartCapital_EKP.Series.Clear();

                for (int i = 0; i < array.Length; i++)
                {
                    Series series = this.chartCapital_EKP.Series.Add(fmain.dataGridViewMain_EKP.Columns[k].HeaderText + ": " + arrayLegend[i]);

                    series.Points.Add(array[i]);
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
