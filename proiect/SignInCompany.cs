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
    public partial class SignInCompany : Form
    {
        public static string companyname;
        public static string CEO;
        public static string addressC;
        public static string passC;
        public static string checkpassC;
        public static string phoneC;
        public static string emailC;
        public static string skillsC;
        public static int c_panel_skillsC = 0;

<<<<<<< HEAD
        public static string get_skillsC()
        {
            return skillsC;
        }

        public static bool IfExistsCompany(string company)
        {
            int ok = 0;
            var context = new LinkedinEntities();
            var results = from c in context.Companies
                          select new
                          {
                              c.Nume_companie
                          };

            foreach (var item in results)
            {
                if (item.Nume_companie.Equals(company))
                    ok = 1;
            }

            if (ok == 1)
                return true;

            return false;

        }

=======
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        public SignInCompany()
        {
            skillsC = null;
            InitializeComponent();
            panelSkills.Visible = false;

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            companyname = txtCompanyName.Text.ToString();
=======
            companyname = txtCompanyName.ToString();
            //aici bagati un if sa vedeti daca exita deja compania
            /* if (companyname.Equals(cineva))
             {
                 MessageBox.Show("Company already exist!",
                      "ERROR",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
             }*/
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtCEO_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            CEO = txtCEO.Text.ToString();
=======
            CEO = txtCEO.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            addressC = txtAddress.Text.ToString();
=======
            addressC = txtAddress.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtPassCompany_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            passC = txtPassCompany.Text.ToString();
=======
            passC = txtPassCompany.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtCheckPassCompany_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            checkpassC = txtCheckPassCompany.Text.ToString();
        }


        private void txtEmailCompany_TextChanged(object sender, EventArgs e)
        {
            emailC = txtEmailCompany.Text.ToString();
=======
            checkpassC = txtCheckPassCompany.ToString();
            if (passC.Equals(checkpassC)==false)
            {
                MessageBox.Show("Password dosen't match",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }

        private void txtEmailCompany_TextChanged(object sender, EventArgs e)
        {
            emailC = txtEmailCompany.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtPhoneCompany_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            phoneC = txtPhoneCompany.Text.ToString();
=======
            phoneC = txtPassCompany.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void btNextCompany_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            if (companyname != null && IfExistsCompany(companyname) == true)
            {
                MessageBox.Show("Company already exist!",
                "ERROR",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            else if (passC != null && checkpassC != null && passC.Equals(checkpassC) == false)
            {
                MessageBox.Show("Password dosen't match",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
            else if (companyname != null && CEO != null
                        && addressC != null && phoneC != null
                        && emailC != null && skillsC != null
                        && passC != null && checkpassC != null)
=======
            if (companyname != null && CEO != null
                && addressC != null && phoneC != null
                && emailC != null && skillsC != null
                && passC != null && checkpassC != null)
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
            {
                MessageBox.Show("Register successfully",
                     "Information",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                this.Close();
<<<<<<< HEAD
                CCompanie.inregistreaza_companie(CEO, companyname, addressC, emailC, phoneC, passC);
                Form form = new CCompanie(CEO, companyname, addressC, emailC, phoneC, get_skillsC());
                form.Show();
            }

=======
                Form form = new Companie();
                form.Show();
            }
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
            else
            {
                MessageBox.Show("Some empty filled!",
                     "ERROR",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void btSkillsC_Click(object sender, EventArgs e)
        {
            if (c_panel_skillsC % 2 == 0)
                panelSkills.Visible = true;
            else
                panelSkills.Visible = false;
            c_panel_skillsC++;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                MessageBox.Show("No skill checked!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                panelSkills.Visible = false;
        }

        private void checkBox45_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox45.Text.ToString();
            }
            else
                skillsC += "," + checkBox45.Text.ToString();
=======
            skillsC += "," + checkBox45.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox42_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox42.Text.ToString();
            }
            else
                skillsC += "," + checkBox42.Text.ToString();
=======
            skillsC += "," + checkBox42.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox47_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox47.Text.ToString();
            }
            else
                skillsC += "," + checkBox47.Text.ToString();
=======
            skillsC += "," + checkBox47.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox41_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox41.Text.ToString();
            }
            else
                skillsC += "," + checkBox41.Text.ToString();
=======
            skillsC += "," + checkBox41.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk25_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk25.Text.ToString();
            }
            else
                skillsC += "," + sk25.Text.ToString();
=======
            skillsC += "," + sk25.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox40_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox40.Text.ToString();
            }
            else
                skillsC += "," + checkBox40.Text.ToString();
=======
            skillsC += "," + checkBox40.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox46_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox46.Text.ToString();
            }
            else
                skillsC += "," + checkBox46.Text.ToString();
=======
            skillsC += "," + checkBox46.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk22_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk22.Text.ToString();
            }
            else
                skillsC += "," + sk22.Text.ToString();
=======
            skillsC += "," + sk22.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk30_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk30.Text.ToString();
            }
            else
                skillsC += "," + sk30.Text.ToString();
=======
            skillsC += "," + sk30.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk23_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk23.Text.ToString();
            }
            else
                skillsC += "," + sk23.Text.ToString();
=======
            skillsC += "," + sk23.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk26_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk26.Text.ToString();
            }
            else
                skillsC += "," + sk26.Text.ToString();
=======
            skillsC += "," + sk26.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox43_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox43.Text.ToString();
            }
            else
                skillsC += "," + checkBox43.Text.ToString();
=======
            skillsC += "," + checkBox43.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk31_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk31.Text.ToString();
            }
            else
                skillsC += "," + sk31.Text.ToString();
=======
            skillsC += "," + sk32.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk32_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk32.Text.ToString();
            }
            else
                skillsC += "," + sk32.Text.ToString();
=======
            skillsC += "," + sk32.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk21_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk21.Text.ToString();
            }
            else
                skillsC += "," + sk21.Text.ToString();
=======
            skillsC += "," + sk21.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk20_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk20.Text.ToString();
            }
            else
                skillsC += "," + sk20.Text.ToString();
=======
            skillsC += "," + sk20.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk24_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk24.Text.ToString();
            }
            else
                skillsC += "," + sk24.Text.ToString();
=======
            skillsC += "," + sk24.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox44_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox44.Text.ToString();
            }
            else
                skillsC += "," + checkBox44.Text.ToString();
=======
            skillsC += "," + checkBox44.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox39.Text.ToString();
            }
            else
                skillsC += "," + checkBox39.Text.ToString();
=======
            skillsC += "," + checkBox39.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk19_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk19.Text.ToString();
            }
            else
                skillsC += "," + sk19.Text.ToString();
=======
            skillsC += "," + sk19.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk18_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk18.Text.ToString();
            }
            else
                skillsC += "," + sk18.Text.ToString();
=======
            skillsC += "," + sk18.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk17_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk17.Text.ToString();
            }
            else
                skillsC += "," + sk17.Text.ToString();
=======
            skillsC += "," + sk17.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk28_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk28.Text.ToString();
            }
            else
                skillsC += "," + sk28.Text.ToString();
=======
            skillsC += "," + sk28.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk27_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk27.Text.ToString();
            }
            else
                skillsC += "," + sk27.Text.ToString();
=======
            skillsC += "," + sk27.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void checkBox48_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = checkBox48.Text.ToString();
            }
            else
                skillsC += "," + checkBox48.Text.ToString();
=======
            skillsC += "," + checkBox48.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk29_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk29.Text.ToString();
            }
            else
                skillsC += "," + sk29.Text.ToString();
=======
            skillsC += "," + sk29.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk16_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk16.Text.ToString();
            }
            else
                skillsC += "," + sk16.Text.ToString();
=======
            skillsC += "," + sk16.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk14_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk14.Text.ToString();
            }
            else
                skillsC += "," + sk14.Text.ToString();
=======
            skillsC += "," + sk14.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk13_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk13.Text.ToString();
            }
            else
                skillsC += "," + sk13.Text.ToString();
=======
            skillsC += "," + sk13.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk12_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk12.Text.ToString();
            }
            else
                skillsC += "," + sk12.Text.ToString();
=======
            skillsC += "," + sk12.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk11_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk11.Text.ToString();
            }
            else
                skillsC += "," + sk11.Text.ToString();
=======
            skillsC += "," + sk11.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk10_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk10.Text.ToString();
            }
            else
                skillsC += "," + sk10.Text.ToString();
=======
            skillsC += "," + sk10.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk9_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk9.Text.ToString();
            }
            else
                skillsC += "," + sk9.Text.ToString();
=======
            skillsC += "," + sk9.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk8_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk8.Text.ToString();
            }
            else
                skillsC += "," + sk8.Text.ToString();
=======
            skillsC += "," + sk8.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk7_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk7.Text.ToString();
            }
            else
                skillsC += "," + sk7.Text.ToString();
=======
            skillsC += "," + sk7.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk6_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk6.Text.ToString();
            }
            else
                skillsC += "," + sk6.Text.ToString();
=======
            skillsC += "," + sk6.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk5_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk5.Text.ToString();
            }
            else
                skillsC += "," + sk5.Text.ToString();
=======
            skillsC += "," + sk5.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk4_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk4.Text.ToString();
            }
            else
                skillsC += "," + sk4.Text.ToString();
=======
            skillsC += "," + sk4.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk3_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk3.Text.ToString();
            }
            else
                skillsC += "," + sk3.Text.ToString();
=======
            skillsC += "," + sk3.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk2_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk2.Text.ToString();
            }
            else
                skillsC += "," + sk2.Text.ToString();
=======
            skillsC += "," + sk2.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void sk1_CheckedChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (skillsC == null)
            {
                skillsC = sk1.Text.ToString();
            }
            else
                skillsC += "," + sk1.Text.ToString();
        }
    }
}

=======
            skillsC += "," + sk1.ToString();
        }
    }
}
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
