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
    public partial class ForgotPassword : Form
    {
        string emailForgot;
        string phoneForgot;
        string newPass;
        string checkPass;
<<<<<<< HEAD
        static string client_companie;

        public static bool IfExists(string mail, string phone)
        {
            int ok = 0;
            var context = new LinkedinEntities();
            var results = from c in context.Clients
                          select new
                          {
                              c.Telefon,
                              c.Email
                          };

            foreach (var item in results)
            {
                if (item.Telefon.Equals(phone) && item.Email.Equals(mail))
                {
                        ok = 1;
                       client_companie = "client";
                }
            }

            var results1 = from c in context.Companies
                           select new
                           {
                               c.Telefon_companie,
                               c.Email_companie
                           };

            foreach (var item in results1)
            {
                if (item.Telefon_companie.Equals(phone) && item.Email_companie.Equals(mail))
                {
                    ok = 1;
                    client_companie = "companie";
                }
            }

            if (ok == 1)
                return true;
            return false;

        }
=======
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b


        public ForgotPassword()
        {
            InitializeComponent();

            panelForgot.Visible = true;
            panelPassword.Visible = false;
            btOk1.Visible = true;
            btOk2.Visible = false;
        }

        //txtEmailForgot
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            emailForgot = txtEmailForgot.Text.ToString();
=======
            emailForgot = txtEmailForgot.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        //txtPhoneForgot
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            phoneForgot = txtPhoneForgot.Text.ToString();
=======
            phoneForgot = txtPhoneForgot.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtNewForgotPass_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            newPass = txtNewForgotPass.Text.ToString();
=======
            newPass = txtNewForgotPass.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtConfirmForgotPass_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            checkPass = txtConfirmForgotPass.Text.ToString();
=======
            checkPass = txtConfirmForgotPass.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void btOk_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if(IfExists(emailForgot, phoneForgot) == true)
            {
=======
            //aici verificati daca mailul si telefonul corespund, daca da intra in if
            if (emailForgot.Equals(phoneForgot)){

                //astea de jos sunt doar design
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
                panelForgot.Visible = false;
                panelPassword.Visible = true;
                btOk1.Visible = false;
                btOk2.Visible = true;
            }
            else
            {
                MessageBox.Show("Email or phone not corresponding",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btOk2_Click(object sender, EventArgs e)
        {
            if (newPass.Equals(checkPass))
            {
<<<<<<< HEAD
                string hash = CClient.SecurePasswordHasher.Hash(newPass);
                if (client_companie == "client")
                {
                    var context = new LinkedinEntities();
                    var emailClient = (from c in context.Clients
                                       where c.Email.Equals(emailForgot)
                                       select c).First();
                    emailClient.Parola = hash;
                    context.SaveChanges();

                }
                else if (client_companie == "comapanie")
                {
                    var context1 = new LinkedinEntities();
                    var emailCompanie = (from c in context1.Companies
                                         where c.Email_companie.Equals(emailForgot)
                                         select c).First();
                    if (emailCompanie != null)
                    {
                        emailCompanie.ParolaC = hash;
                        context1.SaveChanges();
                    }
                }

=======
                //aici modificati voi in baza de date;
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
                MessageBox.Show("New password was set",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                this.Close();
            } else
            {
                MessageBox.Show("Password doesn't match",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
