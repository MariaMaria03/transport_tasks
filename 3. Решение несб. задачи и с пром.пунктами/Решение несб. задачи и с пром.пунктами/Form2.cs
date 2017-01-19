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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int[,] arrayD = new int[7, 5];
            int[,] arrayZ = new int[7, 5];
            arrayZ[0, 0] = 0;
            object[,] arrayC = new object[dataGridView3.RowCount, dataGridView3.ColumnCount];
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView3.Rows[i].Cells[j].Value.ToString();

                }
            }
            for (int y = 0; y < dataGridView3.Rows.Count; y++)
            {
                for (int x = 0; x < dataGridView3.Columns.Count; x++)
                {
                    arrayZ[y, x] = Convert.ToInt32(arrayC[y, x]);

                }
            }
            int poisk = 0;
            int[] iter = new int[4];
            int ElMin2 = 0;
            int ElMin = arrayZ[0, 0];
            int ymin = 0, xmin = 0;

            int vstol = 0, vstr = 0;
            while (vstol != 3 || vstr != 5)
            {
                for (int n = 0; n < dataGridView3.Columns.Count - 1; n++)
                {
                    while (poisk != 2)
                    {
                        for (int m = 0; m < dataGridView3.Rows.Count - 1; m++)
                        {
                            if (ElMin < arrayZ[m, n])
                            {
                                ElMin = arrayZ[ymin, xmin];
                            }
                            else
                            {
                                ElMin = arrayZ[m, n];
                                ymin = m;
                                xmin = n;

                            }
                        }
                        poisk = poisk + 1;
                        iter[n] = ElMin - ElMin2;
                        ElMin2 = ElMin;
                        arrayZ[ymin, xmin] = 100;
                        ElMin = 100;
                    }
                    poisk = 0;
                }
                int max = 0;
                int nom = 0;
                ///ищем максимальный элемент в итерации
                for (int n = 0; n < 4; n++)
                {
                    if (max < iter[n])
                    {
                        max = iter[n];
                        nom = n;
                    }
                }
                iter[nom] = 0;
                //ищем минимальный элемент в массиве в столбце конкретном
                ElMin = Convert.ToInt32(arrayC[0, nom]);
                for (int m = 0; m < dataGridView3.Rows.Count - 1; m++)
                {
                    if (ElMin < Convert.ToInt32(arrayC[m, nom]))
                    {
                        ElMin = Convert.ToInt32(arrayC[ymin, xmin]);
                    }
                    else
                    {
                        ElMin = Convert.ToInt32(arrayC[m, nom]);
                        ymin = m;
                        xmin = nom;

                    }
                }
                //


                if (Convert.ToInt32(arrayC[ymin,4]) >= Convert.ToInt32(arrayC[6, xmin]))
                {
                    arrayD[ymin, xmin] = Convert.ToInt32(arrayC[6, xmin]);
                    this.dataGridView2[xmin, ymin].Value = arrayD[ymin, xmin];
                    arrayC[ymin, 4] = Convert.ToInt32(arrayC[ymin, 4]) - Convert.ToInt32(arrayC[6, xmin]);
                    this.dataGridView2[xmin, ymin].Style.BackColor = System.Drawing.Color.PaleVioletRed;
                    sum = sum + Convert.ToInt32(arrayC[ymin, xmin]) * arrayD[ymin, xmin];
                    arrayC[0, xmin] = 100;
                    arrayC[1, xmin] = 100;
                    arrayC[2, xmin] = 100;
                    arrayC[3, xmin] = 100;
                    arrayC[4, xmin] = 100;
                    arrayC[5, xmin] = 100;
                    vstol = vstol + 1;
                }
                else
                {
                    arrayD[ymin, xmin] = Convert.ToInt32(arrayC[ymin, 4]);
                    this.dataGridView2[xmin, ymin].Value = arrayD[ymin, xmin];
                    this.dataGridView2[xmin, ymin].Style.BackColor = System.Drawing.Color.PaleVioletRed;
                    arrayC[6, xmin] = Convert.ToInt32(arrayC[6, xmin]) - Convert.ToInt32(arrayC[ymin, 4]);
                    sum = sum + Convert.ToInt32(arrayC[ymin, xmin]) * arrayD[ymin, xmin];
                    arrayC[ymin, 0] = 100;
                    arrayC[ymin, 1] = 100;
                    arrayC[ymin, 2] = 100;
                    arrayC[ymin, 3] = 100;
                    vstr = vstr + 1;
                }
                for (int y = 0; y < dataGridView3.Rows.Count; y++)
                {
                    for (int x = 0; x < dataGridView3.Columns.Count; x++)
                    {
                        arrayZ[y, x] = Convert.ToInt32(arrayC[y, x]);

                    }
                }
            }
            for (int x = 0; x < dataGridView3.Columns.Count - 1; x++)
            {
                if (Convert.ToInt32(arrayC[6, x]) != 0)
                {
                    for (int y = 0; y < dataGridView3.Rows.Count - 1; y++)
                    {
                        if (Convert.ToInt32(arrayC[y, x]) != 100)
                        {
                            sum = sum + Convert.ToInt32(arrayC[y, x]) * Convert.ToInt32(arrayC[y, 4]);
                            arrayC[6, x] = Convert.ToInt32(arrayC[6, x]) - Convert.ToInt32(arrayC[y, 4]);
                            arrayD[y, x] = Convert.ToInt32(arrayC[y, 4]);
                            this.dataGridView2[x, y].Value = arrayD[y, x];
                            this.dataGridView2[x, y].Style.BackColor = System.Drawing.Color.PaleVioletRed;
                        }
                    }
                }
            }
            
            dataGridView2[0, 6].Value = 80;
            dataGridView2[1, 6].Value = 120;
            dataGridView2[2, 6].Value = 90;
            dataGridView2[3, 6].Value = 60;
            

            dataGridView2[4, 0].Value = 60;
           dataGridView2[4, 1].Value = 40;
            dataGridView2[4, 2].Value = 80;
            dataGridView2[4, 3].Value = 70;
            dataGridView2[4, 4].Value = 70;
            dataGridView2[4, 5].Value = 30;
            dataGridView2[4, 6].Value = 350;
            
             label2.Text = sum.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void AddRow()
        {
            for (int i = 0; i < 6; i++)
            {
                this.dataGridView3.Rows.Add();
            }
            for (int i = 0; i < 6; i++)
            {
                this.dataGridView2.Rows.Add();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRow();

            dataGridView3.Rows[0].HeaderCell.Value = "A1";
            dataGridView3.Rows[1].HeaderCell.Value = "A2";
            dataGridView3.Rows[2].HeaderCell.Value = "A3";
            dataGridView3.Rows[3].HeaderCell.Value = "A4";
            dataGridView3.Rows[4].HeaderCell.Value = "A5";
            dataGridView3.Rows[5].HeaderCell.Value = "Фиктивный пункт";
            dataGridView3.Rows[6].HeaderCell.Value = "Потребности";

            dataGridView2.Rows[0].HeaderCell.Value = "A1";
            dataGridView2.Rows[1].HeaderCell.Value = "A2";
            dataGridView2.Rows[2].HeaderCell.Value = "A3";
            dataGridView2.Rows[3].HeaderCell.Value = "A4";
            dataGridView2.Rows[4].HeaderCell.Value = "A5";
            dataGridView2.Rows[5].HeaderCell.Value = "Фиктивный пункт";
            dataGridView2.Rows[6].HeaderCell.Value = "Потребности";



            dataGridView3.Rows[0].Cells[0].Value = 4;
            dataGridView3.Rows[0].Cells[1].Value = 6;
            dataGridView3.Rows[0].Cells[2].Value = 12;
            dataGridView3.Rows[0].Cells[3].Value = 10;
            dataGridView3.Rows[0].Cells[4].Value = 60;

            dataGridView3.Rows[1].Cells[0].Value = 7;
            dataGridView3.Rows[1].Cells[1].Value = 11;
            dataGridView3.Rows[1].Cells[2].Value = 10;
            dataGridView3.Rows[1].Cells[3].Value = 12;
            dataGridView3.Rows[1].Cells[4].Value = 40;

            dataGridView3.Rows[2].Cells[0].Value = 9;
            dataGridView3.Rows[2].Cells[1].Value = 10;
            dataGridView3.Rows[2].Cells[2].Value = 11;
            dataGridView3.Rows[2].Cells[3].Value = 11;
            dataGridView3.Rows[2].Cells[4].Value = 80;

            dataGridView3.Rows[3].Cells[0].Value = 6;
            dataGridView3.Rows[3].Cells[1].Value = 8;
            dataGridView3.Rows[3].Cells[2].Value = 7;
            dataGridView3.Rows[3].Cells[3].Value = 15;
            dataGridView3.Rows[3].Cells[4].Value = 70;

            dataGridView3.Rows[4].Cells[0].Value = 5;
            dataGridView3.Rows[4].Cells[1].Value = 12;
            dataGridView3.Rows[4].Cells[2].Value = 14;
            dataGridView3.Rows[4].Cells[3].Value = 7;
            dataGridView3.Rows[4].Cells[4].Value = 70;

            dataGridView3.Rows[5].Cells[0].Value = 0;
            dataGridView3.Rows[5].Cells[1].Value = 0;
            dataGridView3.Rows[5].Cells[2].Value = 0;
            dataGridView3.Rows[5].Cells[3].Value = 0;
            dataGridView3.Rows[5].Cells[4].Value = 30;
            
            dataGridView3.Rows[6].Cells[0].Value = 80;
            dataGridView3.Rows[6].Cells[1].Value = 120;
            dataGridView3.Rows[6].Cells[2].Value = 90;
            dataGridView3.Rows[6].Cells[3].Value = 60;
            dataGridView3.Rows[6].Cells[4].Value = 350;

            button1.Enabled = true;
        }

        

       
    }
}
