using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingObjects
{
    public class CreateGame
    {
        public int[,] Table; //2D table to check if an object already holds the position
        public CreateShape current_shape = new CreateShape();//current shape - the user is playing with
        public CreateShape next_shape = new CreateShape();//The next shape - the user will be playing with

        public int Score;//User score
        public static int High_Score;
        public CreateGame(int rows, int column)
        {
            Table = new int[rows, column];
        }

        public bool CheckRow(int row)//Check the given row if its holding an object and return false if one column in this row is empty
        {
            for(int i=0; i<Table.GetLength(1); i++)
            {
                if (Table[row, i] == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public Color ChangeBoxColor()//Change the color of the box by taking the current shape color
        {
            Color Box_Color;
            Box_Color = current_shape.Shape_Color;
            return Box_Color;
        }
    }
}
