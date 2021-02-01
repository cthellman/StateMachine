using StateMachine.Interfaces;
using StateMachine.States;

namespace StateMachine
{
    public class Transport : ITransport
    {
        private State _state;

        public Transport()
        {
            _state = StopState();
        }

        public State FastForwardState()
        {
            return new FastForward(this);
        }
        public State RewindState()
        {
            return new Rewind(this);
        }
        public State PlayState()
        {
            return new Play(this);
        }
        public State PausePlayState()
        {
            return new PausePlay(this);
        }
        public State PauseRecordState()
        {
            return new PauseRecord(this);
        }
        public State StopState()
        {
            return new Stop(this);
        }
        public State RecordState()
        {
            return new Record(this);
        }
        
        public void SetState(State state)
        {
            Log.Transition(_state,state);
            _state = state;
        }

        public State GetState()
        {
            return _state;
        }

        public string GetStateString()
        {
            return GetState().GetType().Name;
        }

        public void RequestPlay()
        {
            _state.HandlePlayRequest();
        }

        public void RequestStop()
        {
            _state.HandleStopRequest();
        }

        public void RequestRecord()
        {
            _state.HandleRecordRequest();
        }

        public void RequestFastForward()
        {
            _state.HandleFastForwardRequest();
        }

        public void RequestRewind()
        {
            _state.HandleRewindRequest();
        }

        public void RequestPause()
        {
            _state.HandlePauseRequest();
        }
    }
}