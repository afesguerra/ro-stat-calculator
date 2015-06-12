using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalkStats
{
    public partial class Kalk : Form
    {
        private int puntos = 0;
        public Kalk()
        {
            InitializeComponent();
            calc.Enabled = false;
            info.Enabled = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            calc.Enabled = true;
            info.Enabled = false;
            puntos = StatBuilder.build(Int32.Parse(""+level.Value), trans.Checked);
            points.Text = puntos + "";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            calc.Enabled = false;
            info.Enabled = true;
            Str.Value = 1;
            Agi.Value = 1;
            Vit.Value = 1;
            Int.Value = 1;
            Dex.Value = 1;
            Luk.Value = 1;
            points.Text = "";
            puntos = 0;
        }
        public void actualizar(object sender, EventArgs e)
        {
            int cuenta = puntos;
            for (int i = 2; i <= Str.Value; i++)
            {
                cuenta -= (int)Math.Ceiling((i-1) / 10.0) + 1;
            }
            for (int i = 2; i <= Agi.Value; i++)
            {
                cuenta -= (int)Math.Ceiling((i-1) / 10.0) + 1;
            }
            for (int i = 2; i <= Vit.Value; i++)
            {
                cuenta -= (int)Math.Ceiling((i-1) / 10.0) + 1;
            }
            for (int i = 2; i <= Int.Value; i++)
            {
                cuenta -= (int)Math.Ceiling((i-1) / 10.0) + 1;
            }
            for (int i = 2; i <= Dex.Value; i++)
            {
                cuenta -= (int)Math.Ceiling((i-1) / 10.0) + 1;
            }
            for (int i = 2; i <= Luk.Value; i++)
            {
                cuenta -= (int)Math.Ceiling((i-1) / 10.0) + 1;
            }
            points.Text = cuenta + "";
        }

        private void Kalk_Load(object sender, EventArgs e)
        {

        }
    }
}
