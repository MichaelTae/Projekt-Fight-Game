using Projekt_Fight_Game.Observer;
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

            var subject = new Subject();
            var observerA = new Subscriber();
            subject.Attach(observerA);
            subject.State = 0;
            subject.Notify();


            Enemies enemies = new Priest(new Thief(new Warrior()));


            MessageBox.Show(enemies.AttackDesc());



            //Test kod kommer flyttas ----------------------------------------------------
            var builder = new Weaponbuilder();
            var WP = new WeaponPattern();
            WP.BuildStandardSword(builder);
            builder.build().Blade.ToString();
            MessageBox.Show(builder.build().Blade + builder.build().Hilt);

            WP.ArtifactSpear(builder);
            builder.build();
            MessageBox.Show(builder.build().Blade + " " + builder.build().Enchantment + " " + builder.build().Size);




        }

        
       

    }

    

}


