using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class HashTables : Form
    {
        public int Id = 0;
        Hashtable TablaUsuarios = new Hashtable();

        public HashTables()
        {
            InitializeComponent();
            DatosLabel.Text = "Zahúl Guadalupe Domínguez Chávez \nEstructuras de datos aplicadas \nING. David Rodríguez Ceballos \n13 de abril de 2021";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(IdTextBox.Text);
            if (TablaUsuarios.ContainsKey(Id))
            {
                MessageBox.Show("Esta Posición ya está ocupada");
                return;
            }
            TablaUsuarios.Add(Convert.ToInt32(IdTextBox.Text), ValueTextBox.Text);
            Id = Convert.ToInt32(IdTextBox.Text) + 1;
            IdTextBox.Text = Id.ToString();
            Display();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(IdTextBox.Text);
            if (!TablaUsuarios.ContainsKey(Id))
            {
                MessageBox.Show("Esta Posición no tiene nada");
                return;
            }
            DisplayLabel.Text = TablaUsuarios[Convert.ToInt32(IdTextBox.Text)].ToString();
        }

        private void Display()
        {
            DisplayLabel.Text = "";
            ValueTextBox.Text = "";
            DisplayLabel.Text += "-----------------------------";

            foreach (DictionaryEntry elemento in TablaUsuarios)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
                DisplayLabel.Text += "\n" + (elemento.Key, elemento.Value).ToString();
            }
            DisplayLabel.Text += "\n-----------------------------";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(IdTextBox.Text);
            if (!TablaUsuarios.ContainsKey(Id))
            {
                MessageBox.Show("Esta Posición no tiene nada");
                return;
            }

            TablaUsuarios.Remove(Convert.ToInt32(IdTextBox.Text));
            Id = Convert.ToInt32(IdTextBox.Text) + 1;
            IdTextBox.Text = Id.ToString();
            Display();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show(this);
            this.Hide();
        }
    }
}
