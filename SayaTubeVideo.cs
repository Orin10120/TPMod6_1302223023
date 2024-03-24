using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul6_1302223023
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

       public SayaTubeVideo(String title)
        {
            this.title = title;
            this.id = randomID();
            this.playCount = 0;
        }

        private int randomID() { 
            Random acak = new Random();
            return 10000 + acak.Next(90000);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = playCount;
            this.playCount++;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Total PlayCount: " + playCount);
        }
    }
}
