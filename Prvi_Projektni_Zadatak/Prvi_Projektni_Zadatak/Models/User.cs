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
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public string YearOfBirth
        {
            get { return YearOfBirth; }
            set { YearOfBirth = value; }
        }
        public string City
        {
            get { return City; }
            set { City = value; }
        }
        public string Faculty
        {
            get { return Faculty; }
            set { Faculty = value; }
        }
        public string Role
        {
            get { return Role; }
            set { Role = value; }
        }
        public string Atribute
        {
            get { return Atribute; }
            set { Atribute = value; }
        }

        String str;
        char[] seperator = { '=' };
        String[] strarr = null;

        public String text { get; set; }

        public void UcitajPodatke()
        {
            UserFileReader UserFileReader = new UserFileReader();
            this.text = UserFileReader.text;
            str = this.text;
            strarr = str.Split(seperator);
            this.Name = strarr[0];
            this.Surname = strarr[1];
            this.YearOfBirth = strarr[2];
            this.City = strarr[3];
            this.Faculty = strarr[4];
            this.Role = strarr[5];
            this.Atribute = strarr[6];
        }

    }
}
