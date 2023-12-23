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
    public partial class FormSearch : Form
    {
        FormMain fmain;
        public FormSearch(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void buttonFind_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewMain_EKP.RowCount; i++)
                {
                    fmain.dataGridViewMain_EKP.Rows[i].Selected = false;
                    for (int j = comboBoxSearchFilter_EKP.SelectedIndex; j < fmain.dataGridViewMain_EKP.ColumnCount; j++)
                        if (fmain.dataGridViewMain_EKP.Rows[i].Cells[j].Value != null)
                            if (fmain.dataGridViewMain_EKP.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_EKP.Text))
                            {
                                fmain.dataGridViewMain_EKP.Rows[i].Selected = true;
                                break;
                            }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка поиска!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
