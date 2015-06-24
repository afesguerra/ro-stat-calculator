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
        }

        private int buildStats(int level, bool trans)
        {
            if (level < 1 || level > 99)
            {
                return 0;
            }

            int div = (int)Math.Ceiling(level / 5d) + 2;
            int mod = (level - 1) % 5 + 1;
            int prev = 5 * (((div - 1) * div) - 6) / 2;

            int stats = 45 + div * mod + prev;

            if (trans)
            {
                stats += 52;
            }
            return stats;
        }

        private int spentStats(int level)
        {
            int div = (int)Math.Ceiling(level / 10d) + 1;
            int mod = (level - 2) % 10 + 1;
            int prev = 10 * (((div - 1) * div) - 2) / 2;

            return div * mod + prev;
        }
        public void actualizar(object sender, EventArgs e)
        {
            int cuenta = buildStats(Int32.Parse("" + level.Value), trans.Checked);
            cuenta -= spentStats((int)Str.Value);
            cuenta -= spentStats((int)Agi.Value);
            cuenta -= spentStats((int)Vit.Value);
            cuenta -= spentStats((int)Int.Value);
            cuenta -= spentStats((int)Dex.Value);
            cuenta -= spentStats((int)Luk.Value);
            
            points.Text = cuenta + "";
        }

        private void Kalk_Load(object sender, EventArgs e)
        {
            points.Text = "48";
        }
    }
}
