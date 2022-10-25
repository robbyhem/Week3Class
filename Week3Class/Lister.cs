using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Class
{
    public class Lister : Generator
    {
        public bool HasStarterEaten { get; set; }
        public override bool Start()
        {
            if (HasStarterEaten)
                return base.Start();
            else
                return false;
        }

        public override bool Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        //public override bool start();
    }
}
