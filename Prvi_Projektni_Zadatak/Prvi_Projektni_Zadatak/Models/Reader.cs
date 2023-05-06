using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvi_Projektni_Zadatak.Models
{
    public class Reader
    {

        public string path { get; set; }
        public string content { get; set; }
        public void Read()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open text file";
            dlg.InitialDirectory = @"c:\";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(dlg.FileName);

                string s = sr.ReadLine();
                StringBuilder sb = new StringBuilder();
                while (s != null)
                {
                    sb.Append(s);
                    s = sr.ReadLine();
                    this.content = sb.ToString();
                }
                this.path = dlg.FileName.ToString();
                sr.Close();

            }
        }
    }
}
