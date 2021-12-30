
namespace Projekt_Fight_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_F1_Login = new System.Windows.Forms.Button();
            this.txt_F1_Username = new System.Windows.Forms.TextBox();
            this.txt_F1_PassWord = new System.Windows.Forms.TextBox();
            this.lbl_F1_Username = new System.Windows.Forms.Label();
            this.lbl_F1_Password = new System.Windows.Forms.Label();
            this.txt_F1CharName = new System.Windows.Forms.TextBox();
            this.lbl_F1CharName = new System.Windows.Forms.Label();
            this.cbo_F1Gender = new System.Windows.Forms.ComboBox();
            this.cbo_F1CharClass = new System.Windows.Forms.ComboBox();
            this.lbl_F1Gender = new System.Windows.Forms.Label();
            this.lbl_F1CharClass = new System.Windows.Forms.Label();
            this.btn_F1CreateChar = new System.Windows.Forms.Button();
            this.lbl_F1_SignUp = new System.Windows.Forms.Label();
            this.lbl_F1_Header = new System.Windows.Forms.Label();
            this.lbl_F1_LoggedInAs = new System.Windows.Forms.Label();
            this.txt_F1_LoggedInAs = new System.Windows.Forms.TextBox();
            this.btn_F1_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_F1_Login
            // 
            this.btn_F1_Login.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_F1_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_F1_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F1_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F1_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_F1_Login.Location = new System.Drawing.Point(1046, 20);
            this.btn_F1_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_F1_Login.Name = "btn_F1_Login";
            this.btn_F1_Login.Size = new System.Drawing.Size(74, 31);
            this.btn_F1_Login.TabIndex = 0;
            this.btn_F1_Login.Text = "Login";
            this.btn_F1_Login.UseVisualStyleBackColor = false;
            this.btn_F1_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_F1_Username
            // 
            this.txt_F1_Username.Location = new System.Drawing.Point(697, 25);
            this.txt_F1_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_F1_Username.Name = "txt_F1_Username";
            this.txt_F1_Username.Size = new System.Drawing.Size(169, 23);
            this.txt_F1_Username.TabIndex = 1;
            // 
            // txt_F1_PassWord
            // 
            this.txt_F1_PassWord.Location = new System.Drawing.Point(870, 25);
            this.txt_F1_PassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_F1_PassWord.Name = "txt_F1_PassWord";
            this.txt_F1_PassWord.Size = new System.Drawing.Size(169, 23);
            this.txt_F1_PassWord.TabIndex = 2;
            // 
            // lbl_F1_Username
            // 
            this.lbl_F1_Username.AutoSize = true;
            this.lbl_F1_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_F1_Username.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_F1_Username.Location = new System.Drawing.Point(697, 9);
            this.lbl_F1_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1_Username.Name = "lbl_F1_Username";
            this.lbl_F1_Username.Size = new System.Drawing.Size(60, 15);
            this.lbl_F1_Username.TabIndex = 3;
            this.lbl_F1_Username.Text = "Username";
            // 
            // lbl_F1_Password
            // 
            this.lbl_F1_Password.AutoSize = true;
            this.lbl_F1_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_F1_Password.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_F1_Password.Location = new System.Drawing.Point(870, 9);
            this.lbl_F1_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1_Password.Name = "lbl_F1_Password";
            this.lbl_F1_Password.Size = new System.Drawing.Size(57, 15);
            this.lbl_F1_Password.TabIndex = 4;
            this.lbl_F1_Password.Text = "Password";
            // 
            // txt_F1CharName
            // 
            this.txt_F1CharName.Location = new System.Drawing.Point(27, 420);
            this.txt_F1CharName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_F1CharName.Name = "txt_F1CharName";
            this.txt_F1CharName.Size = new System.Drawing.Size(106, 23);
            this.txt_F1CharName.TabIndex = 5;
            // 
            // lbl_F1CharName
            // 
            this.lbl_F1CharName.AutoSize = true;
            this.lbl_F1CharName.Location = new System.Drawing.Point(27, 398);
            this.lbl_F1CharName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1CharName.Name = "lbl_F1CharName";
            this.lbl_F1CharName.Size = new System.Drawing.Size(93, 15);
            this.lbl_F1CharName.TabIndex = 6;
            this.lbl_F1CharName.Text = "Character Name";
            // 
            // cbo_F1Gender
            // 
            this.cbo_F1Gender.FormattingEnabled = true;
            this.cbo_F1Gender.Location = new System.Drawing.Point(28, 462);
            this.cbo_F1Gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_F1Gender.Name = "cbo_F1Gender";
            this.cbo_F1Gender.Size = new System.Drawing.Size(129, 23);
            this.cbo_F1Gender.TabIndex = 7;
            // 
            // cbo_F1CharClass
            // 
            this.cbo_F1CharClass.FormattingEnabled = true;
            this.cbo_F1CharClass.Location = new System.Drawing.Point(28, 502);
            this.cbo_F1CharClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_F1CharClass.Name = "cbo_F1CharClass";
            this.cbo_F1CharClass.Size = new System.Drawing.Size(129, 23);
            this.cbo_F1CharClass.TabIndex = 8;
            // 
            // lbl_F1Gender
            // 
            this.lbl_F1Gender.AutoSize = true;
            this.lbl_F1Gender.Location = new System.Drawing.Point(28, 445);
            this.lbl_F1Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1Gender.Name = "lbl_F1Gender";
            this.lbl_F1Gender.Size = new System.Drawing.Size(45, 15);
            this.lbl_F1Gender.TabIndex = 9;
            this.lbl_F1Gender.Text = "Gender";
            // 
            // lbl_F1CharClass
            // 
            this.lbl_F1CharClass.AutoSize = true;
            this.lbl_F1CharClass.Location = new System.Drawing.Point(29, 486);
            this.lbl_F1CharClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1CharClass.Name = "lbl_F1CharClass";
            this.lbl_F1CharClass.Size = new System.Drawing.Size(58, 15);
            this.lbl_F1CharClass.TabIndex = 10;
            this.lbl_F1CharClass.Text = "Character";
            // 
            // btn_F1CreateChar
            // 
            this.btn_F1CreateChar.Location = new System.Drawing.Point(27, 363);
            this.btn_F1CreateChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_F1CreateChar.Name = "btn_F1CreateChar";
            this.btn_F1CreateChar.Size = new System.Drawing.Size(105, 22);
            this.btn_F1CreateChar.TabIndex = 11;
            this.btn_F1CreateChar.Text = "Create character";
            this.btn_F1CreateChar.UseVisualStyleBackColor = true;
            // 
            // lbl_F1_SignUp
            // 
            this.lbl_F1_SignUp.AutoSize = true;
            this.lbl_F1_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_F1_SignUp.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_F1_SignUp.Location = new System.Drawing.Point(883, 50);
            this.lbl_F1_SignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1_SignUp.Name = "lbl_F1_SignUp";
            this.lbl_F1_SignUp.Size = new System.Drawing.Size(156, 15);
            this.lbl_F1_SignUp.TabIndex = 12;
            this.lbl_F1_SignUp.Text = "New member? Sign up here!";
            // 
            // lbl_F1_Header
            // 
            this.lbl_F1_Header.AutoSize = true;
            this.lbl_F1_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_F1_Header.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_F1_Header.ForeColor = System.Drawing.Color.Gold;
            this.lbl_F1_Header.Location = new System.Drawing.Point(434, 81);
            this.lbl_F1_Header.Name = "lbl_F1_Header";
            this.lbl_F1_Header.Size = new System.Drawing.Size(221, 50);
            this.lbl_F1_Header.TabIndex = 13;
            this.lbl_F1_Header.Text = "Fight Game";
            // 
            // lbl_F1_LoggedInAs
            // 
            this.lbl_F1_LoggedInAs.AutoSize = true;
            this.lbl_F1_LoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_F1_LoggedInAs.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_F1_LoggedInAs.Location = new System.Drawing.Point(11, 9);
            this.lbl_F1_LoggedInAs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_F1_LoggedInAs.Name = "lbl_F1_LoggedInAs";
            this.lbl_F1_LoggedInAs.Size = new System.Drawing.Size(74, 15);
            this.lbl_F1_LoggedInAs.TabIndex = 14;
            this.lbl_F1_LoggedInAs.Text = "Logged in as";
            // 
            // txt_F1_LoggedInAs
            // 
            this.txt_F1_LoggedInAs.Location = new System.Drawing.Point(11, 25);
            this.txt_F1_LoggedInAs.Margin = new System.Windows.Forms.Padding(2);
            this.txt_F1_LoggedInAs.Name = "txt_F1_LoggedInAs";
            this.txt_F1_LoggedInAs.Size = new System.Drawing.Size(169, 23);
            this.txt_F1_LoggedInAs.TabIndex = 15;
            // 
            // btn_F1_Logout
            // 
            this.btn_F1_Logout.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_F1_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_F1_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F1_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F1_Logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_F1_Logout.Location = new System.Drawing.Point(184, 20);
            this.btn_F1_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_F1_Logout.Name = "btn_F1_Logout";
            this.btn_F1_Logout.Size = new System.Drawing.Size(74, 31);
            this.btn_F1_Logout.TabIndex = 16;
            this.btn_F1_Logout.Text = "Logout";
            this.btn_F1_Logout.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_Fight_Game.Properties.Resources.Form1Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btn_F1_Logout);
            this.Controls.Add(this.txt_F1_LoggedInAs);
            this.Controls.Add(this.lbl_F1_LoggedInAs);
            this.Controls.Add(this.lbl_F1_Header);
            this.Controls.Add(this.lbl_F1_SignUp);
            this.Controls.Add(this.btn_F1CreateChar);
            this.Controls.Add(this.lbl_F1CharClass);
            this.Controls.Add(this.lbl_F1Gender);
            this.Controls.Add(this.cbo_F1CharClass);
            this.Controls.Add(this.cbo_F1Gender);
            this.Controls.Add(this.lbl_F1CharName);
            this.Controls.Add(this.txt_F1CharName);
            this.Controls.Add(this.lbl_F1_Password);
            this.Controls.Add(this.lbl_F1_Username);
            this.Controls.Add(this.txt_F1_PassWord);
            this.Controls.Add(this.txt_F1_Username);
            this.Controls.Add(this.btn_F1_Login);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_F1_Login;
        private System.Windows.Forms.TextBox txt_F1_Username;
        private System.Windows.Forms.TextBox txt_F1_PassWord;
        private System.Windows.Forms.Label lbl_F1_Username;
        private System.Windows.Forms.Label lbl_F1_Password;
        private System.Windows.Forms.TextBox txt_F1CharName;
        private System.Windows.Forms.Label lbl_F1CharName;
        private System.Windows.Forms.ComboBox cbo_F1Gender;
        private System.Windows.Forms.ComboBox cbo_F1CharClass;
        private System.Windows.Forms.Label lbl_F1Gender;
        private System.Windows.Forms.Label lbl_F1CharClass;
        private System.Windows.Forms.Button btn_F1CreateChar;
        private System.Windows.Forms.Label lbl_F1_SignUp;
        private System.Windows.Forms.Label lbl_F1_Header;
        private System.Windows.Forms.Label lbl_F1_LoggedInAs;
        private System.Windows.Forms.TextBox txt_F1_LoggedInAs;
        private System.Windows.Forms.Button btn_F1_Logout;
    }
}

