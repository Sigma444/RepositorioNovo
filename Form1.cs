using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button(object sender, EventArgs e)
        {

            int score = int.Parse(placar_fla.Text) +1;
            placar_fla.Text = score.ToString();
            
            
            

        }

        private void Bt_menosfla(object sender, EventArgs e)
        {
            int score = int.Parse(placar_fla.Text);
            if (score > 0)
            {
                score--;
                placar_fla.Text = score.ToString();
            }

            
        }
        private void Bt_maissp(object sender, EventArgs e)
        {
            int score = int.Parse(placar_sp.Text) +1;
             placar_sp.Text = score.ToString();
            

            
        }

        private void Bt_menossp(object sender, EventArgs e)
        {
            int score = int.Parse(placar_sp.Text);
            if (score > 0)
            {
                score--;
                placar_sp.Text = score.ToString();
            }

            
        }

        int min = 0; int seg = 0;
        

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            lbl_tempo.Text = min + ":" + seg;
            seg++;
            if (seg == 60) 
            {
                min++;
                seg = 0;
            }
        }

    }
}
