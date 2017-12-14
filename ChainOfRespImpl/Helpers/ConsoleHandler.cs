using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespImpl.Helpers
{
    public abstract class ConsoleHandler
    {
        private static int _nextId = 1;
        protected readonly int _id = _nextId++;
        protected ConsoleHandler _predecessor;

        public void Add(ConsoleHandler handler)
        {
            if(_predecessor == null)
            {
                _predecessor = handler;
            }else
            {
                _predecessor.Add(handler);
            }
        }

        public ConsoleHandler GetParent()
        {
            return _predecessor;
        }

        protected bool CanExecute(int actionId)
        {
            return actionId == _id ? true : false;
        }

        public virtual void Execute(int actionId)
        {
            if(_predecessor == null)
            {
                throw new InvalidOperationException("Action doesn't exist.");
            }

            _predecessor.Execute(actionId);
        }

        public abstract string GetAction();
    }
}
