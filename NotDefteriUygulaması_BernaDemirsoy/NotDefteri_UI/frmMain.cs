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
    public partial class frmMain : Form
    {
        User _user;
        private IUserService _userService;
        private INoteService _noteService;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(User user)
        {
            InitializeComponent();
            _user = user;
            _userService = new UserManeger();
            _noteService = new NoteManager();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label2.Text = _user.Name+" " + _user.Lastname;

            Listele();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassword psw=new frmPassword(_user);
            this.Hide();
            psw.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            txtBaslık.Clear();
            rchtxtNot.Clear();
            txtBaslık.Visible = true;
            rchtxtNot.Visible= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                _noteService.UseraNoteKaydet(_user.UserID, txtBaslık.Text, rchtxtNot.Text);
                MessageBox.Show("Ekleme başarılı");
                Listele();
                txtBaslık.Clear();
                rchtxtNot.Clear();
                txtBaslık.Hide();
                rchtxtNot.Hide();
            }
            else
            {
                bool result=_noteService.Update(new Note()
                {
                    NoteID = noteId,
                    NoteBody = rchtxtNot.Text,
                    NoteHeader = txtBaslık.Text,
                });
                MessageBox.Show(result ? "Güncelleme başarılı" : "Güncelleme başarız Arkadaş!");
            }
            Listele();   
        }
        private void Listele()
        {
            List<Note> list = _noteService.UseraAitNotlariGetir(_user);
            listBox1.DataSource = list;
            listBox1.DisplayMember = "NoteHeader";
            listBox1.ValueMember = "NoteId";
            

        }
        int noteId;
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            noteId = (int)listBox1.SelectedValue;
            Note note = _noteService.UseraAitNotbyId(noteId);
            txtBaslık.Text = note.NoteHeader;
            rchtxtNot.Text = note.NoteBody;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = _noteService.Delete(noteId);
            MessageBox.Show(result ? " Silme başarılı" : "Silemedin arkadaş");
            txtBaslık.Clear();
            rchtxtNot.Clear();
            txtBaslık.Hide();
            rchtxtNot.Hide();
            Listele();
        }
    }
}
