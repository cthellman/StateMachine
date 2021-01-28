namespace StateMachine.States
{
    public class Record:State
    {
        public Record(Transport context) : base(context)
        {
        }

        public override void HandlePlayRequest()
        {
            throw new TransitionException(GetType().Name,Ply);
        }

        public override void HandleRecordRequest()
        {
            GetType().Name.NoTransition();
        }

        public override void HandlePauseRequest()
        {
            Context.SetState(Context.PauseRecordState());
        }

        public override void HandleStopRequest()
        {
            Context.SetState(Context.StopState());
        }

        public override void HandleFastForwardRequest()
        {
            throw new TransitionException(GetType().Name,Ff);
        }

        public override void HandleRewindRequest()
        {
            throw new TransitionException(GetType().Name,Rew);
        }
    }
}