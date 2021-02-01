using StateMachine.States;

namespace StateMachine.Interfaces
{
    /// <summary>
    /// Public API
    /// </summary>
    public interface ITransport
    {
        State GetState();
        void RequestPlay();
        void RequestStop();
        void RequestRecord();
        void RequestFastForward();
        void RequestRewind();
        void RequestPause();
        State FastForwardState();
        State RewindState();
        State PlayState();
        State PausePlayState();
        State PauseRecordState();
        State StopState();
        State RecordState();
        string GetStateString();
    }
}