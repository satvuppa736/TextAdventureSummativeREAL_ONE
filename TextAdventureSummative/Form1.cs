///

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

namespace TextAdventureSummative
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random randGen = new Random();
        int attackValue, stealthValue;
        SoundPlayer scene2 = new SoundPlayer(Properties.Resources.Scene_2);
        SoundPlayer scene4 = new SoundPlayer(Properties.Resources.Scene_4);
        SoundPlayer scene5 = new SoundPlayer(Properties.Resources.Scene_5);
        SoundPlayer scene8 = new SoundPlayer(Properties.Resources.Scene_8);
        SoundPlayer scene11 = new SoundPlayer(Properties.Resources.Scene_11);
        SoundPlayer scene13 = new SoundPlayer(Properties.Resources.Scene_13);
        SoundPlayer scene16 = new SoundPlayer(Properties.Resources.Scene_16);
        SoundPlayer scene20 = new SoundPlayer(Properties.Resources.Scene_20);
        SoundPlayer scene22 = new SoundPlayer(Properties.Resources.Scene_22);
        SoundPlayer scene25 = new SoundPlayer(Properties.Resources.Scene_25);
        SoundPlayer scene26 = new SoundPlayer(Properties.Resources.Scene_26_end_);
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You wake up in a dark room with a small trap door and a single torch. Do you go into the trap door or stay in the room?";
            redLabel.Text = "LEAVE";
            blueLabel.Text = "STAY";
            greenLabel.Text = "";
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene = 3;
                }

                else if (scene == 3)
                {
                    attackValue = randGen.Next(1, 11);
                    if (attackValue >= 4)
                    {
                        scene = 6;
                    }
                    else 
                    {
                        scene = 5;
                    }
                }
                else if (scene == 5)
                {
                    scene = 26;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 7 || scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 12 || scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18 || scene == 19 || scene == 21)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 16;
                }

                else if (scene == 26)
                {
                    scene = 0;
                }
                    
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 2)
                {
                    scene = 26;
                }

                else if (scene == 1)
                {
                    scene = 4;
                }

                else if (scene == 4)
                {
                    scene = 26;
                }

                else if (scene == 6)
                {
                    scene = 8;
                }

                else if (scene == 8)
                {
                    scene = 26;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }

                else if (scene == 11)
                {
                    scene = 26;
                }

                else if (scene == 12)
                {

                    attackValue = randGen.Next(1, 11);
                    if (attackValue >= 4)
                    {
                        scene = 14;
                    }
                    else
                    {
                        scene = 13;
                    }
                }
                else if (scene == 13)
                {
                    scene = 26;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }

                else if (scene == 16)
                {
                    scene = 26;
                }

                else if (scene == 17)
                {
                    stealthValue = randGen.Next(1, 11);
                    if (stealthValue >= 4)
                    {
                        scene = 21;
                    }
                    else
                    {
                        scene = 20;
                    }
                }

                else if (scene == 20)
                {
                    scene = 26;
                }

                else if (scene == 23)
                {
                    scene = 25;
                }

                else if (scene == 25)
                {
                    scene = 26;
                } 

                else if (scene == 26)
                {
                    Application.Exit();        //Closes program when "NO" is selected when asked "PLAY AGAIN?"
                }
            }

            else if (e.KeyCode == Keys.Space)  //Green Button press
            {
                if (scene == 6)
                {
                    scene = 9;
                }

                else if (scene == 17)
                {
                    Thread.Sleep(5000);
                    Refresh();

                    attackValue = randGen.Next(1, 11);
                    if (attackValue >= 4)
                    {
                        scene = 19;
                    }
                    else
                    {
                        scene = 22;
                    }
                }

                else if (scene == 22)
                {
                    scene = 26;
                }             
            }

            switch (scene)  //Switch statements to advance scenes
            {
                case 0:
                    outputLabel.Text = "You wake up in a dark room with a small trap door and a single torch. Do you go into the trap door or stay in the room?";
                    redLabel.Text = "LEAVE";
                    blueLabel.Text = "STAY";
                    break;
                case 1:
                    outputLabel.Text = "You drop down into a long hallway and see a light in the distance. Do you return to grab your torch or start walking?";
                    redLabel.Text = "GET TORCH";
                    blueLabel.Text = "WALK";
                    break;
                case 2:
                    outputLabel.Text = "You crawl into a ball and win! Congrats!";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    Refresh();
                    scene2.Play();
                    Thread.Sleep(5000);
                    scene2.Stop();
                    break;
                case 3:
                    outputLabel.Text = "You grab your torch and slowly walk down the hallway. You jump the pit. A Native jumps out and attacks you. You fight back.";
                    redLabel.Text = "CONTINUE";
                    blueLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You start walking but end up falling into a pit of spikes left by the Natives. You died.";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    Refresh();
                    scene4.Play();
                    Thread.Sleep(7000);
                    scene4.Stop();
                    break;
                case 5:
                    outputLabel.Text = "You die due to your attack being too weak. Should've taken karate when you were little";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    Refresh();
                    scene5.Play();
                    Thread.Sleep(6000);
                    scene5.Stop();
                    break;
                case 6:
                    outputLabel.Text = "You mercilessly beat the Native and continue to the light. You find a room with a stream and more Natives. Do you, Stealth Kill the Natives, Fight them head on, or use the stream to swim past?";
                    redLabel.Text = "SWIM";
                    blueLabel.Text = "FIGHT";
                    greenLabel.Text = "STEALTH KILL";
                    break;
                case 7:
                    outputLabel.Text = "You get injured by the piranhas but you escape un noticed!";
                    redLabel.Text = "CONINUE";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You die due to another Native named 'Mnbungo' that suck up behind you. You're dead";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    Refresh();
                    scene8.Play();
                    Thread.Sleep(8000);
                    scene8.Stop();
                    break;
                case 9:
                    outputLabel.Text = "You killed them and got away. What did you think was gonna happen?";
                    redLabel.Text = "CONTINUE";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "You get across the stream and make your way to a room. A pedestal stands in the center of the room, an artifact is on the pedestal. An exit door stands across the room. Do you take the artifact or make a break for the door?";
                    redLabel.Text = "TAKE ARTIFACT";
                    blueLabel.Text = "LEAVE";
                    greenLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "YOU WON!!!!!!!!!! go away now";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    Refresh();
                    scene11.Play();
                    Thread.Sleep(8000);
                    scene11.Stop();
                    break;
                case 12:
                    outputLabel.Text = "The exit door slams shut but you manage to find a grappling hook and attach it to a grate over head. Natives suddenly approach out of nowhere. Do you fight or climb up the grappling hook?";
                    redLabel.Text = "CLIMB";
                    blueLabel.Text = "FIGHT";
                    greenLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "You get beaten senseless. Good Job. You died";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    Refresh();
                    scene13.Play();
                    Thread.Sleep(9000);
                    scene13.Stop();
                    break;
                case 14:
                    outputLabel.Text = " You kill all of the Natives and start climbing the rope.";
                    redLabel.Text = "CONTINUE";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You climb up the rope and approach a grate. Do you squeeze through the grat or break it open?";
                    redLabel.Text = "BREAK";
                    blueLabel.Text = "SQUEEZE THROUGH";
                    greenLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "HEY FATTY! You tried squeezing through the grate and ended up breaking a rib that pnctured your heart. You Died, probably again!";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    Refresh();
                    scene16.Play();
                    Thread.Sleep(10000);
                    scene16.Stop();
                    break;
                case 17:
                    outputLabel.Text = "You successfully break open the grate and make it to the surface where there are more Natives. Do you fight the Natives head on, sneak past, or stealth kill them all?";
                    redLabel.Text = "SNEAK";
                    blueLabel.Text = "STEALTH KILL";
                    greenLabel.Text = "FIGHT";
                    break;
                case 18:
                    outputLabel.Text = "You sneak past and make a mad dash to the edge of the jungle";
                    redLabel.Text = "CONTINUE";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You killed everyone, stop being so barbaric. THEY COULD AHAVE FAMILIES.";
                    redLabel.Text = "CONTINUE";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "YOU DIED. BE QUIETER";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    Refresh();
                    scene20.Play();
                    Thread.Sleep(11000);
                    scene20.Stop();
                    break;
                case 21:
                    outputLabel.Text = "You stealthily killed everyone and make a mad dash to the path ahead. Good Job lil' ninja.";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "YAAAAAAAAAAY you died, again! This is so much fun!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "CONTINUE";
                    Refresh();
                    scene22.Play();
                    Thread.Sleep(13000);
                    scene22.Stop();
                    break;
                case 23:
                    outputLabel.Text = "You now come to a split in the road. Do you, go left or right? Don't mess it up now. only one answer is RIGHT";
                    redLabel.Text = "RIGHT";
                    blueLabel.Text = "left";
                    greenLabel.Text = "";
                    break;
                case 24:
                    outputLabel.Text = "YOU WON!";
                    redLabel.Text = "CONTINUE";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 25:
                    outputLabel.Text = "Shoulda taken my hint dummy!";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    greenLabel.Text = "";
                    Refresh();
                    scene25.Play();
                    Thread.Sleep(32000);
                    scene25.Stop();
                    break;
                case 26:
                    outputLabel.Text = "PLAY AGAIN?";
                    redLabel.Text = "YES!";
                    blueLabel.Text = "NO.";
                    greenLabel.Text = "";
                    Refresh();
                    scene26.Play();
                    Thread.Sleep(7000);
                    scene26.Stop();
                    break;
                default:
                    outputLabel.Text = "You wake up in a dark room with a small trap door and a single torch. Do you go into the trap door or stay in the room?";
                    redLabel.Text = "LEAVE";
                    blueLabel.Text = "STAY";
                    break;
            }
        }
    }
}
