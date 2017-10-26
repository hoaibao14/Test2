using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagonalDifference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnRun_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            string[] lines = input.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(lines[0]);
            if (n == (lines.Count() - 1))
            {
                int[,] multiArray = new int[n, n];
                for (int i = 1; i <= n; i++)
                {
                    string[] line = lines[i].Split(' ');
                    for (int j = 0; j < line.Count(); j++)
                    {
                        if ((int.Parse(line[j]) >= -100) && (int.Parse(line[j]) <= 100))
                        {
                            multiArray[i-1,j] = int.Parse(line[j]);
                        }
                        else {
                            tbResult.Text = "Value of element is invalid!";
                            return;
                        }
                        
                    }
                }

                int sum1=0, sum2=0;

                for (int i = 0; i < n; i++)
                {
                        sum1 += multiArray[i, i];
                        sum2 += multiArray[i, n-i-1];
                }
                tbResult.Text = Math.Abs(sum1-sum2).ToString() + " = "+ sum1.ToString() + "-" + sum2.ToString();

            }

        }

    }
}
