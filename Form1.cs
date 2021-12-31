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


            Enemies enemies = randomizeEnemy();


            //MessageBox.Show(enemies.AttackDesc());
            // MessageBox.Show(Convert.ToString(enemies.AttackDamage()));



            //Test kod kommer flyttas ----------------------------------------------------
            var builder = new Weaponbuilder();
            var WP = new WeaponPattern();
            WP.BuildStandardSword(builder);
            builder.build().Blade.ToString();
            //MessageBox.Show(builder.build().Blade + builder.build().Hilt);

            WP.ArtifactSpear(builder);
            builder.build();
            //MessageBox.Show(builder.build().Blade + " " + builder.build().Enchantment + " " + builder.build().Size);




        }


        public Enemies randomizeEnemy()
        {
            Random subClassRandom = new Random();
            Random mainClassRnd = new Random();
            Enemies standardEnemies = new Warrior();
            int myMainClass;
            int mySubClass;

            int rndNmbr = subClassRandom.Next(0,3);

            for (int i = 0; i < rndNmbr; i++)
            {
                if (rndNmbr == 0)
                {

                    
                    myMainClass =mainClassRnd.Next(0, 1);
                    

                    if (myMainClass == 1)
                    {
                        Enemies enemies = new Warrior();
                        return enemies;
                    }
                    else if(myMainClass == 0)
                    {
                        Enemies enemies = new Mage();
                        return enemies;
                    }
                    
                }

                else if (rndNmbr > 0)
                {
                    myMainClass = mainClassRnd.Next(0, 1);
                    mySubClass = subClassRandom.Next(0, 3);

                    if (myMainClass == 1)
                    {
                        
                        if (mySubClass == 0)
                        {
                            Enemies enemies = new Priest(new Warrior());
                            return enemies;
                        }
                        else if ( mySubClass == 1)
                        {
                            Enemies enemies = new Marauder(new Warrior());
                            return enemies;
                        }

                        else if (mySubClass == 2)
                        {
                            Enemies enemies = new Thief(new Warrior());
                            return enemies;
                        }

                        else if (mySubClass == 4)
                        {
                            Enemies enemies = new Rogue(new Warrior());
                            return enemies;
                        }
                    }

                    else if (myMainClass == 0)
                        {

                        if (mySubClass == 0)
                        {
                            Enemies enemies = new Priest(new Mage());
                            return enemies;
                        }
                        else if (mySubClass == 1)
                        {
                            Enemies enemies = new Marauder(new Mage());
                            return enemies;
                        }

                        else if (mySubClass == 2)
                        {
                            Enemies enemies = new Thief(new Mage());
                            return enemies;
                        }

                        else if (mySubClass == 4)
                        {
                            Enemies enemies = new Rogue(new Mage());
                            return enemies;
                        }

                   

                    }
              
                }

            

            }


            return standardEnemies;
        }



        private void btn_F1_MyPage_Click(object sender, EventArgs e)
        {
            UserAccountPage userAccountPage = new UserAccountPage();
            this.Hide();
            userAccountPage.Show();
        }

        private void lbl_F1_SignUp_Click(object sender, EventArgs e)
        {
            CreateNewUser createNewUser = new CreateNewUser();
            createNewUser.Show();
        }
    }

    

}


