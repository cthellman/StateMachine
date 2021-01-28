using System.Diagnostics;
using StateMachine.States;

namespace StateMachine
{
    public static class Log
    {
        public static void NoTransition(this string state)
        {
            Debug.WriteLine($"Already in <{state}>");
        }

        public static void Transition(State from, State to)
        {
            Debug.WriteLine($"Transition - from <{from.GetType().Name}> to <{to.GetType().Name}>");
        }
    }
}