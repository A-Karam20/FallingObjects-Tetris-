using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjects
{
    public partial class Game : Form
    {
        public CreateGame game;

        public System.Windows.Forms.Timer timer;

        public Control control;

        Random r = new Random();
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e) //Create the given objects and events after that the form and it's components have been loaded properly
        {
            score_.Enabled = false; //disable this text so that the user can't interact with it AND the form does not lose focus, but the user can still see the text
            Score.Enabled = false;
            highscore_.Enabled = false;
            HighScore.Enabled = false;
            NextShape.Enabled = false;

            Methods.ReadScore("Score.txt");
            HighScore.Text = CreateGame.High_Score.ToString();

            game = new CreateGame(20, 10);

            InsertLabel();

            InsertSmallLabel();

            timer = new System.Windows.Forms.Timer(); //Create an instance of the class Timer
            timer.Interval = 500; //Set the interval between each tick
            timer.Tick += Timer_Object; //Subscribe to the given event so everytime it ticks the Timer_Object function is called
            timer.Start(); //Start the timer

            this.KeyDown += GetKey;//Subscribe to the given event so everytime the user presses a key, the GetKey function is called
        }

        private void Timer_Object(object? sender, EventArgs e) //This function is considered as an event handler
        {
            if (Check_Collision())
            {
                RemoveColor();
                for (int i = 0; i < game.current_shape.Position.Count; i++)
                {
                    game.current_shape.Position[i][0]++;
                }
            }
            else
            {
                UpdateTable();
                UpdateScore();
                if (!GameOver())
                {
                    game.current_shape = game.next_shape;
                    game.next_shape = new CreateShape();
                    ShowNextShape();
                }
                else
                {
                    timer.Tick -= Timer_Object;
                    timer.Stop();
                    this.KeyDown -= GetKey;
                    Over.Visible = true;
                    PlayAgain.Visible = true;
                }
            }
            UpdateVisual();
        }

        private void GetKey(object? sender, KeyEventArgs e)//This function is also considered as an event handler
        {
            switch (e.KeyCode) //Switch that takes the pressed key as argument
            {
                case Keys.Down: //down arrow
                    if (Check_Collision()) //If there is no collision, it enters the if statement
                    {
                        RemoveColor();
                        for (int i = 0; i < game.current_shape.Position.Count; i++) //Gets the object to it's new position, down by one
                        {
                            game.current_shape.Position[i][0]++;
                        }
                    }
                    else
                    {
                        UpdateTable();
                        UpdateScore();
                        if (!GameOver()) //if the game is not over yet keep on creating a new object
                        {
                            game.current_shape = game.next_shape;
                            game.next_shape = new CreateShape();
                            ShowNextShape();
                        }
                        else
                        {
                            timer.Tick -= Timer_Object; //this function will be no longer called
                            timer.Stop(); //the timer stops, so it stops ticking
                            this.KeyDown -= GetKey; //this function will be no longer called
                            Over.Visible = true;
                            PlayAgain.Visible = true;
                        }
                    }
                    break;
                case Keys.Left: //left arrow
                    if (Check_Left())
                    {
                        RemoveColor();
                        for (int i = 0; i < game.current_shape.Position.Count; i++) //Gets the object to it's new position, to the left by one
                        {
                            game.current_shape.Position[i][1]--;
                        }
                    }
                    break;
                case Keys.Right: //right arrow
                    if (Check_Right())
                    {
                        RemoveColor();
                        for (int i = 0; i < game.current_shape.Position.Count; i++) //Gets the object to it's new position, to the right by one
                        {
                            game.current_shape.Position[i][1]++;
                        }
                    }
                    break;
            }
            UpdateVisual();
        }

        public bool Check_Collision() //Checks if the object can get down by one row
        {
            try
            {
                for (int i = 0; i < game.current_shape.Position.Count; i++)
                {
                    if (game.Table[game.current_shape.Position[i][0] + 1, game.current_shape.Position[i][1]] == 1) //if an object already occupy the position
                    {
                        return false;
                    }
                }

                return true; //if everything is clear and the index is in range
            }
            catch (Exception) //If index was out of range
            {
                return false;
            }
        }
        public bool Check_Left() //Checks if the object can get to the left by one column
        {
            try
            {
                for (int i = 0; i < game.current_shape.Position.Count; i++)
                {
                    if (game.Table[game.current_shape.Position[i][0], game.current_shape.Position[i][1] - 1] == 1)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Check_Right() //Checks if the object can get to the right by one column
        {
            try
            {
                for (int i = 0; i < game.current_shape.Position.Count; i++)
                {
                    if (game.Table[game.current_shape.Position[i][0], game.current_shape.Position[i][1] + 1] == 1)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void UpdateVisual() //Changes the color of some rows and columns to form the specified shape
        {
            for (int i = 0; i < game.current_shape.Position.Count; i++)
            {
                Box.GetControlFromPosition(row: game.current_shape.Position[i][0], column: game.current_shape.Position[i][1]).BackColor = game.ChangeBoxColor();
            }
        }

        public void RemoveColor() //Remove the color of some rows and columns to remove the specified shape
        {
            for (int i = 0; i < game.current_shape.Position.Count; i++)
            {
                Box.GetControlFromPosition(row: game.current_shape.Position[i][0], column: game.current_shape.Position[i][1]).BackColor = Color.White;
            }
        }

        public void UpdateTable() //Update the table to state that a new object is occupying some rows and columns
        {
            for (int i = 0; i < game.current_shape.Position.Count; i++)
            {
                for (int j = 0; j < game.current_shape.Position[i].Length; j++)
                {
                    game.Table[game.current_shape.Position[i][0], game.current_shape.Position[i][1]] = 1;
                }
            }
        }

        public void UpdateScore() //Update the score of the player and also everytime a row has all column full, the row will "disappear" and all of the above rows will "get down" by one
        {
            for (int i = 0; i < game.Table.GetLength(0); i++)
            {
                if (game.CheckRow(i))
                {
                    game.Score += r.Next(1000, 2001);
                    Score.Text = game.Score.ToString();
                    if(game.Score>CreateGame.High_Score)
                    {
                        CreateGame.High_Score = game.Score;
                        Methods.SaveScore("Score.txt");
                        HighScore.Text = CreateGame.High_Score.ToString();
                    }
                    for (int j = i; j >= 1; j--)
                    {
                        for (int k = 0; k < game.Table.GetLength(1); k++)
                        {
                            game.Table[j, k] = game.Table[j - 1, k];
                            control = Box.GetControlFromPosition(row: j, column: k);
                            control.BackColor = Box.GetControlFromPosition(row: j - 1, column: k).BackColor;
                        }
                    }
                }
            }
        }

        public void InsertLabel() //Add a label to each cell in the tablelayout, aka "box"
        {
            Label label;
            for (int i = 0; i < game.Table.GetLength(0); i++)
            {
                for (int j = 0; j < game.Table.GetLength(1); j++)
                {
                    label = new Label();
                    label.BackColor = Color.White;
                    Box.Controls.Add(label, row: i, column: j);
                }
            }
        }

        public bool GameOver() //When we can no longer create a new object because the given rows of a specified column are taken
        {
            if (game.Table[game.next_shape.lowest_point, 5] == 1)
            {
                return true;
            }

            return false;
        }

        private void PlayAgain_Click(object sender, EventArgs e) //When the user wants to play again it closes this form and creates a new one
        {
            this.Close();
            Game new_game = new Game();
            new_game.Show();

        }

        public void InsertSmallLabel() //Add a label to each cell in the small tablelayout, aka "Nextbox"
        {
            Label label;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    label = new Label();
                    label.BackColor = Color.Moccasin;
                    NextBox.Controls.Add(label, row: i, column: j);
                }
            }
        }

        public void ShowNextShape() //Shows the next shape to the user on a small tablelayout, aka "NextBox"
        {
            for (int i = 0; i < NextBox.RowCount; i++)
            {
                for (int j = 0; j < NextBox.ColumnCount; j++)
                {
                    NextBox.GetControlFromPosition(row: i, column: j).BackColor = Color.Moccasin;
                }
            }
            switch (game.next_shape.Shape_ID)
            {
                case 0:
                    for (int i = 0; i < 4; i++)
                    {
                        NextBox.GetControlFromPosition(row: i, column: 1).BackColor = game.next_shape.Shape_Color;
                    }
                    break;
                case 1:
                    NextBox.GetControlFromPosition(row: 1, column: 1).BackColor = game.next_shape.Shape_Color;
                    NextBox.GetControlFromPosition(row: 1, column: 2).BackColor = game.next_shape.Shape_Color;
                    NextBox.GetControlFromPosition(row: 2, column: 1).BackColor = game.next_shape.Shape_Color;
                    NextBox.GetControlFromPosition(row: 2, column: 2).BackColor = game.next_shape.Shape_Color;
                    break;
                case 2:
                    for (int i = 0; i < 3; i++)
                    {
                        NextBox.GetControlFromPosition(row: i, column: 1).BackColor = game.next_shape.Shape_Color;
                    }
                    NextBox.GetControlFromPosition(row: 2, column: 2).BackColor = game.next_shape.Shape_Color;
                    break;
                case 3:
                    NextBox.GetControlFromPosition(row: 0, column: 1).BackColor = game.next_shape.Shape_Color;
                    NextBox.GetControlFromPosition(row: 1, column: 1).BackColor = game.next_shape.Shape_Color;
                    NextBox.GetControlFromPosition(row: 1, column: 0).BackColor = game.next_shape.Shape_Color;
                    NextBox.GetControlFromPosition(row: 1, column: 2).BackColor = game.next_shape.Shape_Color;
                    break;
            }
        }
    }
}
