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
    public partial class frmLogin : Form
    {
        private IUserService _userService;
        User user;
        public frmLogin()
        {
            InitializeComponent();
            _userService = new UserManeger();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            user = new User();
            string admin = "Admin";
            user.UserName=txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;
            User kontroledilecek = _userService.UserKayitliMi(user);
            if (kontroledilecek!= null)
            {
                
                if (kontroledilecek.UserName == admin || kontroledilecek.UserName== admin.ToLower() || kontroledilecek.UserName== admin.ToUpper())
                {
                    fmrAdmin admins = new fmrAdmin();
                    this.Hide();
                    admins.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (kontroledilecek.State == "Active")
                    {
                        frmMain main=new frmMain(kontroledilecek);
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Üyeliğiniz admin tarafından onaylanmamıştır.");
                    }
                }
                
            }
            else
            {

                DialogResult dg = MessageBox.Show("Böyle bir üyelik bulunmamaktadır.Lütfen önce kayıt olunuz.","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dg==DialogResult.Yes)
                {
                    linkLabel1.BackColor= Color.Yellow;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister regis=new frmRegister();
            this.Hide(); 
            regis.ShowDialog();
            this.Show();
            

        }

        
    }
}
