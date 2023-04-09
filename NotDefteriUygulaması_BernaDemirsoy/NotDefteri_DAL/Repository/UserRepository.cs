using NotDefteri_DAL.Context;
using NotDefteri_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace NotDefteri_DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        DBNoteBook db = new DBNoteBook();

        public List<User> AdminIncınListle()
        {
            var adminIcınTablo = db.Users.Where(a => a.State == "Pasif").ToList(); //a.UserName!="Admin"
            return adminIcınTablo;
        }

        public bool AynıAdminVarMi(User user)
        {
            User kayitliAdmin=db.Users.Where(a => a.Name == user.Name && a.Lastname == user.Lastname).FirstOrDefault();
            if (kayitliAdmin != null)
            {
                return true;
            }
            else
                return false;
            
        }

        public void PasiftoAktif(int ID)
        {
            User degisecekUser=db.Users.Where(a => a.UserID == ID).First();
            degisecekUser.State = "Active";
            db.SaveChanges();
           
        }

       

        public User UserKayitliMi(User user)
        {
            User kayitliUser = (User)(from u in db.Users
                                where u.UserName == user.UserName && u.Password == user.Password
                                select u).First();
  

            return kayitliUser;

            
        }

        public void UserSifreGuncelle(User user,string s1)
        {
            User degistir = db.Users.Where(a => a.UserID == user.UserID).First();
            degistir.Password = s1;
            db.SaveChanges();
        }

        public User UserYarat(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

       
    }
}
