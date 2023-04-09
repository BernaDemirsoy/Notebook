using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_DAL.Entities
{
    public class User
    {
        public int UserID { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (value.Length > 15)
                {
                    throw new Exception("Bir kullanıcı adı 15 karekterden fazla olamaz");
                }
                else
                    _UserName = value;
            }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Bir kullanıcı şifresi 10 karekterden fazla olamaz.");
                }
                else if(value.Length < 4) 
                {
                    throw new Exception("Bir kullanıcı şifresi 4 karekterden az olamaz.");
                }
                else
                {
                    _Password= value;
                }
            }
        }
        public string State { get; set; }

        public virtual ICollection<Note> Notes { get; set; }

       
    }
}
