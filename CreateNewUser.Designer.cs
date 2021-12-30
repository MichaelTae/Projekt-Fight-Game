
namespace Projekt_Fight_Game
{
    partial class CreateNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateNewUser = new System.Windows.Forms.TextBox();
            this.txtCreateNewPassword = new System.Windows.Forms.TextBox();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtCreateNewUser
            // 
            this.txtCreateNewUser.Location = new System.Drawing.Point(107, 73);
            this.txtCreateNewUser.Name = "txtCreateNewUser";
            this.txtCreateNewUser.Size = new System.Drawing.Size(150, 31);
            this.txtCreateNewUser.TabIndex = 2;
            // 
            // txtCreateNewPassword
            // 
            this.txtCreateNewPassword.Location = new System.Drawing.Point(107, 144);
            this.txtCreateNewPassword.Name = "txtCreateNewPassword";
            this.txtCreateNewPassword.Size = new System.Drawing.Size(150, 31);
            this.txtCreateNewPassword.TabIndex = 3;
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Location = new System.Drawing.Point(107, 199);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(150, 34);
            this.btnCreateNewUser.TabIndex = 4;
            this.btnCreateNewUser.Text = "Create Account";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 279);
            this.Controls.Add(this.btnCreateNewUser);
            this.Controls.Add(this.txtCreateNewPassword);
            this.Controls.Add(this.txtCreateNewUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewUser";
            this.Text = "CreateNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateNewUser;
        private System.Windows.Forms.TextBox txtCreateNewPassword;
        private System.Windows.Forms.Button btnCreateNewUser;
    }
}