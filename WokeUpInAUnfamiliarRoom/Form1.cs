using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WokeUpInAUnfamiliarRoom
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random ranGen = new Random();
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You Woke Up In A Unfamilair Room. You Are So" + "\n" + " Thirsty, You Will Die If You Don't Drink Anything Soon." + "\n" + " There Is A Glass Of Liquid On The Nightstand. You Must Take A Sip." + "\n" + " There Is A Chance That It's BLEACH.";
            redLabel.Text = "Drink";
            blueLabel.Text = "Drink";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)//Red Button
            {
                if (scene == 0)
                {
                    int bleach = ranGen.Next(1, 11);
                    if (bleach > 7)
                    {
                        scene = 1;
                    }
                    else if (bleach < 7)
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1) { scene = 0; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 5) { scene = 0; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 7) { scene = 0; }
                else if (scene == 4) { scene = 7; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 6) { scene = 11; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 8) { scene = 14; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 17) { scene = 15; }
                else if (scene ==14) { scene = 17; }
                

            }
            if (e.KeyCode == Keys.B)//Blue Button 
            {
                if (scene == 0)//Starting Scene
                {
                    int bleach = ranGen.Next(1, 11); 
                    if (bleach > 7)
                    {
                        scene = 1;
                    }
                    else if (bleach < 7)
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 7)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 4) { scene = 9; }
                else if (scene == 6) { scene = 10; }
                else if (scene == 10)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 12)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 13)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 8) { scene = 13; }
                else if (scene == 9) { scene = 15; }
                else if (scene == 15)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 16)
                {
                    outputLabel.Text = "Thanks For Playing !!!!!!!";
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                }
                else if (scene == 17) { scene = 16; }
                else if (scene == 14) { scene = 17; } 
                

            }
            if (e.KeyCode == Keys.X)//Yellow Button
            {
                if(scene == 4) { scene = 8;}
            }



















            switch (scene)
            {
                case 0: //Starting Scene Is 0
                    outputLabel.Text = "You Woke Up In A Unfamilair Room. You Are So" + "\n" + " Thirsty, You Will Die If You Don't Drink Anything Soon." + "\n" + " There Is A Glass Of Liquid On The Nightstand. You Must Take A Sip." + "\n" + " There Is A Chance That It's BLEACH.";
                    redLabel.Text = "Drink";
                    blueLabel.Text = "Drink";

                    break;

                case 1://Drank the Bleach 
                    outputLabel.Text = "You Drank Bleach and DIED!";
                    redLabel.Text = "Play Again?";
                    blueLabel.Text = "Exit";
                    break;
                case 2://Glass was Water
                    outputLabel.Text = "The Glass Was Water!" + "\n" + "You Can Now Choose To Look Around The Room or Go Out The Door!";
                    redLabel.Text = "Look Around The Room";
                    blueLabel.Text = "Go Outside of The Room";
                    break;
                case 3://Look aroung The Room
                    outputLabel.Text = "There Are A Bunch Of Creepy Clown Paintings in The Room." + "\n" + "You Noticed that there are Cabinents and A Closet!";
                    redLabel.Text = "Look Inside The Cabinents!";
                    blueLabel.Text = "Look Inside The Closet";
                    break;
                case 4:// Go Outside of the Room
                    outputLabel.Text = "When you open the door there is a hallway containg 3 Doors, " + "\n" + "first saying your worst nightmare, the second one saying " + "\n" + "your best dream the last one saying Exit.";
                    yellowButton.Visible = true;
                    yellowLabel.Visible = true;
                    xLabel.Visible = true;
                    yellowLabel.Text = "Worst NightMare Door";
                    redLabel.Text = "Best Dream Door";
                    blueLabel.Text = "Exit Door";
                    break;
                case 5://Checked inside the closet
                    outputLabel.Text = "In The Closet There was a Clown that stabbed you death.";
                    redLabel.Text = "Play Again?";
                    blueLabel.Text = "Exit";
                    break;
                case 6://Checked inside the Cabinents
                    outputLabel.Text = "In The cabinets there are a Rubik's cube and a cell phone." + "\n" + " What do you pick up?";
                    redLabel.Text = "Rubik's Cube";
                    blueLabel.Text = "Cell Phone";
                    break;
                case 7://went through the best dream door
                    outputLabel.Text = "Your best dream was a bunch of Clowns stabbing you to Death";
                    redLabel.Text = "Play Again?";
                    blueLabel.Text = "Exit";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    xLabel.Visible = false;
                    break;
                case 8://Worst Nightmare Door
                    outputLabel.Text = "Your Worst Nightmare was Swallowing Pills. " + "\n" + "There is a red and blue pill on a table, with a sign" + "\n" + "Saying: You MUST SWALLOW ONE";
                    redLabel.Text = "Red Pill";
                    blueLabel.Text = "Blue Pill";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    xLabel.Visible = false;
                    break;
                case 9://Exit Door 
                    outputLabel.Text = "You are outside and the city is cold and empty, explore the City?";
                    redLabel.Text = "YESSIR!";
                    blueLabel.Text = "Kill Your Self";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    xLabel.Visible = false;
                    break;
                case 10://Check The Phone 
                    outputLabel.Text = "As soon as you open the phone a girl crawls out of it and stabs you";
                    redLabel.Text = "Play Again?";
                    blueLabel.Text = "Exit";
                    break;
                case 11://Do The Rubik's Cube
                    outputLabel.Text = "Rubix Cube  unlocks a secret door behind the clown painting." + "\n" + "Go Outside or stay inside?";
                    redLabel.Text = "Stay Inside The Room";
                    blueLabel.Text = "Go Outside The Door";
                    break;
                case 12://Stay Inside
                    outputLabel.Text = "The Door Slowly Closed off and the room exploded and so did you.";
                    redLabel.Text = "Play Again?";
                    blueLabel.Text = "Exit"; 
                    break;
                case 13://Blue pill
                    outputLabel.Text = "You start vomiting blood. Then you died.";
                    redLabel.Text = "Play Again?";
                    blueLabel.Text = "Exit";
                    break;
                case 14://Red Pill
                    outputLabel.Text = "You Feel Drowzy and Get Knocked DOWN to the GROUND...";
                    redLabel.Text = "Wake Up!";
                    blueLabel.Text = "Wake Up!";
                    break;
                case 15:// Kill Your Self
                    outputLabel.Text = "You chose to commit suicide...";
                    redLabel.Text = "Play again?";
                    blueLabel.Text = "Exit";
                    break;
                case 16://Ending scene
                    outputLabel.Text = "You Escaped The House! The City Will Be Part Two! Thanks For PLAYING";
                    redLabel.Text = "EXIT!";
                    blueLabel.Text = "EXIT!";
                    break;
                case 17://Woke Up!
                    outputLabel.Text = "You Woke Up Outside and there is a City! Explore?";
                    redLabel.Text = "Kill Your self";
                    blueLabel.Text = "Explore the City";
                    break; 
                
                    








            }
        }
    }
}
