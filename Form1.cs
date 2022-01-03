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
        Character character = new Player();
        IEnemies enemies = RandomizeEnemy();
        public Form1()
        {
            InitializeComponent();
            //NotLoggedIn();

            var subject = new Subject();
            var observerA = new Subscriber();
            subject.Attach(observerA);
            subject.State = 0;
            subject.Notify();


            
            IEnemies enemies = RandomizeEnemy();
            string health = enemies.Health().ToString();
            lbl_F1_EnemyHealth100.Text = health;
            txt_F1_EnemyHealth.Text = health;
            txt_F1_UserCharHealth.Text = character.Health().ToString();
            lbl_F1_UserCharHealth100.Text = character.Health().ToString();

        }


        public static IEnemies RandomizeEnemy()
        {
            Random subClassRandom = new Random();
            Random mainClassRnd = new Random();
            IEnemies standardEnemies = new Warrior();
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
                        IEnemies enemies = new Warrior();
                        return enemies;
                    }
                    else if(myMainClass == 0)
                    {
                        IEnemies enemies = new Mage();
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
                            IEnemies enemies = new Priest(new Warrior());
                            return enemies;
                        }
                        else if ( mySubClass == 1)
                        {
                            IEnemies enemies = new Marauder(new Warrior());
                            return enemies;
                        }

                        else if (mySubClass == 2)
                        {
                            IEnemies enemies = new Thief(new Warrior());
                            return enemies;
                        }

                        else if (mySubClass == 4)
                        {
                            IEnemies enemies = new Rogue(new Warrior());
                            return enemies;
                        }
                    }

                    else if (myMainClass == 0)
                        {

                        if (mySubClass == 0)
                        {
                            IEnemies enemies = new Priest(new Mage());
                            return enemies;
                        }
                        else if (mySubClass == 1)
                        {
                            IEnemies enemies = new Marauder(new Mage());
                            return enemies;
                        }

                        else if (mySubClass == 2)
                        {
                            IEnemies enemies = new Thief(new Mage());
                            return enemies;
                        }

                        else if (mySubClass == 4)
                        {
                            IEnemies enemies = new Rogue(new Mage());
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
        private void btn_F1_Logout_Click(object sender, EventArgs e)
        {
            NotLoggedIn();
            MessageBox.Show("Thank you for playing!");
        }
        private void NotLoggedIn()
        {
            lbl_F1_LoggedInAs.Visible = false;
            txt_F1_LoggedInAs.Visible = false;
            btn_F1_MyPage.Visible = false;
            btn_F1_Logout.Visible = false;
            txt_F1_Username.Text = "";
            txt_F1_Password.Text = "";
        }

        private void LoggedIn()
        {
            lbl_F1_LoggedInAs.Visible = true;
            txt_F1_LoggedInAs.Visible = true;
            btn_F1_MyPage.Visible = true;
            btn_F1_Logout.Visible = true;
            lbl_F1_SignUp.Visible = false;
            lbl_F1_Username.Visible = false;
            lbl_F1_Password.Visible = false;
            txt_F1_Username.Visible = false;
            txt_F1_Password.Visible = false;
            btn_F1_Login.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int enemyHealth = Convert.ToInt32(txt_F1_EnemyHealth.Text);
            int myHealth = Convert.ToInt32(txt_F1_UserCharHealth.Text);
            enemyHealth -= character.AttackDamage();
            myHealth -= enemies.AttackDamage();
            txt_F1_EnemyHealth.Text = enemyHealth.ToString();
            txt_F1_UserCharHealth.Text = myHealth.ToString();
            

            lbx_F1.Items.Add(character.AttackDesc() + character.AttackDamage());
            lbx_F1.Items.Add(enemies.AttackDesc() + "for" + enemies.AttackDamage() );

           


            if (Convert.ToInt32(txt_F1_EnemyHealth.Text) <= 0)
            {
                lbx_F1.Items.Add("You Win, next enemy coming up!");

                IEnemies enemies = RandomizeEnemy();
                string health = enemies.Health().ToString();
                lbl_F1_EnemyHealth100.Text = health;
                txt_F1_EnemyHealth.Text = health;


            }

            if (Convert.ToInt32(txt_F1_UserCharHealth.Text) <= 0)
            {
                lbx_F1.Items.Add("You Died");

                Character character = new Player();
                IEnemies enemies = RandomizeEnemy();
                string health = enemies.Health().ToString();
                lbl_F1_EnemyHealth100.Text = health;
                txt_F1_EnemyHealth.Text = health;
                txt_F1_UserCharHealth.Text = character.Health().ToString();
                lbl_F1_UserCharHealth100.Text = character.Health().ToString();

                

            }





        }

        private void lbx_F1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }
    }
}


