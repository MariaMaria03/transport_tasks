using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_ЛР_Кольц.маршруты_с_условиями
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                this.dataGridView1.Rows.Add();
            }
            
            
            dataGridView1.Rows[0].Cells[0].Value = 1;
            dataGridView1.Rows[1].Cells[0].Value = 2;
            dataGridView1.Rows[2].Cells[0].Value = 3;
            dataGridView1.Rows[3].Cells[0].Value = 4;
            dataGridView1.Rows[4].Cells[0].Value = 5;
            dataGridView1.Rows[5].Cells[0].Value = 6;
            dataGridView1.Rows[6].Cells[0].Value = 7;
            dataGridView1.Rows[7].Cells[0].Value = 8;
            dataGridView1.Rows[8].Cells[0].Value = 9;
            dataGridView1.Rows[9].Cells[0].Value = 10;


            dataGridView1.Rows[0].Cells[1].Value = 0;
            dataGridView1.Rows[1].Cells[1].Value = 38;
            dataGridView1.Rows[2].Cells[1].Value = 70;
            dataGridView1.Rows[3].Cells[1].Value = 28;
            dataGridView1.Rows[4].Cells[1].Value = 46;
            dataGridView1.Rows[5].Cells[1].Value = 32;
            dataGridView1.Rows[6].Cells[1].Value = 20;
            dataGridView1.Rows[7].Cells[1].Value = 44;
            dataGridView1.Rows[8].Cells[1].Value = 34;
            dataGridView1.Rows[9].Cells[1].Value = 52;

            dataGridView1.Rows[0].Cells[2].Value = 10;
            dataGridView1.Rows[1].Cells[2].Value = 26;
            dataGridView1.Rows[2].Cells[2].Value = 24;
            dataGridView1.Rows[3].Cells[2].Value = 10;
            dataGridView1.Rows[4].Cells[2].Value = 34;
            dataGridView1.Rows[5].Cells[2].Value = 20;
            dataGridView1.Rows[6].Cells[2].Value = 8;
            dataGridView1.Rows[7].Cells[2].Value = 14;
            dataGridView1.Rows[8].Cells[2].Value = 10;
            dataGridView1.Rows[9].Cells[2].Value = 20;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// ДЛЯ ПРОДУКТОВ
            int[] massivGor = new int[10];
            massivGor[0] = 1; massivGor[1] = 2; massivGor[2] = 3; massivGor[3] = 6;
            massivGor[4] = 4; massivGor[5] = 8; massivGor[6] = 10; massivGor[7] = 9;
            massivGor[8] = 7; massivGor[9] = 5;
            //переписываем в массив количество коробок по городам в порядке движения по кругу
            object[] massivKor = new object[dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                massivKor[i] = dataGridView1.Rows[massivGor[i] - 1].Cells[1].Value.ToString();

            }
            //рассчитываем маршруты
            int[,] kilometri = new int[11, 11];
            kilometri[0, 1] = kilometri[1, 0] = 5; kilometri[0, 2] = kilometri[2, 0] = 9; kilometri[0, 3] = kilometri[3, 0] = 6; kilometri[0, 4] = kilometri[4, 0] = 11;
            kilometri[0, 5] = kilometri[5, 0] = 8; kilometri[0, 6] = kilometri[6, 0] = 5; kilometri[0, 7] = kilometri[7, 0] = 4; kilometri[0, 8] = kilometri[8, 0] = 8;
            kilometri[0, 9] = kilometri[9, 0] = 8; kilometri[0, 10] = kilometri[10, 0] = 13;
            kilometri[1, 2] = kilometri[2, 1] = 4; kilometri[2, 3] = kilometri[3, 2] = 7; kilometri[3, 6] = kilometri[6, 3] = 5;
            kilometri[3, 4] = kilometri[4, 3] = 7; kilometri[4, 6] = kilometri[6, 4] = 6; kilometri[4, 8] = kilometri[8, 4] = 5;
            kilometri[8, 10] = kilometri[10, 8] = 5; kilometri[9, 10] = kilometri[10, 9] = 5; kilometri[7, 9] = kilometri[9, 7] = 6;
            kilometri[5, 7] = kilometri[7, 5] = 6;
            string[] marsh1 = new string[8];
            int s = 0;
            int nomMarsh = 0;
            marsh1[0] = "склад";
            int kolKor = 0;
            int Gorod = 0;
            int UznKor = 0;
            int UznKor2 = 0;
            int stoim = 0; int obstoim = 0;
            int Vremya = 0, obshVrem = 0;
            while (Gorod != 10)
            {
                if (Convert.ToInt32(massivKor[Gorod]) != 0)
                {
                    if ((Convert.ToInt32(textBox6.Text) - kolKor) > 0)
                    {
                        if (Convert.ToInt32(massivKor[Gorod]) <= Convert.ToInt32(textBox6.Text))
                        {
                            UznKor2 = Convert.ToInt32(textBox6.Text) - kolKor;
                            if (UznKor2 < Convert.ToInt32(massivKor[Gorod]))
                            {
                                s += 1;
                                marsh1[s] = Convert.ToString(massivGor[Gorod]);
                                kolKor += UznKor2;
                                massivKor[Gorod] = Convert.ToInt32(massivKor[Gorod]) - UznKor2;
                            }
                            else
                            {
                                s += 1;
                                marsh1[s] = Convert.ToString(massivGor[Gorod]);
                                kolKor += Convert.ToInt32(massivKor[Gorod]);
                                massivKor[Gorod] = Convert.ToInt32(massivKor[Gorod]) - kolKor;
                                //повторный кусок кода для последнего маршрута
                                if (Gorod == 9)
                                {
                                    marsh1[0] = "склад";
                                    marsh1[s + 1] = "склад";
                                    for (int y = 0; y <= s + 1; y++)
                                    {
                                        dataGridView2.Rows[nomMarsh].Cells[y].Value = marsh1[y];
                                    }
                                    marsh1[0] = "0"; marsh1[s + 1] = "0";
                                    for (int w = 0; w <= s + 1; w++)
                                    {
                                        stoim += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])];
                                    }
                                    stoim = stoim * Convert.ToInt32(textBox1.Text);
                                    obstoim += stoim;
                                    dataGridView2.Rows[nomMarsh].Cells[5].Value = stoim;
                                    if ((s + 1) == 2)
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 1);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    else if ((s + 1) == 3)
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 2);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    else
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 3);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    dataGridView2.Rows[nomMarsh].Cells[6].Value = Vremya;
                                    s = 0;
                                    nomMarsh += 1;
                                    Array.Clear(marsh1, 0, marsh1.Length);
                                    kolKor = 0;
                                    stoim = 0;
                                    Vremya = 0;
                                }
                                Gorod += 1;

                            }
                        }
                        else
                        {
                            s += 1;
                            marsh1[s] = Convert.ToString(massivGor[Gorod]);
                            UznKor = Convert.ToInt32(textBox6.Text) - kolKor;
                            kolKor = kolKor + UznKor;
                            massivKor[Gorod] = Convert.ToInt32(massivKor[Gorod]) - UznKor;
                        }

                    }
                    else
                    {
                        //вывод в datagridview маршрутов и подсчет стоимости
                        marsh1[0] = "склад";
                        marsh1[s + 1] = "склад";
                        dataGridView2.Rows.Add();
                        for (int y = 0; y <= s + 1; y++)
                        {
                            dataGridView2.Rows[nomMarsh].Cells[y].Value = marsh1[y];
                        }
                        marsh1[0] = "0"; marsh1[s + 1] = "0";
                        for (int w = 0; w <= s + 1; w++)
                        {
                            stoim += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])];
                        }
                        stoim = stoim * Convert.ToInt32(textBox1.Text);
                        obstoim += stoim;
                        dataGridView2.Rows[nomMarsh].Cells[5].Value = stoim;
                        if ((s + 1) == 2)
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * 1);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        else if ((s + 1) == 3)
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * 2);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        else
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * 3);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        dataGridView2.Rows[nomMarsh].Cells[6].Value = Vremya;
                        s = 0;
                        nomMarsh += 1;
                        Array.Clear(marsh1, 0, marsh1.Length);
                        kolKor = 0;
                        stoim = 0;
                        Vremya = 0;
                    }
                }
                else
                {
                    Gorod += 1;
                }
            }
            
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            { 
              dataGridView2.Rows[i].HeaderCell.Value = i+ 1+" маршрут";
            }





            //МОЮЩИЕ СРЕДСТВА

            massivGor[0] = 1; massivGor[1] = 2; massivGor[2] = 3; massivGor[3] = 6;
            massivGor[4] = 4; massivGor[5] = 8; massivGor[6] = 10; massivGor[7] = 9;
            massivGor[8] = 7; massivGor[9] = 5;
            //переписываем в массив количество коробок по городам в порядке движения по кругу

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                massivKor[i] = dataGridView1.Rows[massivGor[i] - 1].Cells[2].Value.ToString();

            }
            //рассчитываем маршруты

            s = 0;
            nomMarsh = 0;
            marsh1[0] = "склад";
            kolKor = 0;
            Gorod = 0;
            UznKor = 0;
            UznKor2 = 0;
            stoim = 0;
            while (Gorod != 10)
            {
                if (Convert.ToInt32(massivKor[Gorod]) != 0)
                {
                    if ((Convert.ToInt32(textBox6.Text) - kolKor) > 0)
                    {
                        if (Convert.ToInt32(massivKor[Gorod]) <= Convert.ToInt32(textBox6.Text))
                        {
                            UznKor2 = Convert.ToInt32(textBox6.Text) - kolKor;
                            if (UznKor2 < Convert.ToInt32(massivKor[Gorod]))
                            {
                                s += 1;
                                marsh1[s] = Convert.ToString(massivGor[Gorod]);
                                kolKor += UznKor2;
                                massivKor[Gorod] = Convert.ToInt32(massivKor[Gorod]) - UznKor2;
                            }
                            else
                            {
                                s += 1;
                                marsh1[s] = Convert.ToString(massivGor[Gorod]);
                                kolKor += Convert.ToInt32(massivKor[Gorod]);
                                massivKor[Gorod] = Convert.ToInt32(massivKor[Gorod]) - kolKor;
                                //повторный кусок кода для последнего маршрута
                                if (Gorod == 9)
                                {
                                    marsh1[0] = "склад";
                                    marsh1[s + 1] = "склад";
                                    for (int y = 0; y <= s + 1; y++)
                                    {
                                        dataGridView3.Rows[nomMarsh].Cells[y].Value = marsh1[y];
                                    }
                                    marsh1[0] = "0"; marsh1[s + 1] = "0";
                                    for (int w = 0; w <= s + 1; w++)
                                    {
                                        stoim += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])];
                                    }
                                    stoim = stoim * Convert.ToInt32(textBox1.Text);
                                    obstoim += stoim;
                                    dataGridView3.Rows[nomMarsh].Cells[6].Value = stoim;
                                    if ((s + 1) == 2)
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 1);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    else if ((s + 1) == 3)
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 2);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    else if ((s + 1) == 4)
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 3);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    else
                                    {
                                        Vremya = (Convert.ToInt32(textBox2.Text) + kolKor + Convert.ToInt32(textBox4.Text) * 4);
                                        for (int w = 0; w <= s + 1; w++)
                                        {
                                            Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                                        }
                                    }
                                    dataGridView3.Rows[nomMarsh].Cells[7].Value = Vremya;
                                    s = 0;
                                    nomMarsh += 1;
                                    Array.Clear(marsh1, 0, marsh1.Length);
                                    kolKor = 0;
                                    stoim = 0;
                                }
                                Gorod += 1;

                            }
                        }
                        else
                        {
                            s += 1;
                            marsh1[s] = Convert.ToString(massivGor[Gorod]);
                            UznKor = Convert.ToInt32(textBox6.Text) - kolKor;
                            kolKor = kolKor + UznKor;
                            massivKor[Gorod] = Convert.ToInt32(massivKor[Gorod]) - UznKor;
                        }

                    }
                    else
                    {
                        //вывод в datagridview маршрутов и подсчет стоимости
                        marsh1[0] = "склад";
                        marsh1[s + 1] = "склад";
                        dataGridView3.Rows.Add();
                        for (int y = 0; y <= s + 1; y++)
                        {
                            dataGridView3.Rows[nomMarsh].Cells[y].Value = marsh1[y];
                        }
                        marsh1[0] = "0"; marsh1[s + 1] = "0";
                        for (int w = 0; w <= s + 1; w++)
                        {
                            stoim += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])];
                        }
                        stoim = stoim * Convert.ToInt32(textBox1.Text);
                        obstoim += stoim;
                        dataGridView3.Rows[nomMarsh].Cells[6].Value = stoim;
                        if ((s + 1) == 2)
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox2.Text) * 1);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        else if ((s + 1) == 3)
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * 2);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        else if ((s + 1) == 4)
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * 3);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        else
                        {
                            Vremya = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox4.Text) * 4);
                            for (int w = 0; w <= s + 1; w++)
                            {
                                Vremya += kilometri[Convert.ToInt32(marsh1[w]), Convert.ToInt32(marsh1[w + 1])] * Convert.ToInt32(textBox3.Text);
                            }
                        }
                        dataGridView3.Rows[nomMarsh].Cells[7].Value = Vremya;
                        s = 0;
                        nomMarsh += 1;
                        Array.Clear(marsh1, 0, marsh1.Length);
                        kolKor = 0;
                        stoim = 0;
                        Vremya = 0;
                    }
                }
                else
                {
                    Gorod += 1;
                }
            }
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                dataGridView3.Rows[i].HeaderCell.Value = i + 1 + " маршрут";
            }
           


            //записываем в массив время
            
             object[] massivVrem = new object[dataGridView3.Rows.Count + dataGridView2.Rows.Count];
             int M = 0;
             for (int i = 0; i < dataGridView3.Rows.Count; i++)
             {
                 massivVrem[i] = dataGridView3.Rows[i].Cells[7].Value.ToString();
                 M = i;
             }
             int uu = 0;
             for (int i = M + 1; i < dataGridView2.Rows.Count + dataGridView3.Rows.Count; i++)
             {
                 massivVrem[i] = dataGridView2.Rows[uu].Cells[6].Value.ToString();
                 uu += 1;
             }   

            //считаем количество задействованных машин
            double VremMash = 0;
            int kolMash = 0;
            VremMash = Convert.ToInt32(massivVrem[0]);
            for (int f = 1; f < massivVrem.Length; f++)
            {
                
                if (Convert.ToInt32(massivVrem[f]) != 0)
                {
                    if ((VremMash + Convert.ToInt32(massivVrem[f])) <= 300)
                    {
                        VremMash = VremMash + Convert.ToInt32(massivVrem[f]);
                        massivVrem[0] = 0; massivVrem[f] = 0;
                        for (int l = f + 1; l < massivVrem.Length; l++)
                        {
                            if (Convert.ToInt32(massivVrem[l]) != 0)
                            {
                                //если без перерыва проехать три маршрута
                                if (VremMash + Convert.ToInt32(massivVrem[l]) <= 300)
                                {
                                    VremMash = VremMash + Convert.ToInt32(massivVrem[f]);
                                    massivVrem[0] = 0; massivVrem[l] = 0;
                                    for (int n = l + 1; n < massivVrem.Length; n++)
                                    {
                                        if (Convert.ToInt32(massivVrem[n]) != 0)
                                        {
                                            if (VremMash + Convert.ToInt32(massivVrem[n]) <= 300)
                                            { }
                                            else
                                            {
                                                VremMash += 30;
                                                for (int x = 0; x < massivVrem.Length; x++)
                                                {
                                                    if (Convert.ToInt32(massivVrem[x]) != 0)
                                                    {
                                                        if (Convert.ToInt32(massivVrem[x]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                        {
                                                            VremMash += Convert.ToInt32(massivVrem[x]);
                                                            massivVrem[x] = 0;
                                                            for (int a = 0; a < massivVrem.Length; a++)
                                                            {
                                                                if (Convert.ToInt32(massivVrem[a]) != 0)
                                                                {
                                                                    if (Convert.ToInt32(massivVrem[a]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                                    {
                                                                        VremMash += Convert.ToInt32(massivVrem[a]);
                                                                        massivVrem[a] = 0;
                                                                        for (int z = 0; z < massivVrem.Length; z++)
                                                                        {
                                                                            if (Convert.ToInt32(massivVrem[z]) != 0)
                                                                            {
                                                                                if (Convert.ToInt32(massivVrem[z]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                                                {
                                                                                    VremMash += Convert.ToInt32(massivVrem[z]);
                                                                                    massivVrem[z] = 0;
                                                                                    for (int q = 0; q < massivVrem.Length; q++)
                                                                                    {
                                                                                        if (Convert.ToInt32(massivVrem[q]) != 0)
                                                                                        {
                                                                                            if (Convert.ToInt32(massivVrem[q]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                                                            { }
                                                                                            else
                                                                                            {
                                                                                                kolMash += 1;
                                                                                                VremMash = 0;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    kolMash += 1;
                                                                                    VremMash = 0;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        kolMash += 1;
                                                                        VremMash = 0;
                                                                    }
                                                                }


                                                            }
                                                        }
                                                        else
                                                        {
                                                            kolMash += 1;
                                                            VremMash = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    VremMash += 30;
                                    for (int x = 0; x < massivVrem.Length; x++)
                                    {
                                        if (Convert.ToInt32(massivVrem[x]) != 0)
                                        {
                                            if (Convert.ToInt32(massivVrem[x]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                            {
                                                VremMash += Convert.ToInt32(massivVrem[x]);
                                                massivVrem[x] = 0;
                                                for (int a = 0; a < massivVrem.Length; a++)
                                                {
                                                    if (Convert.ToInt32(massivVrem[a]) != 0)
                                                    {
                                                        if (Convert.ToInt32(massivVrem[a]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                        {
                                                            VremMash += Convert.ToInt32(massivVrem[a]);
                                                            massivVrem[a] = 0;
                                                            for (int z = 0; z < massivVrem.Length; z++)
                                                            {
                                                                if (Convert.ToInt32(massivVrem[z]) != 0)
                                                                {
                                                                    if (Convert.ToInt32(massivVrem[z]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                                    {
                                                                        VremMash += Convert.ToInt32(massivVrem[z]);
                                                                        massivVrem[z] = 0;
                                                                        for (int q = 0; q < massivVrem.Length; q++)
                                                                        {
                                                                            if (Convert.ToInt32(massivVrem[q]) != 0)
                                                                            {
                                                                                if (Convert.ToInt32(massivVrem[q]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                                                { }
                                                                                else
                                                                                {
                                                                                    kolMash += 1;
                                                                                    VremMash = 0;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        kolMash += 1;
                                                                        VremMash = 0;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            kolMash += 1;
                                                            VremMash = 0;
                                                        }
                                                    }


                                                }
                                            }
                                            else
                                            {
                                                kolMash += 1;
                                                VremMash = 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //если первый маршрут долгий, то сразу после него перерыв
                        VremMash += 30;
                        for (int x = 0; x < massivVrem.Length; x++)
                        {
                            if (Convert.ToInt32(massivVrem[x]) != 0)
                            {
                                if (Convert.ToInt32(massivVrem[x]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                {
                                    VremMash += Convert.ToInt32(massivVrem[x]);
                                    massivVrem[x] = 0;
                                    for (int a = 0; a < massivVrem.Length; a++)
                                    {
                                        if (Convert.ToInt32(massivVrem[a]) != 0)
                                        {
                                            if (Convert.ToInt32(massivVrem[a]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                            {
                                                VremMash += Convert.ToInt32(massivVrem[a]);
                                                massivVrem[a] = 0;
                                                for (int z = 0; z < massivVrem.Length; z++)
                                                {
                                                    if (Convert.ToInt32(massivVrem[z]) != 0)
                                                    {
                                                        if (Convert.ToInt32(massivVrem[z]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                        {
                                                            VremMash += Convert.ToInt32(massivVrem[z]);
                                                            massivVrem[z] = 0;
                                                            for (int q = 0; q < massivVrem.Length; q++)
                                                            {
                                                                if (Convert.ToInt32(massivVrem[q]) != 0)
                                                                {
                                                                    if (Convert.ToInt32(massivVrem[q]) <= (Convert.ToInt32(textBox8.Text) * 60 - VremMash))
                                                                    { }
                                                                   
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            kolMash += 1;
                                                            VremMash = 0;
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                kolMash += 1;
                                                VremMash = 0;
                                            }
                                        }


                                    }
                                }
                                else
                                {
                                    kolMash += 1;
                                    VremMash = 0;
                                }
                            }
                        }
                    }
              }
            }
            label18.Text = Convert.ToString(kolMash);
            obstoim += Convert.ToInt32(textBox7.Text) * kolMash;
            label2.Text = Convert.ToString(obstoim);
            button1.Enabled = false;
            
        }





        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
        }

       

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                 {
              e.Handled = true;
                  }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

       

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            button3.Enabled = true;
        }

        

        



    }
}
