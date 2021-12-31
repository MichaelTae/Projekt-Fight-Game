using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Fight_Game
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_CNU_Create_Click(object sender, EventArgs e)
        {
            string checkFields = SignUpCheckFields();

            if (checkFields == "")
            {

                MessageBox.Show("Thank you for becoming a member " + txt_CNU_Username.Text + ".");

                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("The following information is missing: " + checkFields + "\n\nPlease fill out all the information needed to sign up.");
            }

        }
        private string SignUpCheckFields()
        {
            string checkedInfo = "";

            if (txt_CNU_Username.Text == "" || txt_CNU_Password.Text == "")
            {
                string[] infoMessage = new string[2];
                for (int i = 0; i < infoMessage.Length; i++)
                {
                    if (txt_CNU_Username.Text == "")
                    {
                        infoMessage[i] += "\nUsername";
                    }
                    if (txt_CNU_Password.Text == "")
                    {
                        infoMessage[i] += "\nPassword";
                    }
                    return "\n" + infoMessage[i];
                }
            }
            return checkedInfo;
        }

    }
}
