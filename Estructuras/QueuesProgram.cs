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
    public partial class Queues : Form
    {
        int idjugador = 0;
        Queue<string> jugadores = new Queue<string>();

        public Queues()
        {
            InitializeComponent();
        }

        private void Enqueuebutton_Click(object sender, EventArgs e)
        {
            jugadores.Enqueue(username.Text);
            MessageBox.Show("El usuario: " + username.Text + " ha sido agregado a la fila.");
            QueuedPlayerDisplay();
            username.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jugadores.Enqueue("Jackx201");
            jugadores.Enqueue("WongUchija27");
            jugadores.Enqueue("DarnllSlayer616");
            jugadores.Enqueue("RomeroKiller777");
            jugadores.Enqueue("EmilKingxX20");
            jugadores.Enqueue("XxAdrianDestroyerxX");
            Nombre.Text = "©Zahúl Guadalupe Domínguez Chávez. \nING. David Rodriguez Ceballos. \n12/04/2021 - 4B. \nEstructuras de datos.";

            QueuedUsersTextBox.Text += "\n";


            foreach (var usuario in jugadores)
            {
                idjugador ++;
                QueuedUsersTextBox.Text += "\n Jugador " + idjugador + ": " + usuario + "\n";
            }
            QueuedUsersTextBox.Text += "\n-----------------------";
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            if(jugadores.Count == 0)
            {
                MessageBox.Show("No hay jugadores en espera:");
            } else {
                MessageBox.Show("El jugador: " + jugadores.Peek() + " encabeza la fila");
                QueuedPlayerDisplay();
            }
        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            if (jugadores.Count == 0)
            {
                MessageBox.Show("No hay jugadores en espera:");
            }
            else
            {
                string jugador = jugadores.Dequeue();
                MessageBox.Show("El jugador: " + jugador + " ha abandonado la fila y ha entrado al servidor");
                QueuedPlayerDisplay();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            jugadores.Clear();
            MessageBox.Show("Todos los jugadores han sido expulsados");
            QueuedPlayerDisplay();
        }

        void QueuedPlayerDisplay()
        {
            QueuedUsersTextBox.Text = "-----------------------\n";
            idjugador = 0;
            foreach (var usuario in jugadores)
            {
                idjugador++;
                QueuedUsersTextBox.Text += "\n Jugador " + idjugador + ": " + usuario + "\n";
            }
            QueuedUsersTextBox.Text += "\n-----------------------";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show(this);
            this.Hide();
        }
    }
}
