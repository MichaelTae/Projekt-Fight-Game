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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Enemies enemies = new Priest(new Thief(new Warrior()));


            MessageBox.Show(enemies.AttackDesc());

            Console.WriteLine("hej");

            //Test kod kommer flyttas ----------------------------------------------------
            var builder = new Weaponbuilder();
             
            BuildStandardSword(builder.setBlade("standard"));
            builder.build().Blade.ToString();

            var blade = builder.build().Blade;
            
            
            MessageBox.Show(builder.build().Blade + builder.build().Hilt);

            
        }

        
        public void BuildStandardSword(IWeaponBuilder standardBuilder)
        {


            standardBuilder.setBlade("Standard").setEnchantment("none").setHilt("standard").setPommel("round").setSize("standard");


        }

        //-----------------------------------------------------------------------------

    }
}
