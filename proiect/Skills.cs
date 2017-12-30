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
<<<<<<< HEAD
        public static string skills_id;

        public static string get_skill()
        {
            return skills;
        }

        public static string get_skills_id()
        {
            return skills_id;
        }
=======
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

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
<<<<<<< HEAD
            {
                this.Close();
            }
        }

        private void sk1_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk1.Text.ToString();
                skills_id = "1";
            }
            else
            {
                skills += "," + sk1.Text.ToString();
                skills_id += " " + "1";
            }
=======
                this.Close();
        }
        
        private void sk1_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk1.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk2_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk2.Text.ToString();
                skills_id = "2";
            }
            else
            {
                skills += "," + sk2.Text.ToString();
                skills_id += " " + "2";
            }
=======
            skills += "," + sk2.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk3_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk3.Text.ToString();
                skills_id = "3";
            }
            else
            {
                skills += "," + sk3.Text.ToString();
                skills_id += " " + "3";
            }
=======
            skills += "," + sk3.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk4_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk4.Text.ToString();
                skills_id = "4";
            }
            else
            {
                skills += "," + sk4.Text.ToString();
                skills_id += " " + "4";
            }
=======
            skills += "," + sk4.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk5_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk5.Text.ToString();
                skills_id = "5";
            }
            else
            {
                skills += "," + sk5.Text.ToString();
                skills_id += " " + "5";
            }
=======
            skills += "," + sk5.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk6_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk6.Text.ToString();
                skills_id = "6";
            }
            else
            {
                skills += "," + sk6.Text.ToString();
                skills_id += " " + "6";
            }
=======
            skills += "," + sk6.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk7_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk7.Text.ToString();
                skills_id = "7";
            }
            else
            {
                skills += "," + sk7.Text.ToString();
                skills_id += " " + "7";
            }
=======
            skills += "," + sk7.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk8_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk8.Text.ToString();
                skills_id = "8";
            }
            else
            {
                skills += "," + sk8.Text.ToString();
                skills_id += " " + "8";
            }
=======
            skills += "," + sk8.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk9_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk9.Text.ToString();
                skills_id = "9";
            }
            else
            {
                skills += "," + sk9.Text.ToString();
                skills_id += " " + "9";
            }
=======
            skills += "," + sk9.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk10_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk10.Text.ToString();
                skills_id = "10";
            }
            else
            {
                skills += "," + sk10.Text.ToString();
                skills_id += " " + "10";
            }
=======
            skills += "," + sk10.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk11_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk11.Text.ToString();
                skills_id = "11";
            }
            else
            {
                skills += "," + sk11.Text.ToString();
                skills_id += " " + "11";
            }
=======
            skills += "," + sk11.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk12_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk12.Text.ToString();
                skills_id = "12";
            }
            else
            {
                skills += "," + sk12.Text.ToString();
                skills_id += " " + "12";
            }
=======
            skills += "," + sk12.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk13_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk13.Text.ToString();
                skills_id = "13";
            }
            else
            {
                skills += "," + sk13.Text.ToString();
                skills_id += " " + "13";
            }
=======
            skills += "," + sk13.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk14_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk14.Text.ToString();
                skills_id = "14";
            }
            else
            {
                skills += "," + sk14.Text.ToString();
                skills_id += " " + "14";
            }
=======
            skills += "," + sk14.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk15_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk15.Text.ToString();
                skills_id = "15";
            }
            else
            {
                skills += "," + sk15.Text.ToString();
                skills_id += " " + "15";
            }
=======
            skills += "," + sk15.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk16_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk16.Text.ToString();
                skills_id = "16";
            }
            else
            {
                skills += "," + sk16.Text.ToString();
                skills_id += " " + "16";
            }
=======
            skills += "," + sk16.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk29_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk29.Text.ToString();
                skills_id = "17";
            }
            else
            {
                skills += "," + sk29.Text.ToString();
                skills_id += " " + "17";
            }
=======
            skills += "," + sk29.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox48.Text.ToString();
                skills_id = "18";
            }
            else
            {
                skills += "," + checkBox48.Text.ToString();
                skills_id += " " + "18";
            }
=======
            skills += "," + checkBox48.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk27_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk27.Text.ToString();
                skills_id = "19";
            }
            else
            {
                skills += "," + sk27.Text.ToString();
                skills_id += " " + "19";
            }
=======
            skills += "," + sk27.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk28_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk28.Text.ToString();
                skills_id = "20";
            }
            else
            {
                skills += "," + sk28.Text.ToString();
                skills_id += " " + "20";
            }
=======
            skills += "," + sk28.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk17_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk17.Text.ToString();
                skills_id = "21";
            }
            else
            {
                skills += "," + sk17.Text.ToString();
                skills_id += " " + "21";
            }
=======
            skills += "," + sk17.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk18_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk18.Text.ToString();
                skills_id = "22";
            }
            else
            {
                skills += "," + sk18.Text.ToString();
                skills_id += " " + "22";
            }
=======
            skills += "," + sk18.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk19_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk19.Text.ToString();
                skills_id = "23";
            }
            else
            {
                skills += "," + sk19.Text.ToString();
                skills_id += " " + "23";
            }
=======
            skills += "," + sk19.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox44.Text.ToString();
                skills_id = "25";
            }
            else
            {
                skills += "," + checkBox44.Text.ToString();
                skills_id += " " + "25";
            }
=======
            skills += "," + checkBox44.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk24_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk24.Text.ToString();
                skills_id = "26";
            }
            else
            {
                skills += "," + sk24.Text.ToString();
                skills_id += " " + "26";
            }
=======
            skills += "," + sk24.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk20_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk20.Text.ToString();
                skills_id = "27";
            }
            else
            {
                skills += "," + sk20.Text.ToString();
                skills_id += " " + "27";
            }
=======
            skills += "," + sk20.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk21_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk21.Text.ToString();
                skills_id = "28";
            }
            else
            {
                skills += "," + sk21.Text.ToString();
                skills_id += " " + "28";
            }
=======
            skills += "," + sk21.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk32_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk32.Text.ToString();
                skills_id = "29";
            }
            else
            {
                skills += "," + sk32.Text.ToString();
                skills_id += " " + "29";
            }
=======
            skills += "," + sk32.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk31_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk3.Text.ToString();
                skills_id = "30";
            }
            else
            {
                skills += "," + sk3.Text.ToString();
                skills_id += " " + "30";
            }
=======
            skills += "," + sk3.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox43.Text.ToString();
                skills_id = "31";
            }
            else
            {
                skills += "," + checkBox43.Text.ToString();
                skills_id += " " + "31";
            }
=======
            skills += "," + checkBox43.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk26_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk26.Text.ToString();
                skills_id = "32";
            }
            else
            {
                skills += "," + sk26.Text.ToString();
                skills_id += " " + "32";
            }
=======
            skills += "," + sk26.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk23_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk23.Text.ToString();
                skills_id = "33";
            }
            else
            {
                skills += "," + sk23.Text.ToString();
                skills_id += " " + "33";
            }
=======
            skills += "," + sk23.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk30_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk30.Text.ToString();
                skills_id = "34";
            }
            else
            {
                skills += "," + sk30.Text.ToString();
                skills_id += " " + "34";
            }
=======
            skills += "," + sk30.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk22_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk22.Text.ToString();
                skills_id = "35";
            }
            else
            {
                skills += "," + sk22.Text.ToString();
                skills_id += " " + "35";
            }
=======
            skills += "," + sk22.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox46.Text.ToString();
                skills_id = "36";
            }
            else
            {
                skills += "," + checkBox46.Text.ToString();
                skills_id += " " + "36";
            }
=======
            skills += "," + checkBox46.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox40.Text.ToString();
                skills_id = "37";
            }
            else
            {
                skills += "," + checkBox40.Text.ToString();
                skills_id += " " + "37";
            }
=======
            skills += "," + checkBox40.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void sk25_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = sk25.Text.ToString();
                skills_id = "38";
            }
            else
            {
                skills += "," + sk25.Text.ToString();
                skills_id += " " + "38";
            }
=======
            skills += "," + sk25.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox45.Text.ToString();
                skills_id = "39";
            }
            else
            {
                skills += "," + checkBox45.Text.ToString();
                skills_id += " " + "39";
            }
=======
            skills += "," + checkBox45.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox41.Text.ToString();
                skills_id = "40";
            }
            else
            {
                skills += "," + checkBox41.Text.ToString();
                skills_id += " " + "40";
            }
=======
            skills += "," + checkBox41.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox47.Text.ToString();
                skills_id = "41";
            }
            else
            {
                skills += "," + checkBox47.Text.ToString();
                skills_id += " " + "41";
            }
=======
            skills += "," + checkBox47.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skills == null)
            {
                skills = checkBox42.Text.ToString();
                skills_id = "42";
            }
            else
            {
                skills += "," + checkBox42.Text.ToString();
                skills_id += " " + "42";
            }

        }
        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox39.Text.ToString();
                skills_id = "24";
            }
            else
            {
                skills += "," + checkBox39.Text.ToString();
                skills_id += " " + "24";
            }
        }
    }
}


=======
            skills += "," + checkBox42.ToString();

        }
    }
}
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
