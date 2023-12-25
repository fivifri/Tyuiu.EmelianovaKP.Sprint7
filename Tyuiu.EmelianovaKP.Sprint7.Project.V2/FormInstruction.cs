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
            this.textBoxInstruction_EKP.Text = "Приложение для сетей магазинов, позволяющее работать с данными в виде файлов CSV.\r\n\r\nФункционал: просмотр, сортировка, редактирование, добавление, удаление, статистика, график, поиск, фильтрация.\r\n\r\nФормат файлов: CSV. \r\nКодировка: UTF-8.\r\n\r\nКраткое руководство:\r\nУдаление строки: выделите любую ячейку строки, которую хотите удалить и нажмите кнопку удалить;\r\nПоиск:  нажмите кнопку поиска и введите данные для поиска в появившемся окне;\r\nРедактирование: выделите любую ячейку строки, которую хотите изменить и измените;\r\nДобавление: нажмите кнопку добавить и введите необходимые данные в появившейся строке.\r\nПросмотр статистики и графика: нажмите кнопку статистика, выберите соответствующие колонки и нажмите \"готово\".\r\nСортировка: нажмите кнопку сортировки, выберите столбец для сортировки и как сортировать (по убыванию или по возрастанию). Нажмите кнопку \"Готово\". Данные отсортируются.";
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
