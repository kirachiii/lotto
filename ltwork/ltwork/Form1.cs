using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ltwork
{
    public partial class Form1 : Form

    {
        public Form1()
        {

            InitializeComponent();
        }
        int[] input = new int[7];
        static int sp,spuser;
        private void btn隨機_Click(object sender, EventArgs e)
        {
            int [] ran6 = new int [6];
            
            Random crad = new Random();
            sp = crad.Next(1, 9);
            lab第二區.Text = sp.ToString();
            for (int i = 0; i < ran6.Length; i++)
            {
                ran6 [i] = crad.Next(1,37);
                for(int j = 0; j < i; j++)
                {
                    while(ran6 [i] == ran6[j])
                    {
                        j = 0;
                        ran6[i] = crad.Next(1, 37);
                    }
                }
            }
            for (int i = 0; i < ran6.Length; i++)
            {
                lab主要顯示.Text += ($"{ran6[i].ToString()},");
            }
            lab主要顯示.Text += ("\n");
            Array.Sort(ran6);
            for (int i = 0; i < ran6.Length; i++)
            {
                lab副顯示區域.Text += ($"{ran6[i].ToString()},");
            }
            lab副顯示區域.Text += ("\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab主要顯示.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn自選號碼_Click(object sender, EventArgs e)
        {
            lab自選號碼.Text = "";
            int i, j;
            
            bool fal=true;
            try
            {
                for (i = 0; i < 7; i++)
            {
                if (i < 6)
                {
                    string savenub = Interaction.InputBox($"輸入第{i + 1}號碼\n數字在1~36之間", $"自選號碼第{i + 1}組", "", -1, -1);
                    
                        if ((Convert.ToInt32(savenub) > 36) | (Convert.ToInt32(savenub) < 1))
                        {
                            MessageBox.Show("請輸入在1~36之間的數字");
                            i--;
                        }
                        else
                        {
                            input[i] = Convert.ToInt32(savenub);

                            for(j = 0; j < i; j++)
                            {
                                if (input[i] == input[j])
                                {
                                    fal = false;
                                    MessageBox.Show("請不要輸入重複的數字");
                                    
                                 
                                }
                            }
                        }
                        if (fal == true)
                            {
                                lab自選號碼.Text += ($"{input[i].ToString()},");
                            }
                            else
                            {
                                i--;
                                fal = true;
                            }
                        
                    }
                else
                    {
                        string savenub = Interaction.InputBox($"輸入第二區號碼\n數字在1~6之間", $"特殊號碼", "", -1, -1);
                        if (Convert.ToInt32(savenub) > 6)
                        {
                            MessageBox.Show("請輸入在1~6之間的數字");
                            i--;
                        }
                        else
                        {
                            input[i] = Convert.ToInt32(savenub);
                            lab自選號碼.Text += ($"\t{input[i].ToString()}");
                        }
                    }

                }
                listBox1.Items.Add(lab自選號碼.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("請輸入在1~36之間的數字\n也不要輸入英文與特殊字元");
            }
        }

        private void btn對獎_Click(object sender, EventArgs e)
        {
            call對獎();

        }
        void call對獎()
        {
            int[] get;
            //for (int i = 0; i < 7; i++){
            //    int[] b = Array.ConvertAll(listBox1.Items[i].ToString().Split(' '),s=>int.Parse(s));
            //}
            string str;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                get = Array.ConvertAll(listBox1.Items[i].ToString().Split(','), s => int.Parse(s));
                label5.Text = get[i].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = ("");
            int[] ran6user = new int[6];

            Random crad = new Random();
            spuser = crad.Next(1, 9);
            for (int i = 0; i < ran6user.Length; i++)
            {
                ran6user[i] = crad.Next(1, 37);
                for (int j = 0; j < i; j++)
                {
                    while (ran6user[i] == ran6user[j])
                    {
                        j = 0;
                        ran6user[i] = crad.Next(1, 37);
                    }
                }
            }
            for(int i = 0; i < ran6user.Length; i++)
            {
                label5.Text += ($"{ran6user[i].ToString()},");
            }
            label5.Text += ($"\t{spuser.ToString()}");
            listBox1.Items.Add(label5.Text );
        }
    }
    }

