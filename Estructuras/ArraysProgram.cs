using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Arreglos : Form
    {
        string[] a1 = new string[27];

        public Arreglos()
        {
            InitializeComponent();
            a1[0] = "A";
            a1[1] = "B";
            a1[2] = "C";
            a1[3] = "D";
            a1[4] = "E";
            a1[5] = "F";
            a1[6] = "G";
            a1[7] = "H";
            a1[8] = "I";
            a1[9] = "J";
            a1[10] = "K";
            a1[11] = "L";
            a1[12] = "M";
            a1[13] = "N";
            a1[14] = "Ñ";
            a1[15] = "O";
            a1[16] = "P";
            a1[17] = "Q";
            a1[18] = "R";
            a1[19] = "S";
            a1[20] = "T";
            a1[21] = "U";
            a1[22] = "V";
            a1[23] = "W";
            a1[24] = "X";
            a1[25] = "Y";
            a1[26] = "Z";
        }






        private void Arreglos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string m1, code, letra, crypt;
            int z1, clave;
            code = "";
            m1 = textBox1.Text;
            z1 = m1.Length;
            letra = "";
            crypt = "";
            clave = Convert.ToInt32(textBox4.Text);

            for (int i = 0; i < z1; i++)
            {
                letra = m1.Substring(i, 1);

                for (int k = 0; k < 27; k++)
                {
                    if (letra == a1[k])
                    {
                        //MessageBox.Show(k.ToString()); --Monitoreo
                        if (k < clave)
                        {
                            code = a1[27 + k - clave];
                        }
                        else
                        {
                            code = a1[k - clave];
                        }
                        clave = k;
                    }
                    if (letra == " ")
                    {
                        code = "°";
                    }
                }
                crypt += code;
            }
            textBox2.Text = crypt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string m1, code, letra, crypt;
            int z1, clave;
            code = "";
            m1 = textBox2.Text;
            z1 = m1.Length;
            letra = "";
            crypt = "";
            clave = Convert.ToInt32(textBox4.Text);

            for (int i = 0; i < z1; i++)
            {
                letra = m1.Substring(i, 1);
                for (int k = 0; k < 27; k++)
                {
                    if (letra == a1[k])
                    {
                        clave = k + clave;
                        //MessageBox.Show(clave.ToString()); - - Monitoreo
                        if (clave >= 27)
                        {
                            clave = (-27 + clave);

                            if (clave >= 27)
                            {
                                clave = (clave - 27);
                            }
                            code = a1[clave];
                        }
                        else
                        {
                            code = a1[clave];
                        }
                    }
                    if (letra == "°")
                    {
                        code = " ";
                    }
                }
                crypt += code;
            }
            textBox3.Text = crypt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show(this);
            this.Hide();
        }
    }
}
