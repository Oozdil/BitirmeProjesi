using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalkToMePharmaDashBoard.Api
{
    public class AdminUser
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DateOfCreate { get; set; }
        public string Active { get; set; }
        public string FullName
        {

            get
            {
                if (Active == "0")
                    return Title + " " + Name + " " + Surname + " - Pasif";
                else
                    return Title + " " + Name + " " + Surname + " - Aktif";
            }
        }

    }
}
