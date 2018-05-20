using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typeing_Game
{
    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            if(correctKey == true)
            {
                Total++;
                Correct++;
                
                Accuracy = (int)((Correct / (double)Total) * 100);
            }
            else
            {
                Total++;
                Missed++;
                Accuracy = (int)((Correct / (double)Total) * 100);
            }

        }
    }
}
