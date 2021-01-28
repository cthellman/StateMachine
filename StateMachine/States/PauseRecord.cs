namespace StateMachine.States
{
    public class PauseRecord:State
    {
        public PauseRecord(Transport transport) : base(transport)
        {
            
        }

        public override void HandlePlayRequest()
        {
            throw new TransitionException(GetType().Name,Ply);
        }

        public override void HandleRecordRequest()
        {
            Context.SetState(Context.RecordState());
        }

        public override void HandlePauseRequest()
        {
            Context.SetState(Context.RecordState());
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