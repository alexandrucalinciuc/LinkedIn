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
<<<<<<< HEAD
        static Byte[] result;
        static int sex_id;
        static int status_id;

        public static bool IfExistsUsername(string username)
        {
            int ok = 0;
            var context = new LinkedinEntities();
            var results = from c in context.Clients
                          select new
                          {
                              c.Username
                          };

            foreach (var item in results)
            {
                if (item.Username.Equals(username))
                    ok = 1;
            }

            if (ok == 1)
                return true;

            return false;

        }

        public static bool IfExistsEmail(string mail)
        {
            int ok = 0;
            var context = new LinkedinEntities();
            var results = from c in context.Clients
                          select new
                          {
                              c.Email
                          };

            foreach (var item in results)
            {
                if (item.Email.Equals(mail))
                    ok = 1;
            }

            if (ok == 1)
                return true;

            return false;

        }
=======
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b

        public SignIn()
        {
            InitializeComponent();
            //btNextClient.Visible = false;
            pbProfile.Image = Image.FromFile("profile.png");

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
           
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            firstname = txtFirstName.Text.ToString();
=======
            firstname = txtFirstName.ToString();
           
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            lastname = txtLastName.Text.ToString();

=======
            lastname = txtLastName.ToString();
           
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            username = txtUsername.Text.ToString();
=======
            username = txtLastName.ToString();

            //aci se faci verificarea daca exista in baza de date
            //trebuie ceva "live", adica gen dupa ce ai scris ceva in camp si ai trecut mai departe sa iti zica daca e bun sau nu
            //poate gasiti voi si ma ocup eu de cum sa arate eroare
            
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            pass = txtPass.Text.ToString();
            //aici putem sa facem verificari d-alea cu cel putin litera mare, un numa un caracter...

=======
            pass = txtPass.ToString();
            //aici putem sa facem verificari d-alea cu cel putin litera mare, un numa un caracter...
            
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtCheckPass_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            checkpass = txtCheckPass.Text.ToString();
=======
            checkpass = txtCheckPass.ToString();
            if (pass.Equals(checkpass))
            {
                //staf
              
            }
            

>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            email = txtEmail.Text.ToString();

=======
            email = txtEmail.ToString();
            
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            phone = txtPhone.Text.ToString();

=======
            phone = txtPhone.ToString();
            
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void btNext_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (username != null && IfExistsUsername(username) == true)
            {
                MessageBox.Show("Username already exist!",
                "ERROR",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

            else if (pass != null && checkpass != null && pass.Equals(checkpass) == false)
            {
                MessageBox.Show("Password dosen't match",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }

            else if (email != null && IfExistsEmail(email) == true)
            {
                MessageBox.Show("Email already exist!",
                "ERROR",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

            else if (firstname != null && lastname != null
                && username != null && phone != null
                && email != null && status != null
                && pass != null && checkpass != null
                && date != null && universiy != null
                && adress != null && sex != null
                && nationality != null && Skills.get_skill() != null)
            {
                MessageBox.Show("Register successfully",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Close();
                CClient.inregistreaza_client(firstname, lastname, username, pass, phone, email, date, universiy, adress, sex_id, status_id, nationality, result);
                Form form = new CClient(firstname, lastname, username, phone, email, date, universiy, adress, sex, status, nationality, Skills.get_skill());
                form.Show();
            }
            else
            {
                MessageBox.Show("Some empty filled!",
                     "ERROR",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }

=======
            MessageBox.Show("Register successfully",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
            Form form = new Client();
            form.Show();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtUniversity_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            universiy = txtUniversity.Text.ToString();
=======
            universiy = txtUniversity.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            adress = txtAdress.Text.ToString();
=======
            adress = txtAdress.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            sex = cbSex.Text.ToString();
            if (sex.Equals("Male"))
                sex_id = 1;
            else sex_id = 2;
=======
            sex = cbSex.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            status = cbStatus.Text.ToString();
            if (status.Equals("Single"))
                status_id = 1;
            else if (status.Equals("In a relationship"))
                status_id = 2;
            else if (status.Equals("It's complicated"))
                status_id = 3;
            else if (status.Equals("Widow"))
                status_id = 4;
            else if (status.Equals("Divorced"))
                status_id = 5;
            else if (status.Equals("Marriage"))
                status_id = 6;
=======
            status = cbSex.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void btPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.jpeg *.png *.jpg |All| *.*";
<<<<<<< HEAD
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(ofd.FileName);
            }
            result = (Byte[])new ImageConverter().ConvertTo(pbProfile.Image, typeof(Byte[]));
=======
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(ofd.FileName);
            }
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            date = cbDay.Text.ToString();
=======
            date = cbDay.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            date = date + "/" + cbMonth.Text.ToString();
=======
            date = date + ":" + cbMonth.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            date = date + "/" + cbYear.Text.ToString();
=======
            date = date + ":" + cbYear.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            nationality = cbNationality.Text.ToString();
=======
            nationality = cbNationality.ToString();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }

        private void btSkills_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form forms = new Skills();
            forms.ShowDialog();
=======
            Form form = new Skills();
            form.ShowDialog();
>>>>>>> d58e1b2406af03e621f5e893ebafa7d330a9bc2b
        }
    }
}
