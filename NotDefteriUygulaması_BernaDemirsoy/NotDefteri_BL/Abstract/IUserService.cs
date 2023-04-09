using NotDefteri_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_BL.Abstract
{
    public interface IUserService
    {
        User UserYarat(User user);

        User UserKayitliMi(User user);

        bool AynıAdminVarMi(User user);

        List<User> AdminIncınListle();

        void PasiftoAktif(int ID);

        void UserSifreGuncelle(User user, string newpassword);
    }
}
