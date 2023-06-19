using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingObjects
{
    public static class Methods
    {
        public static void ReadScore(string file)
        {
            try
            {
                string? line;
                using(StreamReader sr = new StreamReader(file))
                {
                    while((line = sr.ReadLine()) != null)
                    {
                        CreateGame.High_Score = Convert.ToInt32(line);
                    }
                }
            }
            catch(Exception)
            {
                //Nothing to do here :)
            }
        }

        public static void SaveScore(string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(CreateGame.High_Score);
            }
        }
    }
}
