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
    
    public partial class Stacks : Form
    {
        Stack<String> Pila = new Stack<String>();


        public Stacks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pila.Count == 0)
            {
                MessageBox.Show("Ahora mismo no tenemos ningún periódico, vuelva después");
            } else {
                string periodico1 = (string)Pila.Peek();
                MessageBox.Show(periodico1);
            }
            

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (nombreperiodico.Text == ""){
                MessageBox.Show("Lo sentimos, no recivimos periódicos sin nombre");
            } else {
                Pila.Push(nombreperiodico.Text);
            } 
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            if (Pila.Count == 0)
            {
                MessageBox.Show("Ahora mismo no tenemos ningún periódico, vuelva después");
            }
            else
            {
                string periodico1 = (string)Pila.Pop();
                MessageBox.Show("Usted se ha llevado el: " + periodico1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show(this);
            this.Hide();
        }
    }
}
