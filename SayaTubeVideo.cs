using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title != null || title.Length <= 100);
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
            Debug.Assert(playCount <= 10000000);
            try
            {
                checked
                {
                    this.playCount = playCount;
                    this.playCount++;
                }
            }catch (OverflowException)
            {
                Console.WriteLine("Jumlah penambahan play count melebihi batas tertinggi integer (overflow).");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Total PlayCount: " + playCount);
        }
    }
}
