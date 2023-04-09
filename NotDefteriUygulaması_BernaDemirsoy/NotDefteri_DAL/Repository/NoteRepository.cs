using NotDefteri_DAL.Abstract;
using NotDefteri_DAL.Context;
using NotDefteri_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_DAL.Repository
{
    public class NoteRepository : INoteRepository
    {
        DBNoteBook db=new DBNoteBook();

        public List<Note> UseraAitNotlariGetir(User user)
        {
            var nt = db.Notes.Where(a => a.UserID == user.UserID).ToList();
            return nt;
        }

        public Note UseraAitNotbyId(int id)
        {
            Note note=db.Notes.Where(A => A.NoteID == id).FirstOrDefault();
            return note;
        }
        public void UseraNoteKaydet(int id, string baslık, string notum)
        {
            Note yeminot = new Note();
            yeminot.UserID = id;
            yeminot.NoteHeader = baslık;
            yeminot.NoteBody= notum;
            db.Notes.Add(yeminot);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
           Note note= db.Notes.Where(a => a.NoteID == id).FirstOrDefault();
            if (note != null)
            {
                db.Notes.Remove(note);
                db.SaveChanges();
                return true;
            }
            else return false;
               
           
        }

        public bool Update(Note note)
        {
            Note updatenote = db.Notes.Where(a => a.NoteID == note.NoteID).FirstOrDefault();
            updatenote.NoteHeader= note.NoteHeader;
            updatenote.NoteBody= note.NoteBody;
            return db.SaveChanges() > 0;
        }
    }
}
