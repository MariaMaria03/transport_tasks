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
    public partial class Form2 : Form
    {
        public Form2()
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
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
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
            this.textBox1.Text = "180 90 120 110 100";
            this.textBox2.Text = "150 100 120 230";
            
        }

                  
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] arrstring = new string[4];
            if (s != "")
            {
                arrstring = s.Split(' ');
            }
            int[] arrayA = new int[arrstring.Length];
            for (int i = 0; i < arrstring.Length; i++)
            {
                arrayA[i] = Convert.ToInt32(arrstring[i]);
            }

            object[,] arrayC = new object[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    arrayC[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }

            int[,] arrayD = new int[5, 6];
            string m = textBox2.Text;
            string[] arrstring2 = new string[3];
            if (m != "")
            {
                arrstring2 = m.Split(' ');
            }
            int[] arrayB = new int[arrstring2.Length];
            for (int i = 0; i < arrstring2.Length; i++)
            {
                arrayB[i] = Convert.ToInt32(arrstring2[i]);
            }
            int y = 0, x = 0, n = 0, k = 0, sum = 0;
            
            while ( x < arrayA.Length && y < arrayB.Length) 
            {
            
                if (arrayB[y] >= arrayA[x])
                 {
                arrayD[n,k] = arrayA[x];
                this.dataGridView2[k, n].Value = arrayD[n, k];
                this.dataGridView2[k, n].Style.BackColor = System.Drawing.Color.SteelBlue;
                arrayB[y] = arrayB[y] - arrayA[x];
                sum = sum + Convert.ToInt32(arrayC[n,k]) * arrayD[n,k];
                x = x + 1;
                k = k + 1; 
                 }
                else {
                arrayD[n, k] = arrayB[y];
                this.dataGridView2[k, n].Value = arrayD[n, k];
                this.dataGridView2[k, n].Style.BackColor = System.Drawing.Color.SteelBlue;
                arrayA[x] = arrayA[x] - arrayB[y];
                sum = sum + Convert.ToInt32(arrayC[n, k]) * arrayD[n, k];
                n = n + 1;
                y = y + 1;   
                     }
            }
            label7.Text = sum.ToString();
            this.dataGridView2[5, 0].Value = 150;
            this.dataGridView2[5, 1].Value = 100;
            this.dataGridView2[5, 2].Value = 120;
            this.dataGridView2[5, 3].Value = 230;
            this.dataGridView2[5, 4].Value = 600;
            this.dataGridView2[4, 4].Value = 100;
            this.dataGridView2[3, 4].Value = 110;
            this.dataGridView2[2, 4].Value = 120;
            this.dataGridView2[1, 4].Value = 90;
            this.dataGridView2[0, 4].Value = 180;
        }

       
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        
        

        
        

    }
}
