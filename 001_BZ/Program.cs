using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dungeons = { { 80, 20 }, { 50, 40 }, { 30, 10 } };

            List<int> listDungeons = new List<int>();

            
            foreach (var data in dungeons)
                listDungeons.Add(data);


            for(int idx = 0; idx < listDungeons.Count; idx++)
            {

            }

            

        }
    }
}
