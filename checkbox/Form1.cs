using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckb01_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb01.Checked == true) 
            {
                MessageBox.Show("Ativo!");
                ckb01.Text = "Ativo!";
            }
            else
            {
                MessageBox.Show("Desativado!");
                ckb01.Text = "Desativado!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // mudar  o nome do elemento radio
            rdb1.Text = "Ativo";
            rdb02.Text = "Desativado!";
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(rdb1.Checked.ToString());
        }

        private void rdb02_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(rdb02.Checked));
        }

        private void ver(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
