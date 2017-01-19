using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Решение_задачи_коммивояжера
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void MethodVetveiGranic() 
        {
           //задаем исходную матрицу
            int[,] matrica = new int[5, 5];
            matrica[0, 0] = 200; matrica[0, 1] = 4; matrica[0, 2] = 12; matrica[0, 3] = 14; matrica[0, 4] = 4;
            matrica[1, 0] = 3; matrica[1, 1] = 200; matrica[1, 2] = 12; matrica[1, 3] = 10; matrica[1, 4] = 10;
            matrica[2, 0] = 12; matrica[2, 1] = 4; matrica[2, 2] = 200; matrica[2, 3] = 9; matrica[2, 4] = 5;
            matrica[3, 0] = 3; matrica[3, 1] = 11; matrica[3, 2] = 11; matrica[3, 3] = 200; matrica[3, 4] = 9;
            matrica[4, 0] = 10; matrica[4, 1] = 3; matrica[4, 2] = 1; matrica[4, 3] = 3; matrica[4, 4] = 200;
            //задаем матрицу для минимума по строкам и находим минимумы по строкам
            int[] MinStroka = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int elmin = 300;
                for (int j = 0; j < 5; j++)
               {

                 if (matrica[i,j] < elmin)
                   {
                       elmin = matrica[i, j];  
                     MinStroka[i] = matrica[i, j];
                   }
                }
            }
            //редукция по строкам
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrica[i, j] != 200)
                    {
                        matrica[i, j] = matrica[i, j] - MinStroka[i];
                    }
                }
            }
            //находим минимумы по столбцам
            int[] MinStolbec = new int[5];
            for (int j = 0; j < 5; j++)
            {
                int elmin = 300;
                for (int i = 0; i < 5; i++)
                {

                    if (matrica[i, j] < elmin)
                    {
                        elmin = matrica[i, j];
                        MinStolbec[j] = matrica[i, j];
                    }
                }
            }
            //редукция по столбцам
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (matrica[i, j] != 200)
                    {
                        matrica[i, j] = matrica[i, j] - MinStolbec[j];
                    }
                }
            }
            // определяем количество нулей
            int kolNul = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (matrica[i, j] == 0)
                    {
                        kolNul += 1;
                    }
                }
            }
            //находим оценки
            int nomer = 0;
            int[] NulStr = new int[kolNul];
            int[] NulStolb = new int[kolNul];
            int ElMinStroka =  100, ElMinStolb = 100;
            int nomerminstolb = 0, nomerminstr = 0;
            int[] Ocenki = new int[kolNul];
            int y = 0;
            int[] NomerGorodovStr = new int[5];
            int[] NomerGorodovStolb = new int[5];
            /*
            for (int t = 0; t < NomerGorodovStr.Length; t++)
            {
                NomerGorodovStr[t] = t + 1;
                NomerGorodovStolb[t] = t + 1;
            }
            */
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrica[i, j] == 0)
                    {
                        NulStr[nomer] = i;
                        NulStolb[nomer] = j;
                        ElMinStolb = 100; ElMinStroka = 100;                   
                            for (y = 0; y < 5; y++)
                            {
                                if (y < j || y > j)
                                {
                                    if (matrica[i, y] < ElMinStroka)
                                    {
                                        ElMinStroka = matrica[i, y];
                                        nomerminstolb = y;
                                    }
                                }
                            }
                        
                        for (int x = 0; x < 5; x++)
                        {
                            if (x < i || x > i)
                            {
                                if (matrica[x, j] < ElMinStolb)
                                {
                                    ElMinStolb = matrica[x, j];
                                    nomerminstr = x;
                                }
                            }
                        }
                        Ocenki[nomer] = matrica[i, nomerminstolb] + matrica[nomerminstr, j];
                        nomer += 1;
                    }
                }
            }
            // находим максимальную оценку
            int MaxOcenka = Ocenki[0];
            int NomerMaxOcenki = 0;
            for (int w = 0; w < Ocenki.Length; w++)
            {
                if (Ocenki[w] > MaxOcenka)
                {
                    MaxOcenka = Ocenki[w];
                    NomerMaxOcenki = w;
                }
            }
            int PutIz = 0, PutKuda = 0;
            int[] PutPoln = new int[6];
            PutIz = NulStr[NomerMaxOcenki] + 1;
            PutPoln[0] = NulStr[NomerMaxOcenki];
            PutKuda = NulStolb[NomerMaxOcenki] + 1;
            PutPoln[1] = NulStolb[NomerMaxOcenki];
            label3.Text = Convert.ToString(PutIz);
            label5.Text = Convert.ToString(PutKuda);
            matrica[NulStolb[NomerMaxOcenki], NulStr[NomerMaxOcenki]] = 200;
            // создаем новую матрицу меньшей размерности и записывываем туда значения из старой без одного столбца и строки
            int[,] matrica1 = new int[4, 4];
            int p = 0, s = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i < NulStr[NomerMaxOcenki] || i > NulStr[NomerMaxOcenki]) && (j < NulStolb[NomerMaxOcenki] || j > NulStolb[NomerMaxOcenki]))
                    {
                        matrica1[p, s] = matrica[i, j];
                        s += 1;
                        if (s == 4)
                        {
                            p += 1;
                            s = 0;
                        }
                        
                    }
                }
            }
            //задаем матрицу для минимума по строкам и находим минимумы по строкам
            int[] MinStroka1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int elmin = 300;
                for (int j = 0; j < 4; j++)
                {

                    if (matrica1[i, j] < elmin)
                    {
                        elmin = matrica1[i, j];
                        MinStroka1[i] = matrica1[i, j];
                    }
                }
            }
            //редукция по строкам
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrica1[i, j] != 200)
                    {
                        matrica1[i, j] = matrica1[i, j] - MinStroka1[i];
                    }
                }
            }
            //находим минимумы по столбцам
            int[] MinStolbec1 = new int[4];
            for (int j = 0; j < 4; j++)
            {
                int elmin = 300;
                for (int i = 0; i < 4; i++)
                {

                    if (matrica1[i, j] < elmin)
                    {
                        elmin = matrica1[i, j];
                        MinStolbec1[j] = matrica1[i, j];
                    }
                }
            }
            //редукция по столбцам
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (matrica1[i, j] != 200)
                    {
                        matrica1[i, j] = matrica1[i, j] - MinStolbec1[j];
                    }
                }
            }
            // определяем количество нулей
            kolNul = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (matrica1[i, j] == 0)
                    {
                        kolNul += 1;
                    }
                }
            }
            //находим оценки
            nomer = 0;
            int[] NulStr1 = new int[kolNul];
            int[] NulStolb1 = new int[kolNul];
            ElMinStroka = 100;
            ElMinStolb = 100;
            nomerminstolb = 0;
            nomerminstr = 0;
            int[] Ocenki1 = new int[kolNul];
            y = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrica1[i, j] == 0)
                    {
                        NulStr1[nomer] = i;
                        NulStolb1[nomer] = j;
                        ElMinStolb = 100; ElMinStroka = 100;
                        for (y = 0; y < 4; y++)
                        {
                            if (y < j || y > j)
                            {
                                if (matrica1[i, y] < ElMinStroka)
                                {
                                    ElMinStroka = matrica1[i, y];
                                    nomerminstolb = y;
                                }
                            }
                        }

                        for (int x = 0; x < 4; x++)
                        {
                            if (x < i || x > i)
                            {
                                if (matrica1[x, j] < ElMinStolb)
                                {
                                    ElMinStolb = matrica1[x, j];
                                    nomerminstr = x;
                                }
                            }
                        }
                        Ocenki1[nomer] = matrica1[i, nomerminstolb] + matrica1[nomerminstr, j];
                        nomer += 1;
                    }
                }
            }
            // находим максимальную оценку
            MaxOcenka = Ocenki1[0];
            NomerMaxOcenki = 0;
            for (int w = 0; w < Ocenki1.Length; w++)
            {
                if (Ocenki1[w] >= MaxOcenka)
                {
                    MaxOcenka = Ocenki1[w];
                    NomerMaxOcenki = w;
                }
            }
            PutIz = NulStr1[NomerMaxOcenki] + 1;
            PutKuda = NulStolb1[NomerMaxOcenki] + 1;
            label9.Text = Convert.ToString(PutIz);
            label10.Text = Convert.ToString(PutKuda);
            matrica1[0, 2] = 200;

            //МАТРИЦА 3 на 3
            // создаем новую матрицу меньшей размерности и записывываем туда значения из старой без одного столбца и строки
            int[,] matrica2 = new int[3, 3];
            p = 0; 
            s = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i < NulStr1[NomerMaxOcenki] || i > NulStr1[NomerMaxOcenki]) && (j < NulStolb1[NomerMaxOcenki] || j > NulStolb1[NomerMaxOcenki]))
                    {
                        matrica2[p, s] = matrica1[i, j];
                        s += 1;
                        if (s == 3)
                        {
                            p += 1;
                            s = 0;
                        }

                    }
                }
            }
            //задаем матрицу для минимума по строкам и находим минимумы по строкам
            int[] MinStroka2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int elmin = 300;
                for (int j = 0; j < 3; j++)
                {

                    if (matrica2[i, j] < elmin)
                    {
                        elmin = matrica2[i, j];
                        MinStroka2[i] = matrica2[i, j];
                    }
                }
            }
            //редукция по строкам
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrica2[i, j] != 200)
                    {
                        matrica2[i, j] = matrica2[i, j] - MinStroka2[i];
                    }
                }
            }
            //находим минимумы по столбцам
            int[] MinStolbec2 = new int[3];
            for (int j = 0; j < 3; j++)
            {
                int elmin = 300;
                for (int i = 0; i < 3; i++)
                {

                    if (matrica2[i, j] < elmin)
                    {
                        elmin = matrica2[i, j];
                        MinStolbec2[j] = matrica2[i, j];
                    }
                }
            }
            //редукция по столбцам
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (matrica2[i, j] != 200)
                    {
                        matrica2[i, j] = matrica2[i, j] - MinStolbec2[j];
                    }
                }
            }
            // определяем количество нулей
            kolNul = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (matrica2[i, j] == 0)
                    {
                        kolNul += 1;
                    }
                }
            }
            //находим оценки
            nomer = 0;
            int[] NulStr2 = new int[kolNul];
            int[] NulStolb2 = new int[kolNul];
            ElMinStroka = 100;
            ElMinStolb = 100;
            nomerminstolb = 0;
            nomerminstr = 0;
            int[] Ocenki2 = new int[kolNul];
            y = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrica2[i, j] == 0)
                    {
                        NulStr2[nomer] = i;
                        NulStolb2[nomer] = j;
                        ElMinStolb = 100; ElMinStroka = 100;
                        for (y = 0; y < 3; y++)
                        {
                            if (y < j || y > j)
                            {
                                if (matrica2[i, y] < ElMinStroka)
                                {
                                    ElMinStroka = matrica2[i, y];
                                    nomerminstolb = y;
                                }
                            }
                        }

                        for (int x = 0; x < 3; x++)
                        {
                            if (x < i || x > i)
                            {
                                if (matrica2[x, j] < ElMinStolb)
                                {
                                    ElMinStolb = matrica2[x, j];
                                    nomerminstr = x;
                                }
                            }
                        }
                        Ocenki2[nomer] = matrica2[i, nomerminstolb] + matrica2[nomerminstr, j];
                        nomer += 1;
                    }
                }
            }
            // находим максимальную оценку
            MaxOcenka = Ocenki2[0];
            NomerMaxOcenki = 0;
            for (int w = 0; w < Ocenki2.Length; w++)
            {
                if (Ocenki2[w] > MaxOcenka)
                {
                    MaxOcenka = Ocenki2[w];
                    NomerMaxOcenki = w;
                }
            }
            PutIz = NulStr2[NomerMaxOcenki] + 1;
            PutKuda = NulStolb2[NomerMaxOcenki] + 3;
            label10.Text = Convert.ToString(PutIz);
            label13.Text = Convert.ToString(PutKuda);
            label11.Text = Convert.ToString(2);

            int[,] IsxMatrica = new int[5, 5];
            IsxMatrica[0, 0] = 200; IsxMatrica[0, 1] = 4; IsxMatrica[0, 2] = 12; IsxMatrica[0, 3] = 14; IsxMatrica[0, 4] = 4;
            IsxMatrica[1, 0] = 3; IsxMatrica[1, 1] = 200; IsxMatrica[1, 2] = 12; IsxMatrica[1, 3] = 10; IsxMatrica[1, 4] = 10;
            IsxMatrica[2, 0] = 12; IsxMatrica[2, 1] = 4; IsxMatrica[2, 2] = 200; IsxMatrica[2, 3] = 9; IsxMatrica[2, 4] = 5;
            IsxMatrica[3, 0] = 3; IsxMatrica[3, 1] = 11; IsxMatrica[3, 2] = 11; IsxMatrica[3, 3] = 200; IsxMatrica[3, 4] = 9;
            IsxMatrica[4, 0] = 10; IsxMatrica[4, 1] = 3; IsxMatrica[4, 2] = 1; IsxMatrica[4, 3] = 3; IsxMatrica[4, 4] = 200;
            PutPoln[2] = 1;
            PutPoln[3] = NulStolb1[NomerMaxOcenki];
            PutPoln[4] = NulStr2[NomerMaxOcenki];
            PutPoln[5] = NulStolb2[NomerMaxOcenki] + 2;
            int Stoimost = 0;
            Stoimost = IsxMatrica[PutPoln[0], PutPoln[1]] + IsxMatrica[PutPoln[1], PutPoln[2]] + IsxMatrica[PutPoln[2], PutPoln[3]] + IsxMatrica[PutPoln[3], PutPoln[4]] + IsxMatrica[PutPoln[4], PutPoln[5]];
            label15.Text = Convert.ToString(Stoimost);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MethodVetveiGranic();
        }

        
    }
}
