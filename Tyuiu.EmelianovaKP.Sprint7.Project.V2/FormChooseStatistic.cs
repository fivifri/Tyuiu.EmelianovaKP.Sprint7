using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    public partial class FormChooseStatistic : Form
    {
        FormMain fmain;
        public FormChooseStatistic(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void buttonFind_EKP_Click(object sender, EventArgs e)
        {
            this.Close();
            FormStatistic formStatistic = new FormStatistic(fmain, comboBoxSearchFilter_EKP.SelectedIndex, comboBoxLegend_EKP.SelectedIndex);
            formStatistic.ShowDialog();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            int columns = fmain.dataGridViewMain_EKP.ColumnCount;

            string[] columnsHeaders = new string[columns];

            for (int i = 0; i < columns; ++i)
            {
                columnsHeaders[i] = fmain.dataGridViewMain_EKP.Columns[i].HeaderText;
            }

            this.comboBoxSearchFilter_EKP.Items.AddRange(columnsHeaders);
            this.comboBoxLegend_EKP.Items.AddRange(columnsHeaders);
        }
    }
}
