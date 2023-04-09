using NotDefteri_BL.Abstract;
using NotDefteri_BL.Repository_BL;
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
    public partial class fmrAdmin : Form
    {
        private IUserService _userService;
        public fmrAdmin()
        {
            InitializeComponent();
            _userService = new UserManeger();
            listView1.Items.Clear();
        }

        private void fmrAdmin_Load(object sender, EventArgs e)
        {

            Listele();
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    if (item.SubItems[3].Text == "Pasif")
                    {
                        DialogResult dg;
                        dg = MessageBox.Show("Bu kullanıcıyı onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            int id = (int)item.Tag;
                            _userService.PasiftoAktif(id);
                            listView1.Items.Clear();
                            Listele();
                        }
                    }
                    else
                    {
                        throw new Exception("Bir hata ile karşılaştık");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
               
            
        }

        private void fmrAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        void Listele()
        {
            var pasifler = _userService.AdminIncınListle();

            foreach (var item in pasifler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Lastname);
                lvi.SubItems.Add(item.UserName);
                lvi.SubItems.Add(item.State);
                lvi.Tag = item.UserID;
                listView1.Items.Add(lvi);
            }
        }
    }
}
