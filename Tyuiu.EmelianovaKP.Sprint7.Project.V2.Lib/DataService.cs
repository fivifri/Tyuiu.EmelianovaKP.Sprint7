using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.EmelianovaKP.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public string[,] GetDataBase(string path, ref int rows, ref int columns)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

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
