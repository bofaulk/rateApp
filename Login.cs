using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateApp
{
    

    public partial class Login : Form
    {

        private Form1 senderForm;

        public Login(Form1 form)
        {
            InitializeComponent();
            senderForm = form;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text;

                if (password != "")
                {
                    if (password == "lipsey2018!")
                    {
                        //Upload up = new Upload();
                        //up.Show();

                        senderForm.Admin = true;
                        senderForm.buildForm();

                        //form.Admin = true;
                        //form.buildForm();
                        this.Close();
                    }
                    else
                    {
                        txtPassword.Text = "";
                        MessageBox.Show("The password you entered is invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a password to continue.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.buildForm();

            //Form1 form = new Form1();
            //form.buildForm();
            //Application.Run(form);
            senderForm.Admin = false;
            this.Close();
        }
    }
}
