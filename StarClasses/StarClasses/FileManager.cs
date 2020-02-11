using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StarClasses
{
    static class FileManager
    {

        public static List<Star> LoadStarFile(string filePath)
        {

 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File doesn't exist, check file path and file name");
                return null;
            }

            var rawDataLine = File.ReadAllLines(filePath);

            var stars = new List<Star>();
            StarDataMapper(rawDataLine, stars);

            return stars;
        }


        private static void StarDataMapper(string[] rawDataLine, List<Star> stars)
        {
            foreach (string item in rawDataLine)
            {
                var parts = item.Split('|');

                var star = new Star();

                star.Name = parts[0];
                star.Mass = double.Parse(parts[1]);
                star.Temperature = int.Parse(parts[2]);
                star.SpectralClass = (SpectralClass)Enum.Parse(typeof(SpectralClass), parts[3]);

                stars.Add(star);
            }
        }


        public static void WriteStarClassFile()
        {

        }



    }
}
