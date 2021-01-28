namespace StateMachine.States
{
    public class Rewind:State
    {
        public Rewind(Transport context) : base(context)
        {
        }

        public override void HandlePlayRequest()
        {
            throw new TransitionException(GetType().Name,Ply);
        }

        public override void HandleRecordRequest()
        {
            throw new TransitionException(GetType().Name,Rec);
        }

        public override void HandlePauseRequest()
        {
            throw new TransitionException(GetType().Name,Pau);
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
            GetType().Name.NoTransition();
        }
    }
}