using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Транспортная_логистика_ЛР2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void AddRow()
        {
            for (int i = 0; i < 4; i++)
            {
                this.dataGridView1.Rows.Add();
            }
            for (int i = 0; i < 4; i++)
            {
                this.dataGridView2.Rows.Add();
                this.dataGridView3.Rows.Add();
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            AddRow();

            dataGridView1.Rows[0].HeaderCell.Value = "A1";
            dataGridView1.Rows[1].HeaderCell.Value = "A2";
            dataGridView1.Rows[2].HeaderCell.Value = "A3";
            dataGridView1.Rows[3].HeaderCell.Value = "A4";
            dataGridView1.Rows[4].HeaderCell.Value = "Потребности";

            dataGridView2.Rows[0].HeaderCell.Value = "A1";
            dataGridView2.Rows[1].HeaderCell.Value = "A2";
            dataGridView2.Rows[2].HeaderCell.Value = "A3";
            dataGridView2.Rows[3].HeaderCell.Value = "A4";
            dataGridView2.Rows[4].HeaderCell.Value = "Потребности";

            dataGridView3.Rows[0].HeaderCell.Value = "A1";
            dataGridView3.Rows[1].HeaderCell.Value = "A2";
            dataGridView3.Rows[2].HeaderCell.Value = "A3";
            dataGridView3.Rows[3].HeaderCell.Value = "A4";
            dataGridView3.Rows[4].HeaderCell.Value = "Потребности";



            dataGridView1.Rows[0].Cells[0].Value = 19;
            dataGridView1.Rows[0].Cells[1].Value = 9;
            dataGridView1.Rows[0].Cells[2].Value = 12;
            dataGridView1.Rows[0].Cells[3].Value = 11;
            dataGridView1.Rows[0].Cells[4].Value = 16;
            dataGridView1.Rows[0].Cells[5].Value = 220;

            dataGridView1.Rows[1].Cells[0].Value = 12;
            dataGridView1.Rows[1].Cells[1].Value = 7;
            dataGridView1.Rows[1].Cells[2].Value = 4;
            dataGridView1.Rows[1].Cells[3].Value = 10;
            dataGridView1.Rows[1].Cells[4].Value = 16;
            dataGridView1.Rows[1].Cells[5].Value = 180;

            dataGridView1.Rows[2].Cells[0].Value = 11;
            dataGridView1.Rows[2].Cells[1].Value = 26;
            dataGridView1.Rows[2].Cells[2].Value = 16;
            dataGridView1.Rows[2].Cells[3].Value = 13;
            dataGridView1.Rows[2].Cells[4].Value = 8;
            dataGridView1.Rows[2].Cells[5].Value = 100;

            dataGridView1.Rows[3].Cells[0].Value = 10;
            dataGridView1.Rows[3].Cells[1].Value = 14;
            dataGridView1.Rows[3].Cells[2].Value = 11;
            dataGridView1.Rows[3].Cells[3].Value = 9;
            dataGridView1.Rows[3].Cells[4].Value = 12;
            dataGridView1.Rows[3].Cells[5].Value = 100;


            dataGridView1.Rows[4].Cells[0].Value = 100;
            dataGridView1.Rows[4].Cells[1].Value = 110;
            dataGridView1.Rows[4].Cells[2].Value = 70;
            dataGridView1.Rows[4].Cells[3].Value = 200;
            dataGridView1.Rows[4].Cells[4].Value = 120;
            dataGridView1.Rows[4].Cells[5].Value = 600;

        }
        public void PotrZapac1()
        {
            dataGridView2[5, 0].Value = 220;
            dataGridView2[5, 1].Value = 180;
            dataGridView2[5, 2].Value = 100;
            dataGridView2[5, 3].Value = 100;
            dataGridView2[5, 4].Value = 600;
            dataGridView2[4, 4].Value = 120;
            dataGridView2[3, 4].Value = 200;
            dataGridView2[2, 4].Value = 70;
            dataGridView2[1, 4].Value = 110;
            dataGridView2[0, 4].Value = 100;
        }
        public void PotrZapac2()
        {
            dataGridView3[5, 0].Value = 220;
            dataGridView3[5, 1].Value = 180;
            dataGridView3[5, 2].Value = 100;
            dataGridView3[5, 3].Value = 100;
            dataGridView3[5, 4].Value = 600;
            dataGridView3[4, 4].Value = 120;
            dataGridView3[3, 4].Value = 200;
            dataGridView3[2, 4].Value = 70;
            dataGridView3[1, 4].Value = 110;
            dataGridView3[0, 4].Value = 100;
        }
        int[,] arrayD = new int[5, 6];
        public void SevZapMethod()
        {
            object[,] arrayC = new object[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }
            
            int y = 0, x = 0, n = 0, k = 0, sum = 0;

            while (x < dataGridView1.Rows.Count - 1 && y < dataGridView1.Columns.Count - 1)
            {
                if (Convert.ToInt32(arrayC[x, 5]) >= Convert.ToInt32(arrayC[4, y]))
                {
                    arrayD[n, k] = Convert.ToInt32(arrayC[4, y]);
                    this.dataGridView2[k, n].Value = arrayD[n, k];
                    this.dataGridView2[k, n].Style.BackColor = System.Drawing.Color.SteelBlue;
                    arrayC[x, 5] = Convert.ToInt32(arrayC[x, 5]) - Convert.ToInt32(arrayC[4, y]);
                    sum = sum + Convert.ToInt32(arrayC[n, k]) * arrayD[n, k];
                    y = y + 1;
                    k = k + 1;
                }
                else
                {
                    arrayD[n, k] = Convert.ToInt32(arrayC[x, 5]);
                    this.dataGridView2[k, n].Value = arrayD[n, k];
                    this.dataGridView2[k, n].Style.BackColor = System.Drawing.Color.SteelBlue;
                    arrayC[4, y] = Convert.ToInt32(arrayC[4, y]) - Convert.ToInt32(arrayC[x, 5]);
                    sum = sum + Convert.ToInt32(arrayC[n, k]) * arrayD[n, k];
                    n = n + 1;
                    x = x + 1;
                }
            }
            PotrZapac1();
            label2.Text = sum.ToString(); 
        }
        
        public void MethodPot()
        {
            object[,] arrayC = new object[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            int[] alfa = new int[4];
            int[] beta = new int[5];
            int[] Summa = new int[15];
            Summa[0] = 700000;
            Summa[1] = 500000;
             int nomer = 1;
            alfa[0] = 0;
            int kolIter = 0;
            while (Summa[nomer] <= Summa[nomer -1])
            {
                int[] massiv1 = new int[8];
                int[] massiv2 = new int[8];
                int y = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (arrayD[i, j] != 0)
                        {
                            massiv1[y] = i;
                            massiv2[y] = j;
                            y = y + 1;
                        }
                    }
                }
                //вычисляем значения потенциалов
                    int s = 0;
                    while (massiv1[0] == massiv1[s])
                    {
                        beta[massiv2[s]] = Convert.ToInt32(arrayC[massiv1[s], massiv2[s]]);
                        s =s + 1;
                    }
                
                  for (int i = s; i < massiv1.Length; i++)
                    {
                    if (beta[massiv2[i]] != 0)
                    {
                        alfa[massiv1[i]] = Convert.ToInt32(arrayC[massiv1[i], massiv2[i]]) - beta[massiv2[i]];
                    }
                    else if(alfa[massiv1[i]] != 0)
                    {
                        beta[massiv2[i]] = Convert.ToInt32(arrayC[massiv1[i], massiv2[i]]) - alfa[massiv1[i]];
                    }
                        
                }
                //дозаполняем массивы потенциалов если есть пустые
                for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (arrayD[i, j] != 0)
                        {
                            if (alfa[i] == 0)
                            {
                                alfa[i] = Convert.ToInt32(arrayC[i, j]) - beta[j];
                            }
                            if (beta[j] == 0)
                            {
                                beta[j] = Convert.ToInt32(arrayC[i, j]) - alfa[i];
                            }
                        }
                        
                    }
                }
                
                if (kolIter == 4)
                {
                    alfa[2] = Convert.ToInt32(arrayC[2, 4]) - beta[4];
                }
                // формируем z строку
                int[,] strokaZ = new int[4, 5];
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
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
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            if (strokaZ[i, j] >= max)
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
                    int[] arrayI = new int[8];
                    int[] arrayJ = new int[8];
                    int m = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
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
                    bool ciklzap = true, ciklzap2 = true;
                    int f = 0, k = 0, d = 0, h = 0, g = 0, r = 0;
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

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            dataGridView3[j, i].Value = arrayD[i, j];
                            sum = sum + Convert.ToInt32(arrayC[i, j]) * arrayD[i, j];
                        }
                    }
                    
                    PotrZapac2();
                    nomer += 1;
                    Summa[nomer] = sum;
                    label3.Text = Summa[nomer - 1].ToString();
                    label3.BackColor = Color.MediumSpringGreen;
                    label9.Text = kolIter.ToString();
                    label9.BackColor = Color.MediumSpringGreen;
                    Array.Clear(alfa, 0, 4);
                    Array.Clear(beta, 0, beta.Length);
                
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                {
                    if (arrayD[i, j] != 0)
                    {
                        dataGridView3[j, i].Style.BackColor = System.Drawing.Color.PaleGreen;
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SevZapMethod();
            button3.Enabled = true;
            dataGridView3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MethodPot();
        }

        
     
    }
}
