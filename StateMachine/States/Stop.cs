namespace StateMachine.States
{
    public class Stop:State
    {
        public Stop(Transport context) : base(context)
        {
        }

        public override void HandlePlayRequest()
        {
            Context.SetState(Context.PlayState());
        }

        public override void HandleRecordRequest()
        {
            Context.SetState(Context.RecordState());
        }

        public override void HandlePauseRequest()
        {
            throw new TransitionException(GetType().Name,Pau);
        }

        public override void HandleStopRequest()
        {
            GetType().Name.NoTransition();
        }

        public override void HandleFastForwardRequest()
        {
            Context.SetState(Context.FastForwardState());
        }

        public override void HandleRewindRequest()
        {
            Context.SetState(Context.RewindState());
        }
    }
}