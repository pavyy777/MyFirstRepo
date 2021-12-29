using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1test
{
    class Player
    {

        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
    }
    class PlayerImplementation
    {
        public int Average(IList<Player> players)
        {
            int count = 0;
            int avg = 0;
            int sum = 0;
            foreach (var item in players)
            {
                avg = avg + item.Score;
                count++;

            }
            avg = sum / count;
            //var result = players.Average(p => p.Score);
            return avg;
        }
        public int Max(IList<Player> players)
        {
            
            foreach (var item in players)
            {
                Max=sort
                //players.Max<item.Score>();
               // var Max = item.Score;
                return int.MaxValue;
            }
            // var result = players.Max(p => p.Score);

            public int Min(IList<Player> players)
            {
                var result = players.Min(p => p.Score);
                return result;

            }
        }

 }  }

