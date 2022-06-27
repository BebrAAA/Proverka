using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Beautiful.AddDate
{
    internal class BD
    {
        public static TradeEntities1 Connect;

        public static TradeEntities1 GetConnect()
        {
            if(Connect == null) Connect = new TradeEntities1();
            return Connect;
        }
    }
}
