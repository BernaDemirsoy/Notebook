using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri_DAL.Entities
{
    public class Note
    {
        public int NoteID { get; set; }

        public string NoteHeader
        {
            get; set;
        } = null;

        public string NoteBody { get; set; } = null;

        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
