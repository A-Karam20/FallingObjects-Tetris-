using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FallingObjects
{
    public static class Colors
    {
        /*public static List<Color> GetColors() //Form a list of given colors
        {
            List<Color> colors = new List<Color>()
            {
                Color.Green,
                Color.Red,
                Color.Yellow,
                Color.Orange,
                Color.Orchid,
                Color.Purple,
                Color.Pink,
                Color.Plum,
                Color.AliceBlue
            };

            return colors;              
        }*/

        public static Color GetRandomColor() //Gets a random color
        {
            Random r = new Random();
            return Color.FromArgb(r.Next(0,256), r.Next(0,256), r.Next(0,256));
        }
    }
}
