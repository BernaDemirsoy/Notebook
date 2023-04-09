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
    public partial class frmRegister : Form
    {
        User _user;
        private IUserService _userService;

        public frmRegister()
        {
            InitializeComponent();
            _userService = new UserManeger();
            _user=new User();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            btnKaydet.DialogResult= DialogResult.OK;
           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _user.UserName = txtKullaniciAdi.Text;

            if (AdminMi(_user) == false)
            {
                MessageBox.Show("Yeni user eklendi.Hoşgeldiniz...");
                _userService.UserYarat(UserAtama(_user));
                frmLogin log=new frmLogin();
                this.Hide();
                log.ShowDialog();
                
            }
            else
            {
                _user = UserAtama(_user);
                DialogResult dg;
                dg = MessageBox.Show("Şuan mevcutta bir Admin var yeni bir admin girişi mi yapacaksınız?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dg == DialogResult.Yes)
                {
                    bool kontrol = _userService.AynıAdminVarMi(_user);
                    if (kontrol ==true)
                    {
                        MessageBox.Show("Böyle bir admin zaten kayitli! Tekrar eden bir kayıt oluşturamazsınız!");
                        frmLogin frm = new frmLogin();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        _userService.UserYarat(_user);
                        MessageBox.Show("Yeni admin eklendi.Hoşgeldiniz...");
                        frmLogin frm=new frmLogin();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    
                    frmLogin frm = new frmLogin();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }

            }

        }

        public User UserAtama(User user)
        {
            string state;
            user.Lastname = txtSoyad.Text;
            user.Name = txtAd.Text;
            string sifre1 = txtSifre.Text;
            string sifre2 = txtSifreTekrar.Text;

            if (AdminMi(user) == false)
            {
                if (SifreKontrol(sifre1, sifre2) == true)
                {
                    user.Password = sifre1;
                    state = "Pasif";
                    user.State = state;
                    return user;

                }
                else
                {

                    MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar giriniz!");
                    return null;
                }
                
            }
            else
            {
                if (SifreKontrol(sifre1, sifre2) == true)
                {
                    user.Password = sifre1;
                    state = "Admin";
                    user.State = state;
                    return user;

                }
                else
                {

                    MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar giriniz!");
                    return null;
                }
               
            }
        }

        public bool AdminMi(User user)
        {
            string admin = "Admin";
            if (user.UserName == admin || user.UserName == admin.ToLower() || user.UserName == admin.ToUpper())
            {

                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool SifreKontrol(string sifre1,string sifre2)
        {
            if (sifre1 == sifre2)
            {
                label6.Text = "Şifreler Uyumlu";
                label6.BackColor = Color.Green;
                label6.Visible = true;
                return true;
            }
            else
            {
                MessageBox.Show("Şifreler uyumlu değildir. Lütfen kontrol ediniz!");
                label6.Text = "Şifreler Uyumsuz";
                label6.BackColor = Color.Red;
                label6.Visible = true;
                return false;
            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
