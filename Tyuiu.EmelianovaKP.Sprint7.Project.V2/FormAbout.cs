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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.textBoxAbout_EKP.Text = "Разработчик: Емельянова К. П.\r\nГруппа: ПКТб-23-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа цифровых технологий (с) 2023\r\n\r\nВнутреннее имя: Tyuiu.EmelianovaKP.Sprint7.Project.V2\r\n";
        }

        private void buttonDone_EKP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
