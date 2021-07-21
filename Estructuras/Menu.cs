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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DatosLabel.Text = "Zahúl Guadalupe Domínguez Chávez \nING. David Rodríguez Ceballos \nCuarto cuatrimestre - Sección B \n13 de abril del 2021";
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ArreglosBoton_Click(object sender, EventArgs e)
        {
            Arreglos Arreglos = new Arreglos();
            Arreglos.Show(this);
            this.Hide();
        }

        private void StackButton_Click(object sender, EventArgs e)
        {
            Stacks Stacks = new Stacks();
            Stacks.Show(this);
            this.Hide();
        }

        private void QueuesButton_Click(object sender, EventArgs e)
        {
            Queues Queues = new Queues();
            Queues.Show(this);
            this.Hide();
        }

        private void StructButton_Click(object sender, EventArgs e)
        {
            StructsForm structsForm = new StructsForm();
            structsForm.Show(this);
            this.Hide();
        }

        private void HashTablesButton_Click(object sender, EventArgs e)
        {
            HashTables hashTables = new HashTables();
            hashTables.Show(this);
            this.Hide();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zahúl Guadalupe Domínguez Chávez \nING. David Rodríguez Ceballos \nCuarto cuatrimestre - Sección B \n13 de abril del 2021");
            
            //DatosLabel.Visible = true;
        }
    }
}
