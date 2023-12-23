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
    public partial class FormInstruction : Form
    {
        public FormInstruction()
        {
            InitializeComponent();
        }

        private void buttonOk_EKP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAbout_EKP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
