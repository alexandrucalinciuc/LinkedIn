using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{

    public partial class Skills : Form
    {
        public static string skills;

        public Skills()
        {
            skills = null;
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (skills == null)
            {
                MessageBox.Show("No skill checked!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                this.Close();
        }
        
        private void sk1_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk1.ToString();
        }

        private void sk2_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk2.ToString();
        }

        private void sk3_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk3.ToString();
        }

        private void sk4_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk4.ToString();
        }

        private void sk5_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk5.ToString();
        }

        private void sk6_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk6.ToString();
        }

        private void sk7_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk7.ToString();
        }

        private void sk8_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk8.ToString();

        }

        private void sk9_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk9.ToString();

        }

        private void sk10_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk10.ToString();

        }

        private void sk11_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk11.ToString();

        }

        private void sk12_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk12.ToString();

        }

        private void sk13_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk13.ToString();

        }

        private void sk14_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk14.ToString();

        }

        private void sk15_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk15.ToString();

        }

        private void sk16_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk16.ToString();

        }

        private void sk29_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk29.ToString();

        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox48.ToString();

        }

        private void sk27_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk27.ToString();

        }

        private void sk28_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk28.ToString();

        }

        private void sk17_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk17.ToString();

        }

        private void sk18_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk18.ToString();

        }

        private void sk19_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk19.ToString();

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox44.ToString();

        }

        private void sk24_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk24.ToString();

        }

        private void sk20_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk20.ToString();

        }

        private void sk21_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk21.ToString();

        }

        private void sk32_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk32.ToString();

        }

        private void sk31_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk3.ToString();

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox43.ToString();

        }

        private void sk26_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk26.ToString();

        }

        private void sk23_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk23.ToString();

        }

        private void sk30_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk30.ToString();

        }

        private void sk22_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk22.ToString();

        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox46.ToString();

        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox40.ToString();

        }

        private void sk25_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk25.ToString();

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox45.ToString();

        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox41.ToString();

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox47.ToString();

        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox42.ToString();

        }
    }
}
