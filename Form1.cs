using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılı_Ort._Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Double not1, not2, ort;

                not1 = Convert.ToDouble(textBox1.Text);

                if (0 <= not1)
                {
                    if (not1<= 100)
                    {

                        not2 = Convert.ToDouble(textBox2.Text);

                        if (0<=not2)
                        {
                            if (not2<=100)
                            {
                                ort = (not1 + not2) / 2;
                                label3.Text = ort.ToString();
                            }
                            else
                            {
                                MessageBox.Show("2. Yazılı Notunuza, 100'den Fazla Değer Veremezsiniz !");
                            }
                        }

                        else
                        {
                            MessageBox.Show("2. Yazılı Notunuza, NEGATİF(-) Bir Değer Veremezsiniz  !");
                        }

                    }
                    else
                    {
                        MessageBox.Show("1. Yazılı Notunuza, 100'den Fazla Değer Veremezsiniz !");
                    }

                }
                else
                {
                    MessageBox.Show("1. Yazılı Notunuza, NEGATİF(-) Bir Değer Veremezsiniz !");
                }

            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen Uygun Bir NOT TİPİ Giriniz !");
            }
        }
    }
}
