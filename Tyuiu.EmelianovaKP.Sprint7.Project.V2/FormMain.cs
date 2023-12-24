using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.EmelianovaKP.Sprint7.Project.V2.Lib;

namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_EKP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_EKP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void buttonInfo_EKP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        DataService ds = new DataService();

        int rows;
        int columns;
        string openFilePath;

        private void buttonOpenFile_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_EKP.ShowDialog();
                openFilePath = openFileDialogTask_EKP.FileName;

                string[,] arrayValues = ds.GetDataBase(openFilePath, ref rows, ref columns);
                buttonDelete_EKP.Enabled = true;
                buttonEdit_EKP.Enabled = true;
                buttonStatistic_EKP.Visible = true;

                dataGridViewMain_EKP.ColumnCount = columns;
                dataGridViewMain_EKP.RowCount = rows;

                dataGridViewMain_EKP.Columns[0].HeaderText = "Идентификатор";
                dataGridViewMain_EKP.Columns[1].HeaderText = "Название";
                dataGridViewMain_EKP.Columns[2].HeaderText = "Адрес";
                dataGridViewMain_EKP.Columns[3].HeaderText = "Номер телефона";
                dataGridViewMain_EKP.Columns[4].HeaderText = "Капитал владельца";

                for (int i = 0; i < columns; ++i)
                {
                    dataGridViewMain_EKP.Columns[i].Width = 132;
                }


                dataGridViewMain_EKP.Rows[0].ReadOnly = true;
                dataGridViewMain_EKP.Columns[0].ReadOnly = true;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewMain_EKP.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                buttonDelete_EKP.Visible = true;
                buttonEdit_EKP.Visible = true;
                buttonAdd_EKP.Visible = true;
                buttonSearch_EKP.Visible = true;
                buttonSaveFile_EKP.Enabled = true;
            }
            catch
            {

            }
        }

        private void buttonDelete_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_EKP.CurrentRow.Index >= 0)
                {
                    int index = dataGridViewMain_EKP.CurrentRow.Index;
                    dataGridViewMain_EKP.Rows.Remove(dataGridViewMain_EKP.Rows[index]);
                    if (dataGridViewMain_EKP.Rows.Count == 1)
                    {
                        dataGridViewMain_EKP.Rows.Clear();
                    }
                }
                if (dataGridViewMain_EKP.Rows.Count <= 1)
                {
                    buttonDelete_EKP.Enabled = false;
                    buttonEdit_EKP.Enabled = false;
                }
                if (dataGridViewMain_EKP.Rows.Count > 1)
                {
                    buttonDelete_EKP.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка Удаления", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_EKP_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }

        private void buttonEdit_EKP_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewMain_EKP.CurrentRow.Index;
                FormEdit rowData = new FormEdit(this);
                rowData.textBoxNumber_EKP.Text = dataGridViewMain_EKP.Rows[index].Cells[0].Value.ToString();
                rowData.textBoxName_EKP.Text = dataGridViewMain_EKP.Rows[index].Cells[1].Value.ToString();
                rowData.textBoxAddress_EKP.Text = dataGridViewMain_EKP.Rows[index].Cells[2].Value.ToString();
                rowData.textBoxPhoneNumber_EKP.Text = dataGridViewMain_EKP.Rows[index].Cells[3].Value.ToString();
                rowData.textBoxOwnersCapital_EKP.Text = dataGridViewMain_EKP.Rows[index].Cells[4].Value.ToString();
                rowData.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка редактирования!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_EKP_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();
        }

        private void buttonSaveFile_EKP_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_EKP.FileName = "StoreBase.csv";
            saveFileDialogTask_EKP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_EKP.ShowDialog();

            string path = saveFileDialogTask_EKP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_EKP.RowCount;
            int columns = dataGridViewMain_EKP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_EKP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_EKP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInstruction forminst = new FormInstruction();
            forminst.ShowDialog();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatistic_EKP_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic(this);
            formStatistic.ShowDialog();
        }
    }
}
