using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_organização
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            pessoas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salas salas = new Salas();
            salas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EspacoDeCafe espacodecafe = new EspacoDeCafe();
            espacodecafe.ShowDialog();
        }
    }
}
