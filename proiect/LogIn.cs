﻿using System;
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
    public partial class Log_page : Form
    {
        string username;
        string password;
<<<<<<< HEAD
        static string skill;
        static string skillC;

        public static string skills(int id_client)
        {
            using (var context = new LinkedinEntities())
            {
                var results = context.Clients.Include("Aptitudinis").Where(s => s.ID_Client == id_client).FirstOrDefault<Client>();

                foreach (var item in results.Aptitudinis)
                {
                    skill += item.Aptitudine;
                    skill += ",";
                }
            }
            return skill;
        }

        public static string skillsC(int id_companie)
        {
            using (var context = new LinkedinEntities())
            {
                var results = context.Companies.Include("Aptitudinis").Where(s => s.ID_Companie == id_companie).FirstOrDefault<Companie>();

                foreach (var item in results.Aptitudinis)
                {
                    skillC += item.Aptitudine;
                    skillC += ",";
                }
            }
            return skillC;
        }

        public static bool IfCompany(string user, string pass)
        {
            int ok = 0;
            var context = new LinkedinEntities();
            var results = from c in context.Companies
                          select new
                          {
                              c.UsernameC,
                              c.ParolaC,
                              c.Email_companie
                          };

            foreach (var item in results)
            {
                if (item.UsernameC.Equals(user) || item.Email_companie.Equals(user))
                {
                    if (CCompanie.SecurePasswordHasher.Verify(pass, item.ParolaC))
                        ok = 1;
                }
            }

            if (ok == 1)
                return true;
            return false;
        }

        public static bool IfClient(string user, string pass)
        {
            int ok = 0;
            var context = new LinkedinEntities();
            var results = from c in context.Clients
                          select new
                          {
                              c.Username,
                              c.Parola,
                              c.Email
                          };

            foreach (var item in results)
            {
                if (item.Username.Equals(user) || item.Email.Equals(user))
                {
                    if (CClient.SecurePasswordHasher.Verify(pass, item.Parola))
                        ok = 1;
                }
            }

            if (ok == 1)
                return true;
            return false;

        }
=======
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        public Log_page()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Log_page_Load(object sender, EventArgs e)
        {

        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            //verificari de user si pass
            if (password == null || username == null)
            {
<<<<<<< HEAD
                if (password == null && username != null)
=======
                if (password == null && username!=null)
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
                {
                    MessageBox.Show("Please write the password",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
<<<<<<< HEAD
                }
                else if (username == null && password != null)
=======
                    username = null;
                    password = null;
                }
                else if(username == null && password!=null)
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
                {
                    MessageBox.Show("Please write the username",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
<<<<<<< HEAD
=======
                    username = null;
                    password = null;
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
                }
                else
                {
                    MessageBox.Show("Please write the username and the password",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
<<<<<<< HEAD
                }
            }
            else if (username != null && password != null)
            {
                username = txtUsername.Text.ToString();
                password = txtPassoword.Text.ToString();

                if (IfCompany(username, password) == true)
                {
                    var context = new LinkedinEntities();
                    var results = from c in context.Companies
                                  where c.UsernameC.Equals(username)
                                  select new
                                  {
                                      c.ID_Companie,
                                      c.Director_companie,
                                      c.Adresa_companie,
                                      c.Email_companie,
                                      c.Telefon_companie
                                  };

                    foreach (var item in results)
                    {
                       string director = item.Director_companie;
                       string adresa = item.Adresa_companie;
                       string email = item.Email_companie;
                       string telefon = item.Telefon_companie;
                       int id_companie = item.ID_Companie;

                        Form form = new CCompanie(director, username, adresa, email, telefon, skillsC(id_companie));
                        form.Show();
                        this.Hide();
                    }


                }
                else if (IfClient(username, password) == true)
                {
                    var context = new LinkedinEntities();
                    var results = from c in context.Clients
                                  where c.Username.Equals(username)
                                  select new
                                  {
                                      c.ID_Client,
                                      c.Nume,
                                      c.Prenume,
                                      c.Data_Nasterii,
                                      c.Email,
                                      c.Poza,
                                      c.Facultate_absolvita,
                                      c.ID_sex,
                                      c.ID_statut_social,
                                      c.Adresa,
                                      c.Telefon,
                                      c.Nationalitate,
                                      c.Limbi_straine
                                  };

                    foreach (var item in results)
                    {
                        string nume = item.Nume;
                        string prenume = item.Prenume;
                        string email = item.Email;
                        string facultate = item.Facultate_absolvita;
                        string adresa = item.Adresa;
                        string telefon = item.Telefon;
                        string nationalitate = item.Nationalitate;
                        string limbi_straine = item.Limbi_straine;
                        string data = Convert.ToString(item.Data_Nasterii);
                        int id_client = item.ID_Client;
                        string sex;
                        string statut = null;
                        if (item.ID_sex.Equals(1))
                            sex = "Male";
                        else sex = "Female";

                        if (item.ID_statut_social.Equals(1))
                            statut = "Single";
                        else if (item.ID_statut_social.Equals(2))
                            statut = "In a relationship";
                        else if (item.ID_statut_social.Equals(3))
                            statut = "It's complicated";
                        else if (item.ID_statut_social.Equals(4))
                            statut = "Widow";
                        else if (item.ID_statut_social.Equals(5))
                            statut = "Divorced";
                        else if (item.ID_statut_social.Equals(6))
                            statut = "Marriage";

                        Form form = new CClient(nume, prenume, username, telefon, email, data, facultate, adresa, sex, statut, nationalitate, skills(id_client));
                        form.Show();
                       this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username or password invalid",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
=======
                    username = null;
                    password = null;
                }
            }
            else if(username !=null && password !=null)
            {
                //aici verificati daca parola corespunde userului
                //conditia mea e doar de test
                if (username.Equals(password) == false)
                {
                    MessageBox.Show("Username or password incorect",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    username = null;
                    password = null;
                }
                else
                {
                    //aici porneste pagina principala daca a trecut de log in si e client
                    
                        Form form1 = new Client();
                        form1.Show();
                        this.Hide();
                    
                    //aici daca e companie
                        /*Form form= new Companie();
                        form.Show();
                        this.Hide();*/
                    
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //parola uitata
            Form form2 = new ForgotPassword();
            form2.ShowDialog();
        }

        private void lbSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sign in client
            Form form3 = new SignIn();
            form3.ShowDialog();
<<<<<<< HEAD

=======
            
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }


        private void lbNewCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sign in companie
            Form form4 = new SignInCompany();
            form4.ShowDialog();
<<<<<<< HEAD

=======
            
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        }

        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.ToString();
        }

        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = txtPassoword.ToString();
        }

    }
}
<<<<<<< HEAD

=======
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
