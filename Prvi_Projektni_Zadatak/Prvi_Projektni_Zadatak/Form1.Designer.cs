
namespace Prvi_Projektni_Zadatak
{
    partial class Form1
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
            this.txtChoseFile.Location = new System.Drawing.Point(59, 24);
            this.txtChoseFile.Name = "txtChoseFile";
            this.txtChoseFile.Size = new System.Drawing.Size(106, 30);
            this.txtChoseFile.TabIndex = 0;
            this.txtChoseFile.Text = "Chose file...";
            this.txtChoseFile.UseVisualStyleBackColor = true;
            this.txtChoseFile.Click += new System.EventHandler(this.txtChoseFile_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Year of birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 228);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(12, 294);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(53, 16);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 363);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            // 
            // lblAtribute
            // 
            this.lblAtribute.AutoSize = true;
            this.lblAtribute.Location = new System.Drawing.Point(12, 427);
            this.lblAtribute.Name = "lblAtribute";
            this.lblAtribute.Size = new System.Drawing.Size(137, 16);
            this.lblAtribute.TabIndex = 6;
            this.lblAtribute.Text = "[role specific attribute]";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(186, 163);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(210, 22);
            this.txtDate.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(186, 225);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(210, 22);
            this.txtCity.TabIndex = 9;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(186, 291);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(210, 22);
            this.txtFaculty.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(186, 357);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(210, 22);
            this.txtRole.TabIndex = 11;
            // 
            // txtAtribute
            // 
            this.txtAtribute.Location = new System.Drawing.Point(186, 427);
            this.txtAtribute.Name = "txtAtribute";
            this.txtAtribute.Size = new System.Drawing.Size(210, 22);
            this.txtAtribute.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 543);
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
            this.Name = "Form1";
            this.Text = "Form1";
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

