﻿using System;
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
                buttonStatistic_EKP.Visible = true;

                dataGridViewMain_EKP.ColumnCount = columns;
                dataGridViewMain_EKP.RowCount = rows - 1;

                for (int i = 0; i < columns; ++i)
                {
                    dataGridViewMain_EKP.Columns[i].HeaderText = arrayValues[0, i];
                }

                for (int i = 0; i < columns; ++i)
                {
                    dataGridViewMain_EKP.Columns[i].Width = 132;
                }


                for (int r = 1; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewMain_EKP.Rows[r - 1].Cells[c].Value = arrayValues[r, c];
                    }
                }

                buttonDelete_EKP.Visible = true;
                buttonAdd_EKP.Visible = true;
                buttonSort_EKP.Visible = true;
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
            this.dataGridViewMain_EKP.Rows.Add();
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
            FormChooseStatistic formChooseStatistic = new FormChooseStatistic(this);
            formChooseStatistic.ShowDialog();
        }

        private void buttonSort_EKP_Click(object sender, EventArgs e)
        {
            FormSort formSort = new FormSort(this);
            formSort.ShowDialog();
        }
    }
}
