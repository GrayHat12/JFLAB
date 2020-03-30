using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFLAB
{
    class State
    {
        public string Label;
        public string Name;
        public bool Initial;
        public bool Final;
        public List<Transition> transitions;
        public State()
        {
            this.Label = "";
            this.Name = "q0";
            this.Initial = false;
            this.Final = false;
            this.transitions = new List<Transition>();
        }
        public State(string name)
        {
            this.Label = "";
            if (name.Length > 0)
                this.Name = name;
            else
                this.Name = "q0";
            this.Initial = false;
            this.Final = false;
            this.transitions = new List<Transition>();
        }
    }
}
