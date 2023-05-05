using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prvi_Projektni_Zadatak.Models
{

    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string dateOfBirth { get; set; }
        public string city { get; set; }
        public string faculty { get; set; }
        public string role { get; set; }
        public string atribute { get; set; }

        public void setData(UserParser up)
        {
            name = up.nameP;
            surname = up.surnameP;
            dateOfBirth = up.dateOfBirthP;
            city = up.cityP;
            faculty = up.facultyP;
            role = up.roleP;
            atribute = up.atributeP;
        }

    }

    
}
