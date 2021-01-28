namespace StateMachine.States
{
    public class Play : State
    {
        public Play(Transport context) : base(context)
        {
        }

        public override void HandlePlayRequest()
        {
            GetType().Name.NoTransition();
        }

        public override void HandleRecordRequest()
        {
            throw new TransitionException(GetType().Name,Rec);
        }

        public override void HandlePauseRequest()
        {
            Context.SetState(Context.PausePlayState());
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