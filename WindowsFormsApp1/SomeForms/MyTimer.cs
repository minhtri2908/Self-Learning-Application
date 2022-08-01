using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.SomeForms
{
    class MyTimer
    {
        public MyTimer(int h, int m, int s)
        {
            H = h;
            M = m;
            S = s;
        }
        public int H { get; set; }
        public int M { get; set; }
        public int S { get; set; }
        //public int S = 60;
        public string timeToString()
        {
            return string.Format("{0}:{1}:{2}", H, M, S);
        }
        public void timeUp()
        {
            if (H >= 0)
            {
                if (S < 59)
                {
                    S += 1;
                }
                else if (S >= 59)
                {
                    if (M < 59)
                    {
                        M += 1;
                        S = 0;
                    }
                    else if (M>=59 )
                    {
                        H += 1;
                        M = 0;
                        S = 0;
                    }
                }
            }
        }
        public void timeDown()
        {
            if (H > 0)
            {
                if (S > 0)
                {
                    S -= 1;
                }
                else if (S <= 0)
                {
                    if (M > 0)
                    {
                        M -= 1;
                        S = 59;
                    }
                    else if (M <= 0)
                    {
                        H -= 1;
                        M = 59;
                        S = 59;
                    }
                }
            }
            else if (H <= 0)
            {
                if ( S > 0 )
                {
                    S -= 1;
                }
                else if (S <= 0)
                {
                    if (M > 0)
                    {
                        M -= 1;
                        S = 59;
                    }
                    else if (M <= 0)
                    {
                        H = 0;
                        M = 0;
                        S = 0;
                        return; 
                    }
                }
            }
        }
    }
}
