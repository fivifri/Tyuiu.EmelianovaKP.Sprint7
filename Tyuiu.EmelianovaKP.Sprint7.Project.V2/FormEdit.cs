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
    public partial class FormEdit : Form
    {
        FormMain fmain;
        public FormEdit(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void buttonEdit_EKP_Click(object sender, EventArgs e)
        {
            int row = fmain.dataGridViewMain_EKP.CurrentRow.Index;
            fmain.dataGridViewMain_EKP.Rows[row].Cells[0].Value = textBoxNumber_EKP.Text;
            fmain.dataGridViewMain_EKP.Rows[row].Cells[1].Value = textBoxName_EKP.Text;
            fmain.dataGridViewMain_EKP.Rows[row].Cells[2].Value = textBoxAddress_EKP.Text;
            fmain.dataGridViewMain_EKP.Rows[row].Cells[3].Value = textBoxPhoneNumber_EKP.Text;
            fmain.dataGridViewMain_EKP.Rows[row].Cells[4].Value = textBoxOwnersCapital_EKP.Text;
            this.Close();
        }
    }
}
