using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFLAB
{
    class Transition
    {
        public State from;
        public State to;
        public string symbol;

        public Transition(string symbol,State from,State to)
        {
            this.symbol = symbol;
            this.from = from;
            this.to = to;
        }

    }
}
