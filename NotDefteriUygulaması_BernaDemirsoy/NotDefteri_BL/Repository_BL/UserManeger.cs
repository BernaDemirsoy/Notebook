using NotDefteri_BL.Abstract;
using NotDefteri_DAL.Entities;
using NotDefteri_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_BL.Repository_BL
{
    public class UserManeger:IUserService
    {
        private IUserRepository _userRepo;
        public UserManeger()
        {
            _userRepo = new UserRepository();
        }

        public List<User> AdminIncınListle()
        {
            return _userRepo.AdminIncınListle();
        }

        public bool AynıAdminVarMi(User user)
        {
            return _userRepo.AynıAdminVarMi(user);
        }

        public void PasiftoAktif(int ID)
        {
            _userRepo.PasiftoAktif(ID);
        }

        public User UserKayitliMi(User user)
        {
            return _userRepo.UserKayitliMi(user);
        }

        public void UserSifreGuncelle(User user, string newpassword)
        {
            _userRepo.UserSifreGuncelle(user, newpassword);
        }

        public User UserYarat(User user)
        {
           return _userRepo.UserYarat(user);
        }
    }
}
