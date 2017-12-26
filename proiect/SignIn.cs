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
    public partial class SignIn : Form
    {
        static string firstname;
        static string lastname;
        static string username;
        static string pass;
        static string checkpass;
        static string phone;
        static string email;
        static string date;
        static string universiy;
        static string adress;
        static string sex;
        static string status;
        static string nationality;

        public SignIn()
        {
            InitializeComponent();
            //btNextClient.Visible = false;
            pbProfile.Image = Image.FromFile("profile.png");

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
           
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstname = txtFirstName.ToString();
           
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lastname = txtLastName.ToString();
           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtLastName.ToString();

            //aci se faci verificarea daca exista in baza de date
            //trebuie ceva "live", adica gen dupa ce ai scris ceva in camp si ai trecut mai departe sa iti zica daca e bun sau nu
            //poate gasiti voi si ma ocup eu de cum sa arate eroare
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            pass = txtPass.ToString();
            //aici putem sa facem verificari d-alea cu cel putin litera mare, un numa un caracter...
            
        }

        private void txtCheckPass_TextChanged(object sender, EventArgs e)
        {
            checkpass = txtCheckPass.ToString();
            if (pass.Equals(checkpass))
            {
                //staf
              
            }
            

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.ToString();
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.ToString();
            
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register successfully",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
            Form form = new Client();
            form.Show();
        }

        private void txtUniversity_TextChanged(object sender, EventArgs e)
        {
            universiy = txtUniversity.ToString();
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            adress = txtAdress.ToString();
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = cbSex.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cbSex.ToString();
        }

        private void btPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.jpeg *.png *.jpg |All| *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = cbDay.ToString();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = date + ":" + cbMonth.ToString();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = date + ":" + cbYear.ToString();
        }

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationality = cbNationality.ToString();
        }

        private void btSkills_Click(object sender, EventArgs e)
        {
            Form form = new Skills();
            form.ShowDialog();
        }
    }
}
