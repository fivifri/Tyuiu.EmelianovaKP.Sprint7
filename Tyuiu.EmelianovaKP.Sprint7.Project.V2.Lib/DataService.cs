﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public string[,] GetDataBase(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }
            return array;
        }

        public string[,] LoadFromFileData(string filePath, ref int rows, ref int columns)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        public int SumCapital(ref int[] ArrayCapital)
        {
            return ArrayCapital.Sum();
        }

        public int MinCapital(ref int[] ArrayCapital)
        {
            return ArrayCapital.Min();
        }

        public int MaxCapital(ref int[] ArrayCapital)
        {
            return ArrayCapital.Max();
        }

        public int MeanCapital(ref int[] ArrayCapital)
        {
            return SumCapital(ref ArrayCapital) / ArrayCapital.Length;
        }
    }
}