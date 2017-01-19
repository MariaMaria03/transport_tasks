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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Put = new int[6];
            int[] PutKor = new int[6];
            int StoimPut = 100;
            int[,] matrica = new int[5, 5];
            Put[0] = 0; Put[5] = 0;
            PutKor[0] = 0; PutKor[5] = 0;
            matrica[0, 0] = 200; matrica[0, 1] = 4; matrica[0, 2] = 12; matrica[0, 3] = 14; matrica[0, 4] = 4;
            matrica[1, 0] = 3; matrica[1, 1] = 200; matrica[1, 2] = 12; matrica[1, 3] = 10; matrica[1, 4] = 10;
            matrica[2, 0] = 12; matrica[2, 1] = 4; matrica[2, 2] = 200; matrica[2, 3] = 9; matrica[2, 4] = 5;
            matrica[3, 0] = 3; matrica[3, 1] = 11; matrica[3, 2] = 11; matrica[3, 3] = 200; matrica[3, 4] = 9;
            matrica[4, 0] = 10; matrica[4, 1] = 3; matrica[4, 2] = 1; matrica[4, 3] = 3; matrica[4, 4] = 200;
            
            int f = 0, h = 0, m = 0;
            for (int j = 1; j < 5; j++)
            {
                Put[1] = j;
                for (f = 1; f < 5; f++)
                {
                    if (f != Put[1])
                    {
                        Put[2] = f;
                        for (h = 1; h < 5; h++)
                        {
                            if (h != Put[1] && h != Put[2])
                            {
                                Put[3] = h;
                                for (m = 1; m < 5; m++)
                                {
                                    if (m != Put[1] && m != Put[2] && m != Put[3])
                                    {
                                        Put[4] = m;
                                        if (StoimPut > matrica[Put[0], Put[1]] + matrica[Put[1], Put[2]] + matrica[Put[2], Put[3]] + matrica[Put[3], Put[4]] + matrica[Put[4], Put[5]])
                                        {
                                            StoimPut = matrica[Put[0], Put[1]] + matrica[Put[1], Put[2]] + matrica[Put[2], Put[3]] + matrica[Put[3], Put[4]] + matrica[Put[4], Put[5]];
                                            PutKor[1] = Put[1]; PutKor[2] = Put[2]; PutKor[3] = Put[3]; PutKor[4] = Put[4];

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            label4.Text = Convert.ToString(StoimPut);
            label5.Text = Convert.ToString(PutKor[0] + 1);
            label6.Text = Convert.ToString(PutKor[1] + 1);
            label7.Text = Convert.ToString(PutKor[2] + 1);
            label8.Text = Convert.ToString(PutKor[3] + 1);
            label9.Text = Convert.ToString(PutKor[4] + 1);
            label10.Text = Convert.ToString(PutKor[5] + 1);
        }
    }
}
