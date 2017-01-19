using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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



            dataGridView1.Rows[0].Cells[0].Value = 14;
            dataGridView1.Rows[0].Cells[1].Value = 13;
            dataGridView1.Rows[0].Cells[2].Value = 11;
            dataGridView1.Rows[0].Cells[3].Value = 12;
            dataGridView1.Rows[0].Cells[4].Value = 9;
            dataGridView1.Rows[0].Cells[5].Value = 150;

            dataGridView1.Rows[1].Cells[0].Value = 8;
            dataGridView1.Rows[1].Cells[1].Value = 7;
            dataGridView1.Rows[1].Cells[2].Value = 6;
            dataGridView1.Rows[1].Cells[3].Value = 12;
            dataGridView1.Rows[1].Cells[4].Value = 10;
            dataGridView1.Rows[1].Cells[5].Value = 100;

            dataGridView1.Rows[2].Cells[0].Value = 14;
            dataGridView1.Rows[2].Cells[1].Value = 17;
            dataGridView1.Rows[2].Cells[2].Value = 20;
            dataGridView1.Rows[2].Cells[3].Value = 11;
            dataGridView1.Rows[2].Cells[4].Value = 12;
            dataGridView1.Rows[2].Cells[5].Value = 120;

            dataGridView1.Rows[3].Cells[0].Value = 10;
            dataGridView1.Rows[3].Cells[1].Value = 18;
            dataGridView1.Rows[3].Cells[2].Value = 18;
            dataGridView1.Rows[3].Cells[3].Value = 10;
            dataGridView1.Rows[3].Cells[4].Value = 16;
            dataGridView1.Rows[3].Cells[5].Value = 230;

            dataGridView1.Rows[4].Cells[0].Value = 180;
            dataGridView1.Rows[4].Cells[1].Value = 90;
            dataGridView1.Rows[4].Cells[2].Value = 120;
            dataGridView1.Rows[4].Cells[3].Value = 110;
            dataGridView1.Rows[4].Cells[4].Value = 100;
            dataGridView1.Rows[4].Cells[5].Value = 600;
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sum = 0;
            int[,] arrayD = new int[5, 6];
            int[,] arrayZ = new int[5, 6];
            arrayZ[0, 0] = 0;
            object[,] arrayC = new object[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }
            for (int y = 0; y < dataGridView1.Rows.Count; y++)
            {
                for (int x = 0; x < dataGridView1.Columns.Count; x++)
                {
                    arrayZ[y, x] = Convert.ToInt32(arrayC[y, x]);

                }
            }
            int poisk = 0;
            int[] iter = new int[5];
            int ElMin2 = 0;
            int ElMin = arrayZ[0, 0];
            int ymin = 0, xmin = 0;

            int vstol = 0, vstr = 0;
            while (vstol != 4 || vstr != 3)
            {
                for (int n = 0; n < dataGridView1.Columns.Count - 1; n++)
                {
                    while (poisk != 2)
                    {
                        for (int m = 0; m < dataGridView1.Rows.Count - 1; m++)
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
                for (int n = 0; n < 5; n++)
                {
                    if (max < iter[n])
                    {
                        max = iter[n];
                        nom = n;
                    }
                }
                iter[nom] = 0;
                //ищем минимальный элемент в массиве в столбце конкретном
                ElMin = Convert.ToInt32(arrayC[0, 0]);
                for (int m = 0; m < dataGridView1.Rows.Count - 1; m++)
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


                if (Convert.ToInt32(arrayC[ymin, 5]) >= Convert.ToInt32(arrayC[4, xmin]))
                {
                    arrayD[ymin, xmin] = Convert.ToInt32(arrayC[4, xmin]);
                    this.dataGridView2[xmin, ymin].Value = arrayD[ymin, xmin];
                    arrayC[ymin, 5] = Convert.ToInt32(arrayC[ymin, 5]) - Convert.ToInt32(arrayC[4, xmin]);
                    this.dataGridView2[xmin, ymin].Style.BackColor = System.Drawing.Color.PaleVioletRed;
                    sum = sum + Convert.ToInt32(arrayC[ymin, xmin]) * arrayD[ymin, xmin];
                    arrayC[0, xmin] = 100;
                    arrayC[1, xmin] = 100;
                    arrayC[2, xmin] = 100;
                    arrayC[3, xmin] = 100;
                    vstol = vstol + 1;
                }
                else
                {
                    arrayD[ymin, xmin] = Convert.ToInt32(arrayC[ymin, 5]);
                    this.dataGridView2[xmin, ymin].Value = arrayD[ymin, xmin];
                    this.dataGridView2[xmin, ymin].Style.BackColor = System.Drawing.Color.PaleVioletRed;
                    arrayC[4, xmin] = Convert.ToInt32(arrayC[4, xmin]) - Convert.ToInt32(arrayC[ymin, 5]);
                    sum = sum + Convert.ToInt32(arrayC[ymin, xmin]) * arrayD[ymin, xmin];
                    arrayC[ymin, 0] = 100;
                    arrayC[ymin, 1] = 100;
                    arrayC[ymin, 2] = 100;
                    arrayC[ymin, 3] = 100;
                    arrayC[ymin, 4] = 100;
                    vstr = vstr + 1;
                }
                for (int y = 0; y < dataGridView1.Rows.Count; y++)
                {
                    for (int x = 0; x < dataGridView1.Columns.Count; x++)
                    {
                        arrayZ[y, x] = Convert.ToInt32(arrayC[y, x]);

                    }
                }
            }
            for (int x = 0; x < dataGridView1.Columns.Count - 1; x++)
            {
                if (Convert.ToInt32(arrayC[4, x]) != 0)
                {
                    for (int y = 0; y < dataGridView1.Rows.Count - 1; y++)
                    {
                        if (Convert.ToInt32(arrayC[y, x]) != 100)
                        {
                            sum = sum + Convert.ToInt32(arrayC[y, x]) * Convert.ToInt32(arrayC[y, 5]);
                            arrayC[4, x] = Convert.ToInt32(arrayC[4, x]) - Convert.ToInt32(arrayC[y, 5]);
                            arrayD[y, x] = Convert.ToInt32(arrayC[y, 5]);
                            this.dataGridView2[x, y].Value = arrayD[y, x];
                            this.dataGridView2[x, y].Style.BackColor = System.Drawing.Color.PaleVioletRed;
                        }
                    }
                }
            }
            this.dataGridView2[5, 0].Value = 150;
            this.dataGridView2[5, 1].Value = 100;
            this.dataGridView2[5, 2].Value = 120;
            this.dataGridView2[5, 3].Value = 230;
            this.dataGridView2[5, 4].Value = 600;

            this.dataGridView2[0, 4].Value = 180;
            this.dataGridView2[1, 4].Value = 90;
            this.dataGridView2[2, 4].Value = 120;
            this.dataGridView2[3, 4].Value = 110;
            this.dataGridView2[4, 4].Value = 100;
            this.label2.Text = sum.ToString();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

    }
}
