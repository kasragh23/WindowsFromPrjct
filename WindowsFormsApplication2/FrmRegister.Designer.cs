namespace WindowsFormsApplication2
{
    partial class FrmRegister
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblReg_Title = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReg_Pass = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReg_User = new System.Windows.Forms.Label();
            this.lblReg_Email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblReg_Name = new System.Windows.Forms.Label();
            this.txtSecutiry = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.grpOptional = new System.Windows.Forms.GroupBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.mskBirthday = new System.Windows.Forms.MaskedTextBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.grpInterest = new System.Windows.Forms.GroupBox();
            this.chckAdv = new System.Windows.Forms.CheckBox();
            this.chckHorr = new System.Windows.Forms.CheckBox();
            this.chckPost = new System.Windows.Forms.CheckBox();
            this.chckDrama = new System.Windows.Forms.CheckBox();
            this.chckSci = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chckAct = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.grpOptional.SuspendLayout();
            this.grpInterest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.lblReg_Title);
            this.grpInfo.Controls.Add(this.lblSecurity);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.lblReg_Pass);
            this.grpInfo.Controls.Add(this.txtFamily);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblReg_User);
            this.grpInfo.Controls.Add(this.lblReg_Email);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.txtUser);
            this.grpInfo.Controls.Add(this.lblReg_Name);
            this.grpInfo.Controls.Add(this.txtSecutiry);
            this.grpInfo.Controls.Add(this.txtPass2);
            this.grpInfo.Controls.Add(this.txtPass);
            this.grpInfo.Location = new System.Drawing.Point(12, 22);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(287, 312);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Main Information";
            this.grpInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblReg_Title
            // 
            this.lblReg_Title.AutoSize = true;
            this.lblReg_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg_Title.Location = new System.Drawing.Point(93, 26);
            this.lblReg_Title.Name = "lblReg_Title";
            this.lblReg_Title.Size = new System.Drawing.Size(104, 29);
            this.lblReg_Title.TabIndex = 3;
            this.lblReg_Title.Text = "Register";
            this.lblReg_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Location = new System.Drawing.Point(3, 276);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(101, 13);
            this.lblSecurity.TabIndex = 2;
            this.lblSecurity.Text = "Pet Name (Security)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Confirm Password";
            // 
            // lblReg_Pass
            // 
            this.lblReg_Pass.AutoSize = true;
            this.lblReg_Pass.Location = new System.Drawing.Point(51, 212);
            this.lblReg_Pass.Name = "lblReg_Pass";
            this.lblReg_Pass.Size = new System.Drawing.Size(53, 13);
            this.lblReg_Pass.TabIndex = 2;
            this.lblReg_Pass.Text = "Password";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(110, 116);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(146, 20);
            this.txtFamily.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblReg_User
            // 
            this.lblReg_User.AutoSize = true;
            this.lblReg_User.Location = new System.Drawing.Point(49, 183);
            this.lblReg_User.Name = "lblReg_User";
            this.lblReg_User.Size = new System.Drawing.Size(55, 13);
            this.lblReg_User.TabIndex = 2;
            this.lblReg_User.Text = "Username";
            // 
            // lblReg_Email
            // 
            this.lblReg_Email.AutoSize = true;
            this.lblReg_Email.Location = new System.Drawing.Point(66, 152);
            this.lblReg_Email.Name = "lblReg_Email";
            this.lblReg_Email.Size = new System.Drawing.Size(32, 13);
            this.lblReg_Email.TabIndex = 2;
            this.lblReg_Email.Text = "Email";
            this.lblReg_Email.Click += new System.EventHandler(this.lblReg_Email_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Family";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(110, 180);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 20);
            this.txtUser.TabIndex = 4;
            // 
            // lblReg_Name
            // 
            this.lblReg_Name.AutoSize = true;
            this.lblReg_Name.Location = new System.Drawing.Point(63, 89);
            this.lblReg_Name.Name = "lblReg_Name";
            this.lblReg_Name.Size = new System.Drawing.Size(35, 13);
            this.lblReg_Name.TabIndex = 2;
            this.lblReg_Name.Text = "Name";
            // 
            // txtSecutiry
            // 
            this.txtSecutiry.Location = new System.Drawing.Point(110, 269);
            this.txtSecutiry.Name = "txtSecutiry";
            this.txtSecutiry.Size = new System.Drawing.Size(146, 20);
            this.txtSecutiry.TabIndex = 7;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(110, 239);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(146, 20);
            this.txtPass2.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(110, 209);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(146, 20);
            this.txtPass.TabIndex = 5;
            // 
            // grpOptional
            // 
            this.grpOptional.Controls.Add(this.cmbCity);
            this.grpOptional.Controls.Add(this.mskBirthday);
            this.grpOptional.Controls.Add(this.radioF);
            this.grpOptional.Controls.Add(this.radioM);
            this.grpOptional.Controls.Add(this.lblGender);
            this.grpOptional.Controls.Add(this.label4);
            this.grpOptional.Controls.Add(this.lblBirth);
            this.grpOptional.Location = new System.Drawing.Point(323, 22);
            this.grpOptional.Name = "grpOptional";
            this.grpOptional.Size = new System.Drawing.Size(235, 156);
            this.grpOptional.TabIndex = 1;
            this.grpOptional.TabStop = false;
            this.grpOptional.Text = "Optional Info";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Shiraz",
            "Tehran",
            "Yazd",
            "Isfahan"});
            this.cmbCity.Location = new System.Drawing.Point(71, 52);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 9;
            // 
            // mskBirthday
            // 
            this.mskBirthday.Location = new System.Drawing.Point(71, 23);
            this.mskBirthday.Mask = "0000/00/00";
            this.mskBirthday.Name = "mskBirthday";
            this.mskBirthday.Size = new System.Drawing.Size(158, 20);
            this.mskBirthday.TabIndex = 8;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(146, 93);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(59, 17);
            this.radioF.TabIndex = 11;
            this.radioF.TabStop = true;
            this.radioF.Text = "Female";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(71, 93);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(48, 17);
            this.radioM.TabIndex = 10;
            this.radioM.TabStop = true;
            this.radioM.Text = "Male";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 93);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "City";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(14, 26);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(45, 13);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "Birthday";
            // 
            // grpInterest
            // 
            this.grpInterest.Controls.Add(this.chckAdv);
            this.grpInterest.Controls.Add(this.chckHorr);
            this.grpInterest.Controls.Add(this.chckPost);
            this.grpInterest.Controls.Add(this.chckDrama);
            this.grpInterest.Controls.Add(this.chckSci);
            this.grpInterest.Controls.Add(this.checkBox4);
            this.grpInterest.Controls.Add(this.chckAct);
            this.grpInterest.Location = new System.Drawing.Point(323, 188);
            this.grpInterest.Name = "grpInterest";
            this.grpInterest.Size = new System.Drawing.Size(235, 146);
            this.grpInterest.TabIndex = 2;
            this.grpInterest.TabStop = false;
            this.grpInterest.Text = "Interested Categories";
            this.grpInterest.Enter += new System.EventHandler(this.grpInterest_Enter);
            // 
            // chckAdv
            // 
            this.chckAdv.AutoSize = true;
            this.chckAdv.Location = new System.Drawing.Point(135, 105);
            this.chckAdv.Name = "chckAdv";
            this.chckAdv.Size = new System.Drawing.Size(75, 17);
            this.chckAdv.TabIndex = 17;
            this.chckAdv.Text = "Adventure";
            this.chckAdv.UseVisualStyleBackColor = true;
            this.chckAdv.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chckHorr
            // 
            this.chckHorr.AutoSize = true;
            this.chckHorr.Location = new System.Drawing.Point(32, 105);
            this.chckHorr.Name = "chckHorr";
            this.chckHorr.Size = new System.Drawing.Size(55, 17);
            this.chckHorr.TabIndex = 16;
            this.chckHorr.Text = "Horror";
            this.chckHorr.UseVisualStyleBackColor = true;
            this.chckHorr.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chckPost
            // 
            this.chckPost.AutoSize = true;
            this.chckPost.Location = new System.Drawing.Point(135, 61);
            this.chckPost.Name = "chckPost";
            this.chckPost.Size = new System.Drawing.Size(86, 17);
            this.chckPost.TabIndex = 15;
            this.chckPost.Text = "Post Modern";
            this.chckPost.UseVisualStyleBackColor = true;
            this.chckPost.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chckDrama
            // 
            this.chckDrama.AutoSize = true;
            this.chckDrama.Location = new System.Drawing.Point(32, 61);
            this.chckDrama.Name = "chckDrama";
            this.chckDrama.Size = new System.Drawing.Size(57, 17);
            this.chckDrama.TabIndex = 14;
            this.chckDrama.Text = "Drama";
            this.chckDrama.UseVisualStyleBackColor = true;
            // 
            // chckSci
            // 
            this.chckSci.AutoSize = true;
            this.chckSci.Location = new System.Drawing.Point(135, 19);
            this.chckSci.Name = "chckSci";
            this.chckSci.Size = new System.Drawing.Size(49, 17);
            this.chckSci.TabIndex = 13;
            this.chckSci.Text = "Sci-fi";
            this.chckSci.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(136, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(56, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Action";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // chckAct
            // 
            this.chckAct.AutoSize = true;
            this.chckAct.Location = new System.Drawing.Point(32, 19);
            this.chckAct.Name = "chckAct";
            this.chckAct.Size = new System.Drawing.Size(56, 17);
            this.chckAct.TabIndex = 12;
            this.chckAct.Text = "Action";
            this.chckAct.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Location = new System.Drawing.Point(144, 379);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 49);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.BackColor = System.Drawing.Color.Teal;
            this.btnCLear.Location = new System.Drawing.Point(316, 379);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(94, 49);
            this.btnCLear.TabIndex = 19;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = false;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(60, 389);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(50, 29);
            this.connect.TabIndex = 20;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(456, 397);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 13);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Back to Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(570, 480);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.btnCLear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpInterest);
            this.Controls.Add(this.grpOptional);
            this.Controls.Add(this.grpInfo);
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpOptional.ResumeLayout(false);
            this.grpOptional.PerformLayout();
            this.grpInterest.ResumeLayout(false);
            this.grpInterest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblReg_Title;
        private System.Windows.Forms.Label lblReg_Pass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReg_User;
        private System.Windows.Forms.Label lblReg_Email;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblReg_Name;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox grpOptional;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.GroupBox grpInterest;
        private System.Windows.Forms.CheckBox chckHorr;
        private System.Windows.Forms.CheckBox chckDrama;
        private System.Windows.Forms.CheckBox chckAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.MaskedTextBox mskBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.CheckBox chckAdv;
        private System.Windows.Forms.CheckBox chckPost;
        private System.Windows.Forms.CheckBox chckSci;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.TextBox txtSecutiry;
    }
}