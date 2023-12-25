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

    public partial class FormSort : Form
    {
        FormMain fmain;
        public FormSort(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        static int column;

        private void FormSort_Load(object sender, EventArgs e)
        {
            int columns = fmain.dataGridViewMain_EKP.ColumnCount;

            string[] columnsHeaders = new string[columns];

            for (int i = 0; i < columns; ++i)
            {
                columnsHeaders[i] = fmain.dataGridViewMain_EKP.Columns[i].HeaderText;
            }

            this.comboBoxSort_EKP.Items.AddRange(columnsHeaders);
            this.comboBoxSortDirection_EKP.Items.AddRange(new string[] {"убыванию", "возрастанию"});
        }

        private void buttonFind_EKP_Click(object sender, EventArgs e)
        {
            try 
            {
                column = comboBoxSort_EKP.SelectedIndex;
                int direction = comboBoxSortDirection_EKP.SelectedIndex;
                if (direction == 0)
                {
                    fmain.dataGridViewMain_EKP.Sort(new RowComparer(SortOrder.Descending));
                }
                else
                {
                    fmain.dataGridViewMain_EKP.Sort(new RowComparer(SortOrder.Ascending));
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Данные некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class RowComparer : System.Collections.IComparer
        {
            private static int sortOrderModifier = 1;

            public RowComparer(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }
            }

            public int Compare(object x, object y)
            {
                DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
                DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

                int CompareResult = 0;

                try
                {
                    CompareResult = Convert.ToInt32(DataGridViewRow1.Cells[column].Value.ToString()).CompareTo(Convert.ToInt32(DataGridViewRow2.Cells[column].Value.ToString()));
                }
                catch
                {
                    CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[column].Value.ToString(),
                    DataGridViewRow2.Cells[column].Value.ToString());
                }

                return CompareResult * sortOrderModifier;
            }
        }
    }
}
