using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Emaildogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngırısyap_Click(object sender, EventArgs e)
        {
            {
                var emailRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                Regex sifreRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

                string email = txtEmail.Text;
                string sifre = txtSifre.Text;

                if (!emailRegex.IsMatch(email))
                {
                    lblEmailDogrulama.Text = "Geçerli bir email adresi girin.";
                }
                if (!sifreRegex.IsMatch(sifre))
                {
                    lblSifre.Text = "Geçerli bir şifre girin.";
                }

                if (emailRegex.IsMatch(email) && sifreRegex.IsMatch(sifre))
                {
                    if (email == "info@yasin.com" && sifre == "Wf35!e5&")
                    {
                        MessageBox.Show("Hoş geldiniz!");
                    }
                    else
                    {
                        MessageBox.Show("Bilgilerinizin doğruluğunu kontrol edin");
                    }
                }

                txtEmail.Text = "";
                txtSifre.Text = "";
            }
        }
    }
}
