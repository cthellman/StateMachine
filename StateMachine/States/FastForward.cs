namespace StateMachine.States
{
    public class FastForward:State
    {
        public FastForward(Transport context) : base(context)
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
            GetType().Name.NoTransition();
        }

        public override void HandleRewindRequest()
        {
            throw new TransitionException(GetType().Name,Rew);
        }
    }
}