using NotDefteri_BL.Abstract;
using NotDefteri_BL.Repository_BL;
using NotDefteri_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteri_UI
{
    public partial class frmPassword : Form
    {
        User _user;
        private IUserService _userService;
        public frmPassword(User user)
        {
            InitializeComponent();
            _user = user;
            _userService = new UserManeger();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            //txtEskiSifre.Text = _user[0].Password;
           
        }
        private string SifreKontrol(string s1, string s2)
        {
            if (s1 == s2)
            {
                return s1;
            }
            else
            {
                return null;
            }

        }

        private void frmPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string s1 = SifreKontrol(txtYeniSifre.Text, txtYeniSifreTekrar.Text);
            if (s1 != null)
            {
                _userService.UserSifreGuncelle(_user, s1);
                MessageBox.Show("Şifreniz güncellenmiştir");
            }
            else
            {
                MessageBox.Show("Şifreler birbirleri ile uyumlu değildir!Lütfen tekrar giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYeniSifre.Text = string.Empty;
                txtYeniSifreTekrar.Text = string.Empty;
            }

        }
    }
   
}
