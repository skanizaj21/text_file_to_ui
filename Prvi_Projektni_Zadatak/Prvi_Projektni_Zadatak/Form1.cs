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
        Reader Reader = new Reader();   
        User User = new User();
        UserParser UserParser = new UserParser();
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void txtChoseFile_Click(object sender, EventArgs e)
        {
                Reader.Read();
                UserFileReader.FileOpen(Reader.content);
                UserParser.filePath = Reader.path;
                UserParser.Parse(UserFileReader.text);
                User.SetData(UserParser);
                txtName.Text = User.name;
                txtDate.Text = User.dateOfBirth;
                txtCity.Text = User.city;
                txtFaculty.Text = User.faculty;
                txtRole.Text = User.role;
                txtAtribute.Text = User.atribute;

            }
        }

    }
