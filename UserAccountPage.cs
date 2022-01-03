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
    public partial class UserAccountPage : Form
    {
        public UserAccountPage()
        {
            InitializeComponent();
        }

        private void btn_UAP_Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btn_UAP_CreateChar_Click(object sender, EventArgs e)
        {
            string weapon = cbo_UAP_CharWeapon.SelectedItem.ToString();
            if (weapon == "Standard Sword")
            {
                var a = new WeaponPattern();
                var b = new Weaponbuilder();
                a.BuildStandardSword(b);


            }
            else if (weapon == "Short Dagger")
            {
                var a = new WeaponPattern();
                var b = new Weaponbuilder();
                a.ShortDagger(b);

            }
        }
    }
}
