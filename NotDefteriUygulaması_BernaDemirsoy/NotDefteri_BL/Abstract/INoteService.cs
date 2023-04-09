using NotDefteri_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_BL.Abstract
{
    public interface INoteService
    {
        List<Note> UseraAitNotlariGetir(User user);
        void UseraNoteKaydet(int id, string baslık, string notum);
        Note UseraAitNotbyId(int id);

        bool Delete(int id);

        bool Update(Note note);
    }
}
