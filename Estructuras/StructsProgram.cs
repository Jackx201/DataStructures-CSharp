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
    public partial class StructsForm : Form
    {
        struct libro
        {
            public int paginas;
            public string titulo;
            public double precio;
            public string autor;
            public int id;
        }

        public int identificador = 0;
        
        libro[] l = new libro[99];
        

        public StructsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            identificador = Convert.ToInt32(Buscador.Text);
            l[identificador].titulo = textBox1.Text;
            l[identificador].paginas = Convert.ToInt32(TXTBPaginas.Text);
            l[identificador].autor = TXTBAutor.Text;
            l[identificador].precio = Convert.ToDouble(TXTBPrecio.Text);
            l[identificador].id = Convert.ToInt32(Buscador.Text);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            identificador = Convert.ToInt32(Buscador.Text);
            textBox1.Text = l[identificador].titulo;
            TXTBPaginas.Text = l[identificador].paginas.ToString();
            TXTBAutor.Text = l[identificador].autor;
            TXTBPrecio.Text = l[identificador].precio.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show(this);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show(this);
            this.Hide();
        }
    }
}
