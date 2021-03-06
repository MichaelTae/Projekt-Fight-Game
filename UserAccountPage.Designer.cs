
namespace Projekt_Fight_Game
{
    partial class UserAccountPage
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
            this.lbl_UAP_Header = new System.Windows.Forms.Label();
            this.btn_UAP_Back = new System.Windows.Forms.Button();
            this.lbl_UAP_LoggedInAs = new System.Windows.Forms.Label();
            this.txt_UAP_LoggedInAs = new System.Windows.Forms.TextBox();
            this.btn_UAP_Logout = new System.Windows.Forms.Button();
            this.lbl_UAP_Subscription = new System.Windows.Forms.Label();
            this.txt_UAP_Subscription = new System.Windows.Forms.TextBox();
            this.dataGridView_UAP_CharList = new System.Windows.Forms.DataGridView();
            this.groupBox_UAP = new System.Windows.Forms.GroupBox();
            this.lbl_UAP_CharName = new System.Windows.Forms.Label();
            this.lbl_UAP_CharClass = new System.Windows.Forms.Label();
            this.txt_UAP_CharName = new System.Windows.Forms.TextBox();
            this.cbo_UAP_CharClass = new System.Windows.Forms.ComboBox();
            this.lbl_UAP_CharGender = new System.Windows.Forms.Label();
            this.cbo_UAP_CharGender = new System.Windows.Forms.ComboBox();
            this.btn_UAP_UpdateChar = new System.Windows.Forms.Button();
            this.btn_UAP_CreateChar = new System.Windows.Forms.Button();
            this.btn_UAP_DeleteChar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_UAP_CharWeapon = new System.Windows.Forms.Label();
            this.cbo_UAP_CharWeapon = new System.Windows.Forms.ComboBox();
            this.lbl_UAP_MemberSince = new System.Windows.Forms.Label();
            this.txt_UAP_MemberSince = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UAP_CharList)).BeginInit();
            this.groupBox_UAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UAP_Header
            // 
            this.lbl_UAP_Header.AutoSize = true;
            this.lbl_UAP_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_Header.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_Header.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_Header.Location = new System.Drawing.Point(429, 50);
            this.lbl_UAP_Header.Name = "lbl_UAP_Header";
            this.lbl_UAP_Header.Size = new System.Drawing.Size(292, 76);
            this.lbl_UAP_Header.TabIndex = 0;
            this.lbl_UAP_Header.Text = "Fight Game";
            this.lbl_UAP_Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_UAP_Back
            // 
            this.btn_UAP_Back.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_UAP_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UAP_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UAP_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UAP_Back.Location = new System.Drawing.Point(11, 571);
            this.btn_UAP_Back.Name = "btn_UAP_Back";
            this.btn_UAP_Back.Size = new System.Drawing.Size(69, 28);
            this.btn_UAP_Back.TabIndex = 1;
            this.btn_UAP_Back.Text = "Back";
            this.btn_UAP_Back.UseVisualStyleBackColor = false;
            this.btn_UAP_Back.Click += new System.EventHandler(this.btn_UAP_Back_Click);
            // 
            // lbl_UAP_LoggedInAs
            // 
            this.lbl_UAP_LoggedInAs.AutoSize = true;
            this.lbl_UAP_LoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_LoggedInAs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_LoggedInAs.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_LoggedInAs.Location = new System.Drawing.Point(11, 9);
            this.lbl_UAP_LoggedInAs.Name = "lbl_UAP_LoggedInAs";
            this.lbl_UAP_LoggedInAs.Size = new System.Drawing.Size(74, 15);
            this.lbl_UAP_LoggedInAs.TabIndex = 2;
            this.lbl_UAP_LoggedInAs.Text = "Logged in as";
            // 
            // txt_UAP_LoggedInAs
            // 
            this.txt_UAP_LoggedInAs.Location = new System.Drawing.Point(11, 25);
            this.txt_UAP_LoggedInAs.Name = "txt_UAP_LoggedInAs";
            this.txt_UAP_LoggedInAs.ReadOnly = true;
            this.txt_UAP_LoggedInAs.Size = new System.Drawing.Size(169, 23);
            this.txt_UAP_LoggedInAs.TabIndex = 3;
            // 
            // btn_UAP_Logout
            // 
            this.btn_UAP_Logout.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_UAP_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UAP_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UAP_Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UAP_Logout.Location = new System.Drawing.Point(184, 22);
            this.btn_UAP_Logout.Name = "btn_UAP_Logout";
            this.btn_UAP_Logout.Size = new System.Drawing.Size(69, 28);
            this.btn_UAP_Logout.TabIndex = 4;
            this.btn_UAP_Logout.Text = "Logout";
            this.btn_UAP_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_UAP_Subscription
            // 
            this.lbl_UAP_Subscription.AutoSize = true;
            this.lbl_UAP_Subscription.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_Subscription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_Subscription.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_Subscription.Location = new System.Drawing.Point(12, 209);
            this.lbl_UAP_Subscription.Name = "lbl_UAP_Subscription";
            this.lbl_UAP_Subscription.Size = new System.Drawing.Size(74, 15);
            this.lbl_UAP_Subscription.TabIndex = 5;
            this.lbl_UAP_Subscription.Text = "Subscription";
            // 
            // txt_UAP_Subscription
            // 
            this.txt_UAP_Subscription.Location = new System.Drawing.Point(12, 227);
            this.txt_UAP_Subscription.Name = "txt_UAP_Subscription";
            this.txt_UAP_Subscription.ReadOnly = true;
            this.txt_UAP_Subscription.Size = new System.Drawing.Size(169, 23);
            this.txt_UAP_Subscription.TabIndex = 6;
            // 
            // dataGridView_UAP_CharList
            // 
            this.dataGridView_UAP_CharList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UAP_CharList.Location = new System.Drawing.Point(6, 22);
            this.dataGridView_UAP_CharList.Name = "dataGridView_UAP_CharList";
            this.dataGridView_UAP_CharList.RowTemplate.Height = 25;
            this.dataGridView_UAP_CharList.Size = new System.Drawing.Size(422, 295);
            this.dataGridView_UAP_CharList.TabIndex = 7;
            // 
            // groupBox_UAP
            // 
            this.groupBox_UAP.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_UAP.Controls.Add(this.dataGridView_UAP_CharList);
            this.groupBox_UAP.ForeColor = System.Drawing.Color.Black;
            this.groupBox_UAP.Location = new System.Drawing.Point(358, 196);
            this.groupBox_UAP.Name = "groupBox_UAP";
            this.groupBox_UAP.Size = new System.Drawing.Size(434, 323);
            this.groupBox_UAP.TabIndex = 8;
            this.groupBox_UAP.TabStop = false;
            this.groupBox_UAP.Text = "Characterlist";
            // 
            // lbl_UAP_CharName
            // 
            this.lbl_UAP_CharName.AutoSize = true;
            this.lbl_UAP_CharName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_CharName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_CharName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_CharName.Location = new System.Drawing.Point(953, 218);
            this.lbl_UAP_CharName.Name = "lbl_UAP_CharName";
            this.lbl_UAP_CharName.Size = new System.Drawing.Size(92, 15);
            this.lbl_UAP_CharName.TabIndex = 9;
            this.lbl_UAP_CharName.Text = "Character Name";
            // 
            // lbl_UAP_CharClass
            // 
            this.lbl_UAP_CharClass.AutoSize = true;
            this.lbl_UAP_CharClass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_CharClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_CharClass.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_CharClass.Location = new System.Drawing.Point(953, 270);
            this.lbl_UAP_CharClass.Name = "lbl_UAP_CharClass";
            this.lbl_UAP_CharClass.Size = new System.Drawing.Size(33, 15);
            this.lbl_UAP_CharClass.TabIndex = 10;
            this.lbl_UAP_CharClass.Text = "Class";
            // 
            // txt_UAP_CharName
            // 
            this.txt_UAP_CharName.Location = new System.Drawing.Point(953, 236);
            this.txt_UAP_CharName.Name = "txt_UAP_CharName";
            this.txt_UAP_CharName.Size = new System.Drawing.Size(169, 23);
            this.txt_UAP_CharName.TabIndex = 11;
            // 
            // cbo_UAP_CharClass
            // 
            this.cbo_UAP_CharClass.FormattingEnabled = true;
            this.cbo_UAP_CharClass.Location = new System.Drawing.Point(953, 288);
            this.cbo_UAP_CharClass.Name = "cbo_UAP_CharClass";
            this.cbo_UAP_CharClass.Size = new System.Drawing.Size(169, 23);
            this.cbo_UAP_CharClass.TabIndex = 12;
            // 
            // lbl_UAP_CharGender
            // 
            this.lbl_UAP_CharGender.AutoSize = true;
            this.lbl_UAP_CharGender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_CharGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_CharGender.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_CharGender.Location = new System.Drawing.Point(953, 322);
            this.lbl_UAP_CharGender.Name = "lbl_UAP_CharGender";
            this.lbl_UAP_CharGender.Size = new System.Drawing.Size(45, 15);
            this.lbl_UAP_CharGender.TabIndex = 13;
            this.lbl_UAP_CharGender.Text = "Gender";
            // 
            // cbo_UAP_CharGender
            // 
            this.cbo_UAP_CharGender.FormattingEnabled = true;
            this.cbo_UAP_CharGender.Location = new System.Drawing.Point(953, 340);
            this.cbo_UAP_CharGender.Name = "cbo_UAP_CharGender";
            this.cbo_UAP_CharGender.Size = new System.Drawing.Size(169, 23);
            this.cbo_UAP_CharGender.TabIndex = 14;
            // 
            // btn_UAP_UpdateChar
            // 
            this.btn_UAP_UpdateChar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_UAP_UpdateChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UAP_UpdateChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UAP_UpdateChar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UAP_UpdateChar.Location = new System.Drawing.Point(845, 491);
            this.btn_UAP_UpdateChar.Name = "btn_UAP_UpdateChar";
            this.btn_UAP_UpdateChar.Size = new System.Drawing.Size(69, 28);
            this.btn_UAP_UpdateChar.TabIndex = 15;
            this.btn_UAP_UpdateChar.Text = "Update";
            this.btn_UAP_UpdateChar.UseVisualStyleBackColor = false;
            // 
            // btn_UAP_CreateChar
            // 
            this.btn_UAP_CreateChar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_UAP_CreateChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UAP_CreateChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UAP_CreateChar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UAP_CreateChar.Location = new System.Drawing.Point(933, 491);
            this.btn_UAP_CreateChar.Name = "btn_UAP_CreateChar";
            this.btn_UAP_CreateChar.Size = new System.Drawing.Size(69, 28);
            this.btn_UAP_CreateChar.TabIndex = 16;
            this.btn_UAP_CreateChar.Text = "Create";
            this.btn_UAP_CreateChar.UseVisualStyleBackColor = false;
            this.btn_UAP_CreateChar.Click += new System.EventHandler(this.btn_UAP_CreateChar_Click);
            // 
            // btn_UAP_DeleteChar
            // 
            this.btn_UAP_DeleteChar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_UAP_DeleteChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UAP_DeleteChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UAP_DeleteChar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UAP_DeleteChar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_UAP_DeleteChar.Location = new System.Drawing.Point(1021, 491);
            this.btn_UAP_DeleteChar.Name = "btn_UAP_DeleteChar";
            this.btn_UAP_DeleteChar.Size = new System.Drawing.Size(69, 28);
            this.btn_UAP_DeleteChar.TabIndex = 17;
            this.btn_UAP_DeleteChar.Text = "Delete";
            this.btn_UAP_DeleteChar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(807, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 244);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_UAP_CharWeapon
            // 
            this.lbl_UAP_CharWeapon.AutoSize = true;
            this.lbl_UAP_CharWeapon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_CharWeapon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_CharWeapon.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_CharWeapon.Location = new System.Drawing.Point(953, 374);
            this.lbl_UAP_CharWeapon.Name = "lbl_UAP_CharWeapon";
            this.lbl_UAP_CharWeapon.Size = new System.Drawing.Size(52, 15);
            this.lbl_UAP_CharWeapon.TabIndex = 19;
            this.lbl_UAP_CharWeapon.Text = "Weapon";
            // 
            // cbo_UAP_CharWeapon
            // 
            this.cbo_UAP_CharWeapon.FormattingEnabled = true;
            this.cbo_UAP_CharWeapon.Location = new System.Drawing.Point(953, 392);
            this.cbo_UAP_CharWeapon.Name = "cbo_UAP_CharWeapon";
            this.cbo_UAP_CharWeapon.Size = new System.Drawing.Size(169, 23);
            this.cbo_UAP_CharWeapon.TabIndex = 20;
            // 
            // lbl_UAP_MemberSince
            // 
            this.lbl_UAP_MemberSince.AutoSize = true;
            this.lbl_UAP_MemberSince.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UAP_MemberSince.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UAP_MemberSince.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_UAP_MemberSince.Location = new System.Drawing.Point(12, 270);
            this.lbl_UAP_MemberSince.Name = "lbl_UAP_MemberSince";
            this.lbl_UAP_MemberSince.Size = new System.Drawing.Size(84, 15);
            this.lbl_UAP_MemberSince.TabIndex = 21;
            this.lbl_UAP_MemberSince.Text = "Member Since";
            // 
            // txt_UAP_MemberSince
            // 
            this.txt_UAP_MemberSince.Location = new System.Drawing.Point(11, 288);
            this.txt_UAP_MemberSince.Name = "txt_UAP_MemberSince";
            this.txt_UAP_MemberSince.ReadOnly = true;
            this.txt_UAP_MemberSince.Size = new System.Drawing.Size(169, 23);
            this.txt_UAP_MemberSince.TabIndex = 22;
            // 
            // UserAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_Fight_Game.Properties.Resources.UserAccountPageBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.txt_UAP_MemberSince);
            this.Controls.Add(this.lbl_UAP_MemberSince);
            this.Controls.Add(this.cbo_UAP_CharWeapon);
            this.Controls.Add(this.lbl_UAP_CharWeapon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_UAP_DeleteChar);
            this.Controls.Add(this.btn_UAP_CreateChar);
            this.Controls.Add(this.btn_UAP_UpdateChar);
            this.Controls.Add(this.cbo_UAP_CharGender);
            this.Controls.Add(this.lbl_UAP_CharGender);
            this.Controls.Add(this.cbo_UAP_CharClass);
            this.Controls.Add(this.txt_UAP_CharName);
            this.Controls.Add(this.lbl_UAP_CharClass);
            this.Controls.Add(this.lbl_UAP_CharName);
            this.Controls.Add(this.groupBox_UAP);
            this.Controls.Add(this.txt_UAP_Subscription);
            this.Controls.Add(this.lbl_UAP_Subscription);
            this.Controls.Add(this.btn_UAP_Logout);
            this.Controls.Add(this.txt_UAP_LoggedInAs);
            this.Controls.Add(this.lbl_UAP_LoggedInAs);
            this.Controls.Add(this.btn_UAP_Back);
            this.Controls.Add(this.lbl_UAP_Header);
            this.Name = "UserAccountPage";
            this.Text = "UserAccountPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UAP_CharList)).EndInit();
            this.groupBox_UAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UAP_Header;
        private System.Windows.Forms.Button btn_UAP_Back;
        private System.Windows.Forms.Label lbl_UAP_LoggedInAs;
        private System.Windows.Forms.TextBox txt_UAP_LoggedInAs;
        private System.Windows.Forms.Button btn_UAP_Logout;
        private System.Windows.Forms.Label lbl_UAP_Subscription;
        private System.Windows.Forms.TextBox txt_UAP_Subscription;
        private System.Windows.Forms.DataGridView dataGridView_UAP_CharList;
        private System.Windows.Forms.GroupBox groupBox_UAP;
        private System.Windows.Forms.Label lbl_UAP_CharName;
        private System.Windows.Forms.Label lbl_UAP_CharClass;
        private System.Windows.Forms.TextBox txt_UAP_CharName;
        private System.Windows.Forms.ComboBox cbo_UAP_CharClass;
        private System.Windows.Forms.Label lbl_UAP_CharGender;
        private System.Windows.Forms.ComboBox cbo_UAP_CharGender;
        private System.Windows.Forms.Button btn_UAP_UpdateChar;
        private System.Windows.Forms.Button btn_UAP_CreateChar;
        private System.Windows.Forms.Button btn_UAP_DeleteChar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UAP_CharWeapon;
        private System.Windows.Forms.ComboBox cbo_UAP_CharWeapon;
        private System.Windows.Forms.Label lbl_UAP_MemberSince;
        private System.Windows.Forms.TextBox txt_UAP_MemberSince;
    }
}