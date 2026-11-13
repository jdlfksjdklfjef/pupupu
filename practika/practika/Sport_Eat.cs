using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika
{
    public class Sport_Eat : Product
    {
        public override int CalcuateDiscount()
        {
            if (soldcount_ >= 5 && soldcount_ <= 10)
                return 15;
            if (soldcount_ > 10)
                return 25;
            else return 0;
        }
    }
}
