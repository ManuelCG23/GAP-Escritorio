using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaC
{
    public partial class Pruebas : Form
    {


        public Pruebas()
        {
            InitializeComponent();
        }

         Cifrado cifrar = new Cifrado();


        private void button1_Click(object sender, EventArgs e)
        {
            txtcifrado.Text = cifrar.cifrar(txt_normal.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_normal2.Text = cifrar.descifrar(txt_cifrada2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_cifrada2.Text = txtcifrado.Text;
        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            //textBox1.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString();
        }

    }
}
