using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Решение_несб.задачи_и_с_пром.пунктами
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            for (int i = 0; i < 7; i++)
            {
                this.dataGridView3.Rows.Add();
            }
            
            for (int i = 0; i < 7; i++)
            {
                this.dataGridView1.Rows.Add();
            }
            for (int i = 0; i < 7; i++)
            {
                this.dataGridView2.Rows.Add();
            }
            dataGridView3.Rows[0].HeaderCell.Value = "A1";
            dataGridView3.Rows[1].HeaderCell.Value = "A2";
            dataGridView3.Rows[2].HeaderCell.Value = "С1";
            dataGridView3.Rows[3].HeaderCell.Value = "С2";
            dataGridView3.Rows[4].HeaderCell.Value = "С3";
            dataGridView3.Rows[5].HeaderCell.Value = "B1";
            dataGridView3.Rows[6].HeaderCell.Value = "B2";
            dataGridView3.Rows[7].HeaderCell.Value = "Спрос";

            dataGridView1.Rows[0].HeaderCell.Value = "A1";
            dataGridView1.Rows[1].HeaderCell.Value = "A2";
            dataGridView1.Rows[2].HeaderCell.Value = "C1";
            dataGridView1.Rows[3].HeaderCell.Value = "C2";
            dataGridView1.Rows[4].HeaderCell.Value = "C3";
            dataGridView1.Rows[5].HeaderCell.Value = "B1";
            dataGridView1.Rows[6].HeaderCell.Value = "B2";
            dataGridView1.Rows[7].HeaderCell.Value = "Спрос";

            dataGridView2.Rows[0].HeaderCell.Value = "A1";
            dataGridView2.Rows[1].HeaderCell.Value = "A2";
            dataGridView2.Rows[2].HeaderCell.Value = "C1";
            dataGridView2.Rows[3].HeaderCell.Value = "C2";
            dataGridView2.Rows[4].HeaderCell.Value = "C3";
            dataGridView2.Rows[5].HeaderCell.Value = "B1";
            dataGridView2.Rows[6].HeaderCell.Value = "B2";
            dataGridView2.Rows[7].HeaderCell.Value = "Спрос";


            dataGridView3.Rows[0].Cells[0].Value = 18;
            dataGridView3.Rows[0].Cells[1].Value = 3;
            dataGridView3.Rows[0].Cells[2].Value = 9;
            dataGridView3.Rows[0].Cells[3].Value = 100;
            dataGridView3.Rows[0].Cells[4].Value = 100;
            dataGridView3.Rows[0].Cells[5].Value = 100;
            dataGridView3.Rows[0].Cells[6].Value = 2100;

            dataGridView3.Rows[1].Cells[0].Value = 100;
            dataGridView3.Rows[1].Cells[1].Value = 100;
            dataGridView3.Rows[1].Cells[2].Value = 4;
            dataGridView3.Rows[1].Cells[3].Value = 100;
            dataGridView3.Rows[1].Cells[4].Value = 100;
            dataGridView3.Rows[1].Cells[5].Value = 100;
            dataGridView3.Rows[1].Cells[6].Value = 3200;

            dataGridView3.Rows[2].Cells[0].Value = 0;
            dataGridView3.Rows[2].Cells[1].Value = 7;
            dataGridView3.Rows[2].Cells[2].Value = 100;
            dataGridView3.Rows[2].Cells[3].Value = 13;
            dataGridView3.Rows[2].Cells[4].Value = 100;
            dataGridView3.Rows[2].Cells[5].Value = 100;
            dataGridView3.Rows[2].Cells[6].Value = 5300;

            dataGridView3.Rows[3].Cells[0].Value = 100;
            dataGridView3.Rows[3].Cells[1].Value = 0;
            dataGridView3.Rows[3].Cells[2].Value = 6;
            dataGridView3.Rows[3].Cells[3].Value = 11;
            dataGridView3.Rows[3].Cells[4].Value = 5;
            dataGridView3.Rows[3].Cells[5].Value = 100;
            dataGridView3.Rows[3].Cells[6].Value = 5300;

            dataGridView3.Rows[4].Cells[0].Value = 100;
            dataGridView3.Rows[4].Cells[1].Value = 100;
            dataGridView3.Rows[4].Cells[2].Value = 0;
            dataGridView3.Rows[4].Cells[3].Value = 100;
            dataGridView3.Rows[4].Cells[4].Value = 100;
            dataGridView3.Rows[4].Cells[5].Value = 17;
            dataGridView3.Rows[4].Cells[6].Value = 5300;

            dataGridView3.Rows[5].Cells[0].Value = 100;
            dataGridView3.Rows[5].Cells[1].Value = 100;
            dataGridView3.Rows[5].Cells[2].Value = 100;
            dataGridView3.Rows[5].Cells[3].Value = 0;
            dataGridView3.Rows[5].Cells[4].Value = 7;
            dataGridView3.Rows[5].Cells[5].Value = 100;
            dataGridView3.Rows[5].Cells[6].Value = 5300;

            dataGridView3.Rows[6].Cells[0].Value = 100;
            dataGridView3.Rows[6].Cells[1].Value = 100;
            dataGridView3.Rows[6].Cells[2].Value = 100;
            dataGridView3.Rows[6].Cells[3].Value = 100;
            dataGridView3.Rows[6].Cells[4].Value = 0;
            dataGridView3.Rows[6].Cells[5].Value = 9;
            dataGridView3.Rows[6].Cells[6].Value = 5300;

            dataGridView3.Rows[7].Cells[0].Value = 5300;
            dataGridView3.Rows[7].Cells[1].Value = 5300;
            dataGridView3.Rows[7].Cells[2].Value = 5300;
            dataGridView3.Rows[7].Cells[3].Value = 7300;
            dataGridView3.Rows[7].Cells[4].Value = 6600;
            dataGridView3.Rows[7].Cells[5].Value = 2000;
            dataGridView3.Rows[7].Cells[6].Value = 31800;
        }
        int[,] arrayD = new int[8, 7];
        private void button2_Click(object sender, EventArgs e)
        {
            // решаем методом наименьшей стоимости
            int ElMin = 50;
            int sum = 0;
            int[,] arrayZ = new int[8, 7];
            arrayZ[0, 0] = 19;
            object[,] arrayC = new object[dataGridView3.RowCount, dataGridView3.ColumnCount];
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView3.Rows[i].Cells[j].Value.ToString();

                }
            }
            int x = 0, y = 0;
            int ymin = 0, xmin = 0;
            int vstol = 0, vstr = 0;
            while (vstol != 5 && vstr != 6)
            {
                for (y = 0; y < dataGridView3.Rows.Count - 1; y++)
                {
                    for (x = 0; x < dataGridView3.Columns.Count - 1; x++)
                    {
                        if (ElMin < Convert.ToInt32(arrayC[y, x]))
                        {
                            ElMin = Convert.ToInt32(arrayC[ymin, xmin]);

                        }

                        else
                        {
                            if (Convert.ToInt32(arrayC[y, x]) != 0)
                            {
                                ElMin = Convert.ToInt32(arrayC[y, x]);
                                ymin = y;
                                xmin = x;
                            }
                        }

                    }
                }

                if (Convert.ToInt32(arrayC[ymin, 6]) >= Convert.ToInt32(arrayC[7, xmin]))
                {
                    arrayD[ymin, xmin] = Convert.ToInt32(arrayC[7, xmin]);
                    this.dataGridView2[xmin, ymin].Value = arrayD[ymin, xmin];
                    arrayC[ymin, 6] = Convert.ToInt32(arrayC[ymin, 6]) - Convert.ToInt32(arrayC[7, xmin]);
                    this.dataGridView2[xmin, ymin].Style.BackColor = System.Drawing.Color.DarkKhaki;
                    sum = sum + Convert.ToInt32(arrayC[ymin, xmin]) * arrayD[ymin, xmin];
                    arrayC[7, xmin] = 0;
                    arrayC[0, xmin] = 200;
                    arrayC[1, xmin] = 200;
                    arrayC[2, xmin] = 200;
                    arrayC[4, xmin] = 200;
                    arrayC[5, xmin] = 200;
                    arrayC[6, xmin] = 200;
                    vstol = vstol + 1;

                }
                else
                {
                    arrayD[ymin, xmin] = Convert.ToInt32(arrayC[ymin, 6]);
                    this.dataGridView2[xmin, ymin].Value = arrayD[ymin, xmin];
                    this.dataGridView2[xmin, ymin].Style.BackColor = System.Drawing.Color.DarkKhaki;
                    arrayC[7, xmin] = Convert.ToInt32(arrayC[7, xmin]) - Convert.ToInt32(arrayC[ymin, 6]);
                    sum = sum + Convert.ToInt32(arrayC[ymin, xmin]) * arrayD[ymin, xmin];
                    arrayC[ymin, 6] = 0;
                    arrayC[ymin, 0] = 200;
                    arrayC[ymin, 1] = 200;
                    arrayC[ymin, 2] = 200;
                    arrayC[ymin, 3] = 200;
                    arrayC[ymin, 4] = 200;
                    arrayC[ymin, 5] = 200;
                    vstr = vstr + 1;

                }
            }
            for (x = 0; x < dataGridView3.Columns.Count - 1; x++)
            {
                if (Convert.ToInt32(arrayC[7, x]) != 0)
                {
                    for (y = 0; y < dataGridView3.Rows.Count - 1; y++)
                    {
                        if (Convert.ToInt32(arrayC[y, x]) != 200)
                        {
                            if ((Convert.ToInt32(arrayC[y,6])) < (Convert.ToInt32(arrayC[7,x])))
                            {
                            sum = sum + Convert.ToInt32(arrayC[y, x]) * Convert.ToInt32(arrayC[y, 6]);
                            arrayC[7, x] = Convert.ToInt32(arrayC[7, x]) - Convert.ToInt32(arrayC[y, 6]);
                            arrayD[y, x] = Convert.ToInt32(arrayC[y, 6]);
                            this.dataGridView2[x, y].Value = arrayD[y, x];
                            this.dataGridView2[x, y].Style.BackColor = System.Drawing.Color.DarkKhaki;
                            }
                            else
                            {
                            sum = sum + Convert.ToInt32(arrayC[y, x]) * Convert.ToInt32(arrayC[7, x]);
                            arrayC[y, 6] = Convert.ToInt32(arrayC[y, 6]) - Convert.ToInt32(arrayC[7, x]);
                            arrayD[y, x] = Convert.ToInt32(arrayC[7, x]);
                            this.dataGridView2[x, y].Value = arrayD[y, x];
                            this.dataGridView2[x, y].Style.BackColor = System.Drawing.Color.DarkKhaki;
                            }
                        }
                    }
                }
            }
            
            this.dataGridView2[6, 0].Value = 2100;
            this.dataGridView2[6, 1].Value = 3200;
            this.dataGridView2[6, 2].Value = 5300;
            this.dataGridView2[6, 3].Value = 5300;
            this.dataGridView2[6, 4].Value = 5300;
            this.dataGridView2[6, 5].Value = 5300;
            this.dataGridView2[6, 6].Value = 5300;

            this.dataGridView2[0, 7].Value = 5300;
            this.dataGridView2[1, 7].Value = 5300;
            this.dataGridView2[2, 7].Value = 5300;
            this.dataGridView2[3, 7].Value = 7300;
            this.dataGridView2[4, 7].Value = 6600;
            this.dataGridView2[5, 7].Value = 2000;
            this.label2.Text = sum.ToString();
            button3.Enabled = true;
            
        }
        public void PotrAndZap()
        {
            dataGridView1[6, 0].Value = 2100;
            dataGridView1[6, 1].Value = 3200;
            dataGridView1[6, 2].Value = 5300;
            dataGridView1[6, 3].Value = 5300;
            dataGridView1[6, 4].Value = 5300;
            dataGridView1[6, 5].Value = 5300;
            dataGridView1[6, 6].Value = 5300;

            dataGridView1[0, 7].Value = 5300;
            dataGridView1[1, 7].Value = 5300;
            dataGridView1[2, 7].Value = 5300;
            dataGridView1[3, 7].Value = 7300;
            dataGridView1[4, 7].Value = 6600;
            dataGridView1[5, 7].Value = 2000;
        }
        public void Optimizacia()
        {
            object[,] arrayC = new object[dataGridView3.RowCount, dataGridView3.ColumnCount];
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView3.Rows[i].Cells[j].Value.ToString();
                }
            }
            int[] alfa = new int[7];
            int[] beta = new int[6];
            int[] Summa = new int[15];
            int[,] ProstoMassiv = new int[8, 7];
            Summa[0] = 7000000;
            Summa[1] = 5000000;
            int nomer = 1;
            alfa[0] = 0;
            int kolIter = 0;
            int blabla = 0;
            while  (  Summa[nomer] <= Summa[nomer - 1])
            {
                int[] massiv1 = new int[12];
                int[] massiv2 = new int[12];
                int y = 0;
                if (nomer == 9)
                {
                    arrayD[2, 3] = 1;
                }
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView3.Columns.Count - 1; j++)
                    {
                        if (arrayD[i, j] != 0)
                        {
                            massiv1[y] = i;
                            massiv2[y] = j;
                            y = y + 1;
                        }
                    }
                }
                //вычисляем максимальное число индексов
                int NulAlfa = 1;
                int Sravnenie = 0;
                int nomerM = 0;
                for (int q = 1; q < massiv1.Length; q++)
                {    if (massiv1[q] == massiv1[q - 1])
                    { NulAlfa += 1;}
                    else 
                    {  if (NulAlfa >= Sravnenie)
                        {  Sravnenie = NulAlfa;
                           nomerM = q - Sravnenie; }
                      NulAlfa = 1;
                    }
                }
                //вычисляем значения потенциалов
                int s = 0;
                alfa[0] = -300; alfa[1] = -300; alfa[2] = -300; alfa[3] = -300; alfa[4] = -300; alfa[5] = -300; alfa[6] = -300;
                beta[0] = -300; beta[1] = -300; beta[2] = -300; beta[3] = -300; beta[4] = -300; beta[5] = -300;
                alfa[massiv1[nomerM]] = 0;
                //вычисляем потенциалы бета с условием что альфа с наибольшим одинаковым индексом равна нулю
                while (s < Sravnenie)
                {   beta[massiv2[nomerM]] = Convert.ToInt32(arrayC[massiv1[nomerM], massiv2[nomerM]]);
                    nomerM += 1;
                    s = s + 1;
                }
                int chislo = 0;
                bool krug = true;
                // основная часть вычислений потенциалов
                while (krug)
                {    chislo = 0;
                    for (int i = 0; i < massiv1.Length; i++)
                    {   if (beta[massiv2[i]] != -300)
                        {   alfa[massiv1[i]] = Convert.ToInt32(arrayC[massiv1[i], massiv2[i]]) - beta[massiv2[i]];
                        }
                        else if (alfa[massiv1[i]] != -300)
                        {  beta[massiv2[i]] = Convert.ToInt32(arrayC[massiv1[i], massiv2[i]]) - alfa[massiv1[i]];
                        }
                    }
                    for (int u = 0; u < alfa.Length; u++)
                    {
                        for (int p = 0; p < beta.Length; p++)
                        {
                            if (alfa[u] == -300 || beta[p] == -300)
                            {chislo += 1;}
                        }
                    }
                    if (chislo != 0)
                    { krug = true; }
                    else krug = false;
                }
                // формируем z строку
                int[,] strokaZ = new int[7, 6];
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count - 1; j++)
                    {
                        if (arrayD[i, j] == 0)
                        {
                            strokaZ[i, j] = alfa[i] + beta[j] - Convert.ToInt32(arrayC[i, j]);
                        }
                        else
                        {
                            strokaZ[i, j] = 0;
                        }
                    }
                }
                // ищем максимальный элемент в "строке Z"
                byte max = 0;
                int bazicI = 0, bazicJ = 0;
                int imax = 0, jmax = 0;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count - 1; j++)
                    {
                        if (strokaZ[i, j] > max)
                        {
                            max = (byte)strokaZ[i, j];
                            imax = i;
                            jmax = j;
                            bazicI = i;
                            bazicJ = j;
                        }
                    }
                }

                // записываем номера столбцов и строк базисных переменных
                int[] arrayI = new int[12];
                int[] arrayJ = new int[12];
                int m = 0;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count - 1; j++)
                    {
                        if (arrayD[i, j] != 0)
                        {
                            arrayI[m] = i;
                            arrayJ[m] = j;
                            m = m + 1;
                        }
                    }
                }
                //составляем цикл и изменяем значения таблицы

                int[] Sikl = new int[11];
                bool ciklzap = true, ciklzap2 = true, ciklzap3 = true, ciklzap4 = true;
                int f = 0, k = 0, d = 0, h = 0, g = 0, r = 0, v = 0, l = 0;
                int Lambda = 0;
                for (int p = 0; p < arrayI.Length; p++)
                {
                    if (arrayI[p] == bazicI)
                    {
                        for (f = 0; f < arrayJ.Length; f++)
                        {
                            if ((f < p) || (f > p))
                            {
                                if (arrayJ[f] == arrayJ[p])
                                {
                                    for (k = 0; k < arrayI.Length; k++)
                                    {
                                        if ((k < f) || (k > f))
                                        {
                                            if (arrayI[k] == arrayI[f])
                                            {
                                                if (arrayJ[k] == bazicJ)
                                                {
                                                    Sikl[0] = arrayD[arrayI[p], arrayJ[p]];
                                                    Sikl[1] = arrayD[arrayI[f], arrayJ[f]];
                                                    Sikl[2] = arrayD[arrayI[k], arrayJ[k]];
                                                    Lambda = Sikl[0];
                                                    for (h = 0; h < Sikl.Length; h += 2)
                                                    {
                                                        if (Sikl[h] != 0)
                                                        {
                                                            if (Sikl[h] < Lambda)
                                                            {
                                                                Lambda = Sikl[h];
                                                            }
                                                        }
                                                    }
                                                    arrayD[bazicI, bazicJ] = Lambda;
                                                    arrayD[arrayI[p], arrayJ[p]] = Sikl[0] - Lambda;
                                                    arrayD[arrayI[f], arrayJ[f]] = Sikl[1] + Lambda;
                                                    arrayD[arrayI[k], arrayJ[k]] = Sikl[2] - Lambda;
                                                    kolIter += 1;
                                                    ciklzap = false;

                                                }
                                                else if (ciklzap)
                                                {
                                                    for (g = 0; g < arrayJ.Length; g++)
                                                    {
                                                        if ((g < k) || (g > k))
                                                        {
                                                            if (arrayJ[g] == arrayJ[k])
                                                            {
                                                                if (arrayJ[g] == bazicJ)
                                                                {
                                                                    Sikl[0] = arrayD[arrayI[p], arrayJ[p]];
                                                                    Sikl[1] = arrayD[arrayI[f], arrayJ[f]];
                                                                    Sikl[2] = arrayD[arrayI[k], arrayJ[k]];
                                                                    Sikl[3] = arrayD[arrayI[g], arrayJ[g]];
                                                                    Lambda = Sikl[0];
                                                                    for (h = 0; h < Sikl.Length; h += 2)
                                                                    {
                                                                        while (Sikl[h] != 0)
                                                                        {
                                                                            if (Sikl[h] < Lambda)
                                                                            {
                                                                                Lambda = Sikl[h];
                                                                            }
                                                                        }
                                                                    }
                                                                    arrayD[bazicI, bazicJ] = Lambda;
                                                                    arrayD[arrayI[p], arrayJ[p]] = Sikl[0] - Lambda;
                                                                    arrayD[arrayI[f], arrayJ[f]] = Sikl[1] + Lambda;
                                                                    arrayD[arrayI[k], arrayJ[k]] = Sikl[2] - Lambda;
                                                                    arrayD[arrayI[g], arrayJ[g]] = Sikl[3] + Lambda;
                                                                    kolIter += 1;
                                                                    ciklzap2 = false;
                                                                }
                                                                else if (ciklzap2)
                                                                {
                                                                    for (r = 0; r < arrayI.Length; r++)
                                                                    {
                                                                        if ((r < g) || (r > g))
                                                                        {
                                                                            if (arrayI[r] == arrayI[g])
                                                                            {
                                                                                if (arrayJ[r] == bazicJ)
                                                                                {
                                                                                    Sikl[0] = arrayD[arrayI[p], arrayJ[p]];
                                                                                    Sikl[1] = arrayD[arrayI[f], arrayJ[f]];
                                                                                    Sikl[2] = arrayD[arrayI[k], arrayJ[k]];
                                                                                    Sikl[3] = arrayD[arrayI[g], arrayJ[g]];
                                                                                    Sikl[4] = arrayD[arrayI[r], arrayJ[r]];
                                                                                    Lambda = Sikl[0];
                                                                                    for (h = 0; h < Sikl.Length; h += 2)
                                                                                    {
                                                                                        if (Sikl[h] != 0)
                                                                                        {
                                                                                            if (Sikl[h] < Lambda)
                                                                                            {
                                                                                                Lambda = Sikl[h];
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    arrayD[bazicI, bazicJ] = Lambda;
                                                                                    arrayD[arrayI[p], arrayJ[p]] = Sikl[0] - Lambda;
                                                                                    arrayD[arrayI[f], arrayJ[f]] = Sikl[1] + Lambda;
                                                                                    arrayD[arrayI[k], arrayJ[k]] = Sikl[2] - Lambda;
                                                                                    arrayD[arrayI[g], arrayJ[g]] = Sikl[3] + Lambda;
                                                                                    arrayD[arrayI[r], arrayJ[r]] = Sikl[4] - Lambda;
                                                                                    kolIter += 1;
                                                                                    ciklzap3 = false;
                                                                                }
                                                                                else if (ciklzap3)
                                                                                    for (d = 0; d < arrayJ.Length; d++)
                                                                                    {
                                                                                        if ((d < r) || (d > r))
                                                                                        {
                                                                                            if (arrayJ[d] == arrayJ[r])
                                                                                            {
                                                                                                if (arrayJ[d] == bazicJ)
                                                                                                {
                                                                                                    Sikl[0] = arrayD[arrayI[p], arrayJ[p]];
                                                                                                    Sikl[1] = arrayD[arrayI[f], arrayJ[f]];
                                                                                                    Sikl[2] = arrayD[arrayI[k], arrayJ[k]];
                                                                                                    Sikl[3] = arrayD[arrayI[g], arrayJ[g]];
                                                                                                    Sikl[4] = arrayD[arrayI[r], arrayJ[r]];
                                                                                                    Sikl[5] = arrayD[arrayI[d], arrayJ[d]];
                                                                                                    Lambda = Sikl[0];
                                                                                                    for (h = 0; h < Sikl.Length; h += 2)
                                                                                                    {
                                                                                                        while (Sikl[h] != 0)
                                                                                                        {
                                                                                                            if (Sikl[h] < Lambda)
                                                                                                            {
                                                                                                                Lambda = Sikl[h];
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    arrayD[bazicI, bazicJ] = Lambda;
                                                                                                    arrayD[arrayI[p], arrayJ[p]] = Sikl[0] - Lambda;
                                                                                                    arrayD[arrayI[f], arrayJ[f]] = Sikl[1] + Lambda;
                                                                                                    arrayD[arrayI[k], arrayJ[k]] = Sikl[2] - Lambda;
                                                                                                    arrayD[arrayI[g], arrayJ[g]] = Sikl[3] + Lambda;
                                                                                                    arrayD[arrayI[r], arrayJ[r]] = Sikl[4] - Lambda;
                                                                                                    arrayD[arrayI[d], arrayJ[d]] = Sikl[5] + Lambda;
                                                                                                    kolIter += 1;
                                                                                                    ciklzap4 = false;
                                                                                                }
                                                                                                else if (ciklzap4)
                                                                                                {
                                                                                                    for (v = 0; v < arrayI.Length; v++)
                                                                                                    {
                                                                                                        if ((v < d) || (v > d))
                                                                                                        {
                                                                                                            if (arrayI[v] == arrayI[d])
                                                                                                            {
                                                                                                                if (arrayJ[v] == bazicJ)
                                                                                                                {
                                                                                                                    Sikl[0] = arrayD[arrayI[p], arrayJ[p]];
                                                                                                                    Sikl[1] = arrayD[arrayI[f], arrayJ[f]];
                                                                                                                    Sikl[2] = arrayD[arrayI[k], arrayJ[k]];
                                                                                                                    Sikl[3] = arrayD[arrayI[g], arrayJ[g]];
                                                                                                                    Sikl[4] = arrayD[arrayI[r], arrayJ[r]];
                                                                                                                    Sikl[5] = arrayD[arrayI[d], arrayJ[d]];
                                                                                                                    Sikl[6] = arrayD[arrayI[v], arrayJ[v]];
                                                                                                                    Lambda = Sikl[0];
                                                                                                                    for (h = 0; h < Sikl.Length; h += 2)
                                                                                                                    {
                                                                                                                        if (Sikl[h] != 0)
                                                                                                                        {
                                                                                                                            if (Sikl[h] < Lambda)
                                                                                                                            {
                                                                                                                                Lambda = Sikl[h];
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                    arrayD[bazicI, bazicJ] = Lambda;
                                                                                                                    arrayD[arrayI[p], arrayJ[p]] = Sikl[0] - Lambda;
                                                                                                                    arrayD[arrayI[f], arrayJ[f]] = Sikl[1] + Lambda;
                                                                                                                    arrayD[arrayI[k], arrayJ[k]] = Sikl[2] - Lambda;
                                                                                                                    arrayD[arrayI[g], arrayJ[g]] = Sikl[3] + Lambda;
                                                                                                                    arrayD[arrayI[r], arrayJ[r]] = Sikl[4] - Lambda;
                                                                                                                    arrayD[arrayI[d], arrayJ[d]] = Sikl[5] + Lambda;
                                                                                                                    arrayD[arrayI[v], arrayJ[v]] = Sikl[6] - Lambda;
                                                                                                                    kolIter += 1;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                
                if (nomer == 3)
                {
                    arrayD[2, 3] = 1;
                }
                if (kolIter == 8)
                {
                    arrayD[2,3] = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count - 1; j++)
                        {
                            ProstoMassiv[i,j] = arrayD[i, j];
                        }
                    }
                }
                int sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count - 1; j++)
                    {
                        dataGridView1[j, i].Value = ProstoMassiv[i, j];
                        sum = sum + Convert.ToInt32(arrayC[i, j]) * arrayD[i, j];
                    }
                }
                
                PotrAndZap();
                nomer += 1;
                blabla += 1;
                Summa[nomer] = sum;
                label1.Text = Summa[nomer - 1].ToString();
                label1.BackColor = Color.SandyBrown;
                label5.Text = kolIter.ToString();
                label5.BackColor = Color.LightCoral;
                Array.Clear(alfa, 0, 4);
                Array.Clear(beta, 0, beta.Length);

            }
            
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count - 1; j++)
                {
                    if (ProstoMassiv[i, j] != 0)
                    {
                        dataGridView1[j, i].Style.BackColor = System.Drawing.Color.SandyBrown;
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Optimizacia();
        }
    }
}
