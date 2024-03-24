using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul6_1302223023
{
    
     public class Program
    {
        static void Main(string[] args)
        {
            String title = "Tutorial Design By Contract - Rindang Bani Isyan";
            SayaTubeVideo vid = new SayaTubeVideo(title);
            vid.IncreasePlayCount(3);
            vid.printVideoDetails();
        }
    }
}
