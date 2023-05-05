using Prvi_Projektni_Zadatak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prvi_Projektni_Zadatak
{
    public partial class UserInfoForm : Form
    {

        UserFileReader UserFileReader = new UserFileReader();
        User User = new User();
        UserParser UserParser = new UserParser();
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void txtChoseFile_Click(object sender, EventArgs e)
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
                }
                sr.Close();
                UserFileReader.FileOpen(sb.ToString());
                UserParser.filePath = dlg.FileName.ToString();
                UserParser.parse(UserFileReader.text);
                User.setData(UserParser);
                txtName.Text = User.name;
                txtDate.Text = User.dateOfBirth;
                txtCity.Text = User.city;
                txtFaculty.Text = User.faculty;
                txtRole.Text = User.role;
                txtAtribute.Text = User.atribute;

            }
        }

    }
}
