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
    public partial class FormAdd : Form
    {
        FormMain fmain;
        public FormAdd(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void buttonAdd_EKP_Click_1(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_EKP.Rows.Add(textBoxNumber_EKP.Text, textBoxName_EKP.Text, textBoxAddress_EKP.Text, textBoxPhoneNumber_EKP.Text, textBoxOwnersCapital_EKP.Text);
            fmain.buttonDelete_EKP.Enabled = true;
            this.Close();
        }

        private void labelNumber_EKP_Click(object sender, EventArgs e)
        {

        }

        private void labelName_EKP_Click(object sender, EventArgs e)
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

