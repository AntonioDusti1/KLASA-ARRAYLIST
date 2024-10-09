using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static KLASA_ARRAYLIST.Class1;

namespace KLASA_ARRAYLIST
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            textBoxNovi.Enabled = false;
            buttonUnesi.Enabled = false;
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            textBoxNovi.Enabled = true;
            buttonUnesi.Enabled = true;
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(textBoxNovi.Text);
            listaAutomobila.Add(a);
            richTextBox1.AppendText(listaAutomobila.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");
            textBoxNovi.Enabled = false;
            buttonUnesi.Enabled = false;
            textBoxNovi.Clear();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            listaAutomobila.Clear();
            richTextBox1.Clear();
        }
    }
}
