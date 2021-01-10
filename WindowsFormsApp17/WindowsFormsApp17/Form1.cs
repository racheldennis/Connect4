/*Rachel Dennis, Agnes Barkho, Dania Nadeem, and Daniyal Mohammed
*/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {

        static PictureBox[,] row1 = new PictureBox[6, 7];//creates a PictureBox 2D Double array called row allows the board to be size 6 by 7
        static int[,] r1 = new int[6, 7];//creates a 2D Double Array for the columns and rows
        static int turn = 1;//creates a int variable turn to represents which player's turn
        static int red = 0;//creates a int variable red to represents the player who plays red
        static int yellow = 0;//creates a int variable yellow to represents the player who plays yellow
        static int rounds = 0;//creates a int variable rounds to represents number of rounds played in the game
        Bitmap Clear = Properties.Resources.Clear;//creates a bitmap variable Clear that takes the Clear image found in resources and lets the variable equal the picture
        Bitmap Red = Properties.Resources.Red;//creates a bitmap variable Red that takes the Red image found in resources and lets the variable equal the picture
        Bitmap Yellow = Properties.Resources.Yellow;//creates a bitmap variable Yellow that takes the Yellow image found in resources and lets the variable equal the picture

        public Form1()
        {
            InitializeComponent();

            button2.Visible = false;//Lets the button Visibility equal false which means that button cannot be seen
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            textBox1.Visible = false;//Lets the textBox1 Visibility equal false which means that the textBox1 cannot be seen
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            row1[0, 0] = pictureBox1;//Lets the following position in the array row1 equal the following pictureBox
            row1[1, 0] = pictureBox2;
            row1[2, 0] = pictureBox3;
            row1[3, 0] = pictureBox4;
            row1[4, 0] = pictureBox5;
            row1[5, 0] = pictureBox6;

            row1[0, 1] = pictureBox12;
            row1[1, 1] = pictureBox11;
            row1[2, 1] = pictureBox10;
            row1[3, 1] = pictureBox9;
            row1[4, 1] = pictureBox8;
            row1[5, 1] = pictureBox7;

            row1[0, 2] = pictureBox18;
            row1[1, 2] = pictureBox17;
            row1[2, 2] = pictureBox16;
            row1[3, 2] = pictureBox15;
            row1[4, 2] = pictureBox14;
            row1[5, 2] = pictureBox13;

            row1[0, 3] = pictureBox24;
            row1[1, 3] = pictureBox23;
            row1[2, 3] = pictureBox22;
            row1[3, 3] = pictureBox21;
            row1[4, 3] = pictureBox20;
            row1[5, 3] = pictureBox19;

            row1[0, 4] = pictureBox30;
            row1[1, 4] = pictureBox29;
            row1[2, 4] = pictureBox28;
            row1[3, 4] = pictureBox27;
            row1[4, 4] = pictureBox26;
            row1[5, 4] = pictureBox25;

            row1[0, 5] = pictureBox36;
            row1[1, 5] = pictureBox35;
            row1[2, 5] = pictureBox34;
            row1[3, 5] = pictureBox33;
            row1[4, 5] = pictureBox32;
            row1[5, 5] = pictureBox31;

            row1[0, 6] = pictureBox42;
            row1[1, 6] = pictureBox41;
            row1[2, 6] = pictureBox40;
            row1[3, 6] = pictureBox39;
            row1[4, 6] = pictureBox38;
            row1[5, 6] = pictureBox37;



            for (int i = 0; i < 6; i++)//This is a nested for loop which represents the rows and columns (this specific for loop represents a each whole row)
            {
                for (int col = 0; col < 7; col++)//This for loop specific represents the columns from 1-7
                {
                    r1[i, col] = 0;//This is a 2D Double array for the board and lets all positions equal 0


                }

            }
        }

        private void play_a_piece(int col)//creates a function to let the user click any of the top buttons and have the desired position filled in the column that the button is located
        {

            for (int i = 5; i >= 0; i--)//creates a for loop of the top buttons that control the positions being filled in each column
            {

                if (r1[i, col] == 0)//If the 2D Double array for the board and lets all positions equal 0
                {
                    if (turn == 1)//if the variable turn equals 1
                    {

                        row1[i, col].Image = Red;//the specific picturebox at the position will change to the image Red
                        r1[i, col] = 1;//The specific position in the 2D Double array will change form 0 to 1
                    }
                    else//if the variable turn does not equal 1
                    {
                        row1[i, col].Image = Yellow;//the specific picturebox at the position will change to the image Yellow
                        r1[i, col] = 2;//The specific position in the 2D Double array will change form 0 to 2
                    }


                    i = -1;//the variable i in the for loop will change to -1

                    if (turn == 1)//if the variable turn equals 1
                    {
                        turn = 2;//the variable turn will equal 2

                    }
                    else
                    {
                        turn = 1;//the variable turn will equal 1
                    }
                }
            }
        }

        private void check_winner(int[,] board)//creates a check_winner function that finds which player wins with the following combinations in the function
        {

            for (int row = 0; row < 6; row++)//Creates a nested loop to check for the winner horizontally (this specific part is a for loop for any whole row)
            {
                for (int col = 0; col < 4; col++)//this for loop equals any 4 columns that have 4 positions filled in the same row
                {

                    if (board[row, col] == 1 && board[row, col] == board[row, col + 1] && board[row, col] == board[row, col + 2] && board[row, col] == board[row, col + 3])//when the turn is red and 4 spots in a row make a connect 4
                    {

                        red++;//this will lets the variable red increase by 1 every time the if statement is true
                        Winner();//when the if statement is true this will let what is contained in the Winner function to be true;



                    }
                    if (board[row, col] == 2 && board[row, col] == board[row, col + 1] && board[row, col] == board[row, col + 2] && board[row, col] == board[row, col + 3])//when the turn is yellow and 4 spots in a row make a connect 4
                    {
                        yellow++;//this will lets the variable yellow increase by 1 every time the if statement is true
                        textBox1.ForeColor = Color.Yellow;//this will change the font colour of the word "WINNER" in textBox1 from Red to Yellow

                        Winner();

                    }
                }

            }
            
            for (int col = 0; col < 7; col++)//creates a nested loop to check the winner vertically (this specific part is a for loop for any column)
            {
                for (int row = 0; row < 3; row++)//this for loop equals any 4 rows that have 4 positions filled in the same column
                {
                    if (board[row, col] == 1 && board[row, col] == board[row + 1, col] && board[row, col] == board[row + 2, col] && board[row, col] == board[row + 3, col])//when the turn is red and 4 spots in a column make a connect 4
                    {
                        red++;

                        Winner();



                    }
                    if (board[row, col] == 2 && board[row, col] == board[row + 1, col] && board[row, col] == board[row + 2, col] && board[row, col] == board[row + 3, col])//when the turn is yellow and 4 spots in a column make a connect 4
                    {
                        yellow++;

                        Winner();

                    }
                }
            }

            if (board[3, 0] == 1 && board[3, 0] == board[2, 1] && board[3, 0] == board[1, 2] && board[3, 0] == board[0, 3])//when the turn is red and 4 positions are filled diagonally and make a connect 4
            {
               red++;        

                 Winner();
            }
            else if (board[4, 0] == 1 && board[4, 0] == board[3, 1] && board[4, 0] == board[2, 2] && board[4, 0] == board[1, 3])
            {
                red++;

               Winner();
            }
            else if (board[5, 0] == 1 && board[5, 0] == board[4, 1] && board[5, 0] == board[3, 2] && board[5, 0] == board[2, 3])
            {
               red++;

               Winner();
            }

            else if (board[3, 1] == 1 && board[3, 1] == board[2, 2] && board[3, 1] == board[1, 3] && board[3, 1] == board[0, 4])
            {
               red++;

              Winner();
            }
            else if (board[4, 1] == 1 && board[4, 1] == board[3, 2] && board[4, 1] == board[2, 3] && board[4, 1] == board[1, 4])
            {
                red++;
              Winner();
            }
            else if (board[5, 1] == 1 && board[5, 1] == board[4, 2] && board[5, 1] == board[3, 3] && board[5, 1] == board[2, 4])
            {
               red++;
                Winner();
            }

            else if (board[3, 2] == 1 && board[3, 2] == board[2, 3] && board[3, 2] == board[1, 4] && board[3, 2] == board[0, 5])
            {
               red++;
               Winner();
            }
            else if (board[4, 2] == 1 && board[4, 2] == board[3, 3] && board[4, 2] == board[2, 4] && board[4, 2] == board[1, 5])
            {
               red++;

              Winner();
            }
            else if (board[5, 2] == 1 && board[5, 2] == board[4, 3] && board[5, 2] == board[3, 4] && board[5, 2] == board[2, 5])
            {
               red++;

               Winner();
            }

            else if (board[3, 3] == 1 && board[3, 3] == board[2, 4] && board[3, 3] == board[1, 5] && board[3, 3] == board[0, 6])
            {
               red++;

              Winner();
            }
            else if (board[4, 3] == 1 && board[4, 3] == board[3, 4] && board[4, 3] == board[2, 5] && board[4, 3] == board[1, 6])
            {
               red++;

                Winner();
            }
            else if (board[5, 3] == 1 && board[5, 3] == board[4, 4] && board[5, 3] == board[3, 5] && board[5, 3] == board[2, 6])
            {
                red++;

               Winner();
            }

            if (board[3, 6] == 1 && board[3, 6] == board[2, 5] && board[3, 6] == board[1, 4] && board[3, 6] == board[0, 3])
            {
                red++;

                Winner();
            }
            else if (board[4, 6] == 1 && board[4, 6] == board[3, 5] && board[4, 6] == board[2, 4] && board[4, 6] == board[1, 3])
            {
                red++;

                Winner();
            }
            else if (board[5, 6] == 1 && board[5, 6] == board[4, 5] && board[5, 6] == board[3, 4] && board[5, 6] == board[2, 3])
            {
                red++;

                Winner();
            }

            else if (board[3, 5] == 1 && board[3, 5] == board[2, 4] && board[3, 5] == board[1, 3] && board[3, 5] == board[0, 2])
            {
                red++;

                Winner();
            }
            else if (board[4, 5] == 1 && board[4, 5] == board[3, 4] && board[4, 5] == board[2, 3] && board[4, 5] == board[1, 2])
            {
                red++;

                Winner();
            }
            else if (board[5, 5] == 1 && board[5, 5] == board[4, 4] && board[5, 5] == board[3, 3] && board[5, 5] == board[2, 2])
            {
                red++;

                Winner();
            }

            else if(board[3, 4] == 1 && board[3, 4] == board[2, 3] && board[3, 4] == board[1, 2] && board[3, 4] == board[0, 1])
            {
                red++;

                Winner();
            }
            else if (board[4, 4] == 1 && board[4, 4] == board[3, 3] && board[4, 4] == board[2, 2] && board[4, 4] == board[1, 1])
            {
                red++;

                Winner();
            }
            else if (board[5, 4] == 1 && board[5, 4] == board[4, 3] && board[5, 4] == board[3, 2] && board[5, 4] == board[2, 1])
            {
                red++;

                Winner();
            }

            else if (board[3, 3] == 1 && board[3, 3] == board[2, 2] && board[3, 3] == board[1, 1] && board[3, 3] == board[0, 0])
            {
                red++;

                Winner();
            }
            else if (board[4, 3] == 1 && board[4, 3] == board[3, 2] && board[4, 3] == board[2, 1] && board[4, 3] == board[1, 0])
            {
                red++;

                Winner();
            }
            else if (board[5, 3] == 1 && board[5, 3] == board[4, 2] && board[5, 3] == board[3, 1] && board[5, 3] == board[2, 0])
            {
                red++;

                Winner();
            }


            if (board[3, 0] == 2 && board[3, 0] == board[2, 1] && board[3, 0] == board[1, 2] && board[3, 0] == board[0, 3])//when the turn is yellow and 4 positions are filled diagonally and make a connect 4
            {
                yellow++;

                Winner();
            }
            else if (board[4, 0] == 2 && board[4, 0] == board[3, 1] && board[4, 0] == board[2, 2] && board[4, 0] == board[1, 3])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 0] == 2 && board[5, 0] == board[4, 1] && board[5, 0] == board[3, 2] && board[5, 0] == board[2, 3])
            {
                yellow++;

                Winner();
            }

            else if (board[3, 1] == 2 && board[3, 1] == board[2, 2] && board[3, 1] == board[1, 3] && board[3, 1] == board[0, 4])
            {
                yellow++;

                Winner();
            }
            else if (board[4, 1] == 2 && board[4, 1] == board[3, 2] && board[4, 1] == board[2, 3] && board[4, 1] == board[1, 4])
            {
                yellow++;
                Winner();
            }
            else if (board[5, 1] == 2 && board[5, 1] == board[4, 2] && board[5, 1] == board[3, 3] && board[5, 1] == board[2, 4])
            {
                yellow++;
                Winner();
            }

            else if (board[3, 2] == 2 && board[3, 2] == board[2, 3] && board[3, 2] == board[1, 4] && board[3, 2] == board[0, 5])
            {
                yellow++;
                Winner();
            }
            else if (board[4, 2] == 2 && board[4, 2] == board[3, 3] && board[4, 2] == board[2, 4] && board[4, 2] == board[1, 5])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 2] == 2 && board[5, 2] == board[4, 3] && board[5, 2] == board[3, 4] && board[5, 2] == board[2, 5])
            {
                yellow++;

                Winner();
            }

            else if (board[3, 3] == 2 && board[3, 3] == board[2, 4] && board[3, 3] == board[1, 5] && board[3, 3] == board[0, 6])
            {
                yellow++;

                Winner();
            }
            else if (board[4, 3] == 2 && board[4, 3] == board[3, 4] && board[4, 3] == board[2, 5] && board[4, 3] == board[1, 6])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 3] == 2 && board[5, 3] == board[4, 4] && board[5, 3] == board[3, 5] && board[5, 3] == board[2, 6])
            {
                yellow++;

                Winner();
            }

            if (board[3, 6] == 2 && board[3, 6] == board[2, 5] && board[3, 6] == board[1, 4] && board[3, 6] == board[0, 3])
            {
                yellow++;

                Winner();
            }
            else if (board[4, 6] == 2 && board[4, 6] == board[3, 5] && board[4, 6] == board[2, 4] && board[4, 6] == board[1, 3])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 6] == 2 && board[5, 6] == board[4, 5] && board[5, 6] == board[3, 4] && board[5, 6] == board[2, 3])
            {
                yellow++;

                Winner();
            }

            else if (board[3, 5] == 2 && board[3, 5] == board[2, 4] && board[3, 5] == board[1, 3] && board[3, 5] == board[0, 2])
            {
                yellow++;

                Winner();
            }
            else if (board[4, 5] == 2 && board[4, 5] == board[3, 4] && board[4, 5] == board[2, 3] && board[4, 5] == board[1, 2])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 5] == 2 && board[5, 5] == board[4, 4] && board[5, 5] == board[3, 3] && board[5, 5] == board[2, 2])
            {
                yellow++;

                Winner();
            }

            else if (board[3, 4] == 2 && board[3, 4] == board[2, 3] && board[3, 4] == board[1, 2] && board[3, 4] == board[0, 1])
            {
                yellow++;

                Winner();
            }
            else if (board[4, 4] == 2 && board[4, 4] == board[3, 3] && board[4, 4] == board[2, 2] && board[4, 4] == board[1, 1])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 4] == 2 && board[5, 4] == board[4, 3] && board[5, 4] == board[3, 2] && board[5, 4] == board[2, 1])
            {
                yellow++;

                Winner();
            }

            else if (board[3, 3] == 2 && board[3, 3] == board[2, 2] && board[3, 3] == board[1, 1] && board[3, 3] == board[0, 0])
            {
                yellow++;

                Winner();
            }
            else if (board[4, 3] == 2 && board[4, 3] == board[3, 2] && board[4, 3] == board[2, 1] && board[4, 3] == board[1, 0])
            {
                yellow++;

                Winner();
            }
            else if (board[5, 3] == 2 && board[5, 3] == board[4, 2] && board[5, 3] == board[3, 1] && board[5, 3] == board[2, 0])
            {
                yellow++;

                Winner();
            }



        }

        private void Winner()//This creates a Winner function that contains the following code which will be true when a player wins
        {

            rounds++;//this will let the variable rounds increase by 1 every time the Winner function is used
            textBox1.Visible = true;//this lets the textBox1 Visibility be true which means that the textBox1 will be seen in the form
            button2.Visible = false;//this lets the following button Visibility be false which means that the button will not be seen in the form
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button1.Visible = true;
            button9.Visible = true;
            label1.Text = "Red Won " + red + " Time(s)";//This lets label 1 print how many times the player who plays red wins
            label2.Text = "Yellow Won " + yellow + " Time(s)";//This lets label 2 print how many times the player who plays yellow wins
            label3.Text = rounds + " Round(s) occured";//This label 3 print how many times rounds occured in the game

        }
    

    

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Play Again";//After Clicking button1 the text in Button1 will change form "Start" to "PLay Again"
            button1.Visible = false;//this lets the following button visibility be false which means that button1 will not be seen in the form
            button2.Visible = true;//this lets the following button visibility be true which means that button1 will be seen in the form
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = false;


            if (button1.Text == "Play Again")//If the Button1 text equals "Play Again"
            {
                label1.Text = "";//The label Text will be cleared
                label2.Text = "";
                label3.Text = "";
                turn = 1;//The variable turn will equal 1
                textBox1.Visible = false;//the textBox1 visibility will be false which means textBox1 will not be seen in the form
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                for (int i = 0; i < 6; i++)
                {
                    for (int col = 0; col < 7; col++)
                    {
                        row1[i, col].Image = Clear;//All of the positions in the array will change its current image to the variable Bitmap Clear
                        r1[i, col] = 0;
                        
                    }

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            play_a_piece(0);//this means that the specific number that is going in the play_a_piece function will let the user click any of the top buttons and will correctly fill the spot in the specific column
            check_winner(r1);//this lets the user know if a player one any time they click the button
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            play_a_piece(1);
            check_winner(r1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            play_a_piece(2);
            check_winner(r1);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            play_a_piece(3);
            check_winner(r1);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            play_a_piece(4);
            check_winner(r1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            play_a_piece(5);
            check_winner(r1);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            play_a_piece(6);
            check_winner(r1);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";//same coding found in button1 
            label2.Text = "";
            label3.Text = "";
            red = 0;
            yellow = 0;
            rounds = 0;
            turn = 1;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = false;



            for (int i = 0; i < 6; i++)
            {
                for (int col = 0; col < 7; col++)
                {
                   row1[i, col].Image = Clear;
                    r1[i, col] = 0;
                    
                }



            }
            
        }
    }
}
