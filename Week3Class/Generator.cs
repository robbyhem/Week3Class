using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Week3Class
{
    public abstract class Generator
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        
        public bool HasPowerSource { get; set; }
        public bool IsRunning { get; set; }
        public virtual bool Start()
        {
            //if it has a powersource but has not started
            if (HasPowerSource && !IsRunning)
            {
                //start generator
                IsRunning = true;
                //return that you have started it
                return true;
            }
            else
                return false;
        }

        public abstract bool Stop();
        
    }
}
