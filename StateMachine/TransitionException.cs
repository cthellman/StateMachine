using System;

namespace StateMachine
{
    public class TransitionException : Exception
    {
        public TransitionException(string from,string to):base($"Invalid transition - from <{from}> to <{to}>")
        {
        }
    }
}