using NotDefteri_BL.Abstract;
using NotDefteri_DAL.Abstract;
using NotDefteri_DAL.Entities;
using NotDefteri_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_BL.Repository_BL
{
    public class NoteManager : INoteService
    {
        private INoteRepository _noteRepo;
        public NoteManager()
        {
            _noteRepo=new NoteRepository();
        }

        public bool Delete(int id)
        {
            return _noteRepo.Delete(id);
        }

        public bool Update(Note note)
        {
            if(string.IsNullOrEmpty(note.NoteHeader) || string.IsNullOrEmpty(note.NoteBody))
            {
                return false;
            }
            else
            {
                return _noteRepo.Update(note);
            }
        }

        public Note UseraAitNotbyId(int id)
        {
          return _noteRepo.UseraAitNotbyId(id);
        }

        public List<Note> UseraAitNotlariGetir(User user)
        {
            return _noteRepo.UseraAitNotlariGetir(user);
        }

        public void UseraNoteKaydet(int id, string baslık, string notum)
        {
             _noteRepo.UseraNoteKaydet(id, baslık, notum);
        }
    }
}
