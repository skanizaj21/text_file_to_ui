using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_Projektni_Zadatak.Models
{
    public class UserParser
    {
        public string str { get; set; }
        public string nameP { get; set; }
        public string surnameP { get; set; }
        public string dateOfBirthP { get; set; }
        public string cityP { get; set; }
        public string facultyP { get; set; }
        public string roleP { get; set; }
        public string atributeP { get; set; }
        public int countP { get; set; }
        public string filePath { get; set; }


        public void Parse(string input)
        {
            str = input;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                int index = line.IndexOf('=');
                if (index != -1)
                {
                    string key = line.Substring(0, index).Trim();
                    string value = line.Substring(index + 1).Trim();

                    switch (key)
                    {
                        case "Ime":
                            nameP = value;
                            break;
                        case "Prezime":
                            surnameP = value;
                            break;
                        case "Godina rođenja":
                            dateOfBirthP = value;
                            break;
                        case "Grad rođenja":
                            cityP = value;
                            break;
                        case "Fakultet":
                            facultyP = value;
                            break;
                        case "Uloga":
                            roleP = value;
                            break;
                        case "Najdraži kolegij":
                            atributeP = value;
                            break;
                        case "Datoteci pristupljeno puta":
                            countP = int.Parse(value) + 1;
                            StreamWriter outputFile = new StreamWriter(Path.Combine(filePath));
                            outputFile.WriteLine("Datoteci pristupljeno puta=" + countP.ToString());
                            break;
                    }
                }
            }


        }
    }
}

