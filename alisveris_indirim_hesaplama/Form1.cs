using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisveris_indirim_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double tutar;

        private void button1_Click(object sender, EventArgs e)
        {
            int kackitap = Convert.ToInt32(kitapAdet.Text);

            if (kackitap > 0 && kackitap <= 20)
            {
                tutar = (kackitap * 8) - (kackitap * 8 * 0.20);
                tutarLbl.Text = tutar + " TL";
            }
            else if (kackitap >= 21 && kackitap <= 40)
            {
                tutar = (kackitap * 8) - (kackitap * 8 * 0.40);
                tutarLbl.Text = tutar + " TL";
            }
            else if (kackitap >= 41)
            {
                tutar = (kackitap * 8) - (kackitap * 8 * 0.50);
                tutarLbl.Text = tutar + " TL";
            }
        }
    }
}
