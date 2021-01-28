namespace StateMachine.States
{
    public abstract class State
    {
        protected readonly Transport Context;

        public const string Rec = "Record";
        public const string Ply = "Play";
        public const string Ff = "FastForward";
        public const string Rew = "Rewind";
        public const string Pau = "Pause";
        
        protected State(Transport context)
        {
            Context = context;
        }

        public abstract void HandlePlayRequest();
        public abstract void HandleRecordRequest();
        public abstract void HandlePauseRequest();
        public abstract void HandleStopRequest();
        public abstract void HandleFastForwardRequest();
        public abstract void HandleRewindRequest(); 
    }
}