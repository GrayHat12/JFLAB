using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFLAB
{
    class FARunner
    {
        private State InitialState;
        public State currentState;
        private bool EndAtFinalState;
        public string Input;
        public FARunner(State InitialState,string Input)
        {
            this.InitialState = InitialState;
            this.EndAtFinalState = true;
            this.Input = Input;
            this.currentState = this.InitialState;
        }
        public FARunner(State InitialState,bool EndAtFinalState,string Input)
        {
            this.InitialState = InitialState;
            this.EndAtFinalState = EndAtFinalState;
            this.Input = Input;
            this.currentState = this.InitialState;
        }
        public bool Run()
        {
            Transition transition=null;
            string selectedSymbol = "";
            if (currentState.Final == true && this.EndAtFinalState==true)
            {
                return false;
            }
            foreach(Transition trans in currentState.transitions)
            {
                string chars = this.Input.Substring(0, trans.symbol.Length);
                if(trans.symbol.Equals(chars))
                {
                    selectedSymbol = trans.symbol;
                    transition = trans;
                    break;
                }
            }
            if (transition == null)
            {
                return false;
            }
            this.Input = this.Input.Substring(selectedSymbol.Length);
            this.currentState = transition.to;
            return true;
        }
        public void RunAll()
        {
            bool run = true;
            while (run == true)
            {
                run = this.Run();
            }
        }
    }
}
