namespace StateMachine.States
{
    public class PausePlay:State
    {
        public PausePlay(Transport context) : base(context)
        {
        }

        public override void HandlePlayRequest()
        {
            Context.SetState(Context.PlayState());
        }

        public override void HandleRecordRequest()
        {
            throw new TransitionException(GetType().Name,Rec);
        }

        public override void HandlePauseRequest()
        {
            Context.SetState(Context.PlayState()); 
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