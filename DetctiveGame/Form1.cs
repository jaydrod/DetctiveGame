using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DetctiveGame
{
    public partial class From1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0; 
        public From1()
        {
            InitializeComponent();
            //display initial message and options
            pictureBox1.Image = Properties.Resources.images;
            SoundPlayer player = new SoundPlayer(Properties.Resources.heavy_rain_daniel_simon);
            player.Play();
            outputLable.Text = "You are a detective at a crime scene. What do you do first";
            redLabel.Text = "Ask police what happened";
            blueLabel.Text = "Ask wittness what happened"; 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M) //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 7) { scene = 99; }
                else if (scene == 10) { scene = 99; }
                else if (scene == 99) { scene = 0; }
                
            }
            else if (e.KeyCode == Keys.B) //blue button press
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 2) { scene = 9; }
                else if (scene == 9) { scene = 99; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 4) { scene = 3; }
                else if (scene == 3) { scene = 10; }
                else if (scene == 10) { scene = 99; }
                else if (scene == 99) { this.Close(); }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 99; }
            }
            else if (e.KeyCode == Keys.C) //yellow button press
            {
                if (scene == 3 ) { scene = 6; }
                else if (scene == 6 ) { scene = 3; }
            }
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0: //start scene 
                    outputLable.Text = "You are a detective at a crime scene. What do you do first";
                    redLabel.Text = "Ask police what happened";
                    blueLabel.Text = "Ask wittness what happened";
                    yellowLabel.Text = "";
                    break;
                case 1:
                    outputLable.Text = "The police tell you that it was a murder of a young man named Elliot who was" +
                        " a bisnes man on his way home, He was shot from the back and then mugged. What do you do next?";
                    redLabel.Text = "investigate";
                    blueLabel.Text = "ask wittness";
                    yellowLabel.Text = "";
                    break;
                case 2:
                    outputLable.Text = "She tells you that she hears the gun shot to see a guy mugging Elliot and then running away, " +
                        "she didn't get his face but she knows it's a white man about 6 foot and he was wearing a black hoodie with his hood up and" +
                        " baggy jeans You write down The information she gave you and go to Investigate. What do you do";
                    redLabel.Text = "Investigate";
                    blueLabel.Text = "Give up and go home";
                    yellowLabel.Text = "";

                    break;
                case 3:
                    outputLable.Text = "You see that the person is shot in the back of the head and that his entire wallet has been taken, " +
                        "you predict that he is in his early to mid 30's. What next? ? ";
                    redLabel.Text = "Check by the body";
                    blueLabel.Text = "Check by the ally";
                    yellowLabel.Text = "Check by the street"; 
                    break;

                case 4:
                    outputLable.Text = "Ask the witness what she saw. She tells you that she hears the gun shot to see a guy mugging" +
                        " Elliot and then running away, she didn't get his face but she knows it's a white man about 6 foot" +
                        " and he was wearing a black hoodie with his hood up" +
                        " and baggy jeans You write down The information she gave you and go to Investigate. What do you do?  Press any button to continue ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = ""; 
                    break;
                case 5:
                    outputLable.Text = "You see a dry pool of blood you tell forensics to get DNA from it." +
                        " The next day you find out the who the killer is. What now? ";
                    redLabel.Text = "Let the FBI bring him in ";
                    blueLabel.Text = "bring him in yourself";
                    yellowLabel.Text = "";
                    break;
                case 6:
                    outputLable.Text = "You see a gun and give it to forensics to get finger prints Press any key to continue ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 7:
                    outputLable.Text = "The FBI bring him in and he confesses you win press any key to continue you ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 8:
                    outputLable.Text = "He confesses to you and lets you bring him in, you are known as a hero you win " +
                        "Press any key to continue ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 9:
                    outputLable.Text = "You go home and gave up, you lose ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 10:
                    outputLable.Text = "A dealer sees you and stabs you, you die from your injuries ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 99:
                    outputLable.Text = "Play again?";
                    redLabel.Text = "YES";
                    blueLabel.Text = "NO";
                    yellowLabel.Text = "";
                    break;


            }
            
        }
    }
}
