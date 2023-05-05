
namespace Prvi_Projektni_Zadatak
{
    partial class UserInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChoseFile = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAtribute = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtAtribute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChoseFile
            // 
            this.txtChoseFile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChoseFile.Location = new System.Drawing.Point(44, 20);
            this.txtChoseFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtChoseFile.Name = "txtChoseFile";
            this.txtChoseFile.Size = new System.Drawing.Size(80, 24);
            this.txtChoseFile.TabIndex = 0;
            this.txtChoseFile.Text = "Chose file...";
            this.txtChoseFile.UseVisualStyleBackColor = true;
            this.txtChoseFile.Click += new System.EventHandler(this.txtChoseFile_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 81);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 132);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Year of birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(9, 185);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(9, 239);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(44, 13);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(9, 295);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            // 
            // lblAtribute
            // 
            this.lblAtribute.AutoSize = true;
            this.lblAtribute.Location = new System.Drawing.Point(9, 347);
            this.lblAtribute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtribute.Name = "lblAtribute";
            this.lblAtribute.Size = new System.Drawing.Size(110, 13);
            this.lblAtribute.TabIndex = 6;
            this.lblAtribute.Text = "[role specific attribute]";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(140, 132);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(158, 20);
            this.txtDate.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 183);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(158, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(140, 236);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(158, 20);
            this.txtFaculty.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(140, 290);
            this.txtRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(158, 20);
            this.txtRole.TabIndex = 11;
            // 
            // txtAtribute
            // 
            this.txtAtribute.Location = new System.Drawing.Point(140, 347);
            this.txtAtribute.Margin = new System.Windows.Forms.Padding(2);
            this.txtAtribute.Name = "txtAtribute";
            this.txtAtribute.Size = new System.Drawing.Size(158, 20);
            this.txtAtribute.TabIndex = 12;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 441);
            this.Controls.Add(this.txtAtribute);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAtribute);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtChoseFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInfoForm";
            this.Text = "User data display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtChoseFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblAtribute;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtAtribute;
    }
}

