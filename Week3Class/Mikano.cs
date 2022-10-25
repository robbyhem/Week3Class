using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Class
{
    public class Mikano : Generator
    {
        public int OilLevel { get; set; } = 100;


        public override bool Start()
        {
            

            if (OilLevel >= 50)
            {
                for (int i = 100; i >= 50; i--)
                {
                    return true;
                }
            }
            return false;

            
            
        }

        public int OilQuantity { get; set; } = 0;
        public int RefillOil()
        {
            
            if (OilLevel == 100)
            {
                for (int i = 0; i < 50; i++)
                {
                    return 0;
                }
            }
            return OilQuantity; 
        }

        public override bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
