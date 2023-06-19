using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingObjects
{
    public class CreateShape
    {
        public static int rows = 20;
        public static int columns = 10;

        public List<int[]> Position = new List<int[]>();
        public int[] coordinates = new int[2];

        public static int size = 4;

        public int lowest_point; //lowest point the current object can get at the moment

        public Color Shape_Color;

        private static List<int> Shapes = new List<int>() { 0, 1, 2, 3 };

        public int Shape_ID; //It's used to check which shape is in play
        public CreateShape()
        {
            GetRandomShape();
        }

        private void Aamoud() //Create aamoud kahraba or any type of aamoud
        {
            coordinates[1] = columns / 2;
            coordinates[0] = 0;
            for(int i=0; i<size; i++)
            {
                this.Position.Add(coordinates); //Adds a reference to the coordinates
                coordinates = new int[2]; //MUST PUT THIS TO CREATE A NEW REFERENCE OR ALL COORDINATES IN POSITION WILL CHANGE
                coordinates[1] = columns / 2;
                coordinates[0] = i + 1;
            }
            this.Shape_Color = Color.Blue;

            this.lowest_point = 3;

            this.Shape_ID = 0;
        }

        private void Square() //Square shape
        {
            coordinates = new int[2];
            coordinates[0] = 0;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 0;
            coordinates[1] = 6;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 1;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 1;
            coordinates[1] = 6;
            Position.Add(coordinates);

            this.Shape_Color = Color.Red;

            this.lowest_point = 1;

            this.Shape_ID = 1;
        }

        private void L() //L shape
        {
            coordinates = new int[2];
            coordinates[0] = 0;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 1;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 2;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 2;
            coordinates[1] = 6;
            Position.Add(coordinates);

            this.Shape_Color = Color.Purple;

            this.lowest_point = 2;

            this.Shape_ID = 2;
        }

        private void T() //T shape
        {
            coordinates = new int[2];
            coordinates[0] = 0;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 1;
            coordinates[1] = 5;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 1;
            coordinates[1] = 4;
            Position.Add(coordinates);

            coordinates = new int[2];
            coordinates[0] = 1;
            coordinates[1] = 6;
            Position.Add(coordinates);

            this.Shape_Color = Color.Black;

            this.lowest_point = 1;

            this.Shape_ID = 3;
        }

        private void GetRandomShape()//Get a random shape that is different from the one before
        {
            Random r = new Random();
            if(Shapes.Count<=0)
            {
                Shapes = new List<int>() { 0, 1, 2, 3 };
            }

            int random_shape = Shapes[r.Next(0, Shapes.Count)];
            switch (random_shape)
            {
                case 0:
                    Aamoud();
                    break;
                case 1:
                    Square();
                    break;
                case 2:
                    L();
                    break;
                case 3:
                    T();
                    break;
            }
            Shapes.Remove(random_shape);
        }
    }
}
