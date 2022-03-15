using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Usado para tocar um WAV 
using System.Media;

namespace Despertador
{
    public partial class forms : Form
    {
        public forms() // construtor da Classe form1 - despertador 
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrAtual_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString().ToString();
            
            if(chkAtivar.Checked)
            {
                if (lblHoraAtual.Text == mskDespertar.Text)
                {
                    SoundPlayer som = new SoundPlayer(@"c:\windows\media\alarm01.wav");
                    som.PlayLooping();
                    MessageBox.Show("Hora de despertar!!");
                }
            }
        }

        private void mskDespertar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
    }
}
