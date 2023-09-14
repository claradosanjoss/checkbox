using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ImagemProjeto
{
    public partial class OutrofForm : Form
    {
        public OutrofForm()
        {
            InitializeComponent();
        }

        private void semborda_CheckedChanged(object sender, EventArgs e)
        {
            if (semborda.Checked)
            {
                pcb.BorderStyle = BorderStyle.None;
            }
        }

        private void img1_CheckedChanged(object sender, EventArgs e)
        {
            pcb.Image = Properties.Resources.bar;
        }

        private void img2_CheckedChanged(object sender, EventArgs e)
        {
            pcb.Image = Properties.Resources.meninaesquisita;
        }

        private void img3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Não há imagem!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                pcb.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                pcb.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você saiu!", "Sair", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OutrofForm_Load(object sender, EventArgs e)
        {

        }
    }
}
