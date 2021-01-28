using System;
using Xunit;

namespace StateMachine.Test
{
    public class StateTests
    {
        private readonly ITransport _t;

        public StateTests()
        {
            _t = new Transport();
        }

        [Fact]
        public void StartupTest()
        {
            Assert.Equal(_t.GetState(),_t.StopState());
        }

        [Fact]
        public void PlayTest()
        {
            _t.RequestPlay();
            Assert.Equal(_t.GetState(), _t.PlayState());

            Assert.Throws<TransitionException>(() => _t.RequestFastForward());
            Assert.Throws<TransitionException>(() => _t.RequestRecord());
            Assert.Throws<TransitionException>(() => _t.RequestRewind());

            _t.RequestPause();
            Assert.Equal(_t.GetState(), _t.PausePlayState());

            Assert.Throws<TransitionException>(() => _t.RequestFastForward());
            Assert.Throws<TransitionException>(() => _t.RequestRecord());
            Assert.Throws<TransitionException>(() => _t.RequestRewind());

            _t.RequestPause();
            Assert.Equal(_t.GetState(), _t.PlayState());
            _t.RequestPause();
            Assert.Equal(_t.GetState(), _t.PausePlayState());
            _t.RequestPlay();
            Assert.Equal(_t.GetState(), _t.PlayState());
            _t.RequestStop();
            Assert.Equal(_t.GetState(), _t.StopState());
        }

        [Fact]
        public void FfRewTest()
        {
            _t.RequestFastForward();
            Assert.Equal(_t.GetState(), _t.FastForwardState());

            Assert.Throws<TransitionException>(() => _t.RequestPause());
            Assert.Throws<TransitionException>(() => _t.RequestRecord());
            Assert.Throws<TransitionException>(() => _t.RequestRewind());
            Assert.Throws<TransitionException>(() => _t.RequestPlay());

            _t.RequestStop();
            Assert.Equal(_t.GetState(), _t.StopState());
            
            _t.RequestRewind();
            Assert.Equal(_t.GetState(), _t.RewindState());

            Assert.Throws<TransitionException>(() => _t.RequestPause());
            Assert.Throws<TransitionException>(() => _t.RequestRecord());
            Assert.Throws<TransitionException>(() => _t.RequestFastForward());
            Assert.Throws<TransitionException>(() => _t.RequestPlay());

            _t.RequestStop();
            Assert.Equal(_t.GetState(), _t.StopState());
        }

        [Fact]
        public void RecTest()
        {
            _t.RequestRecord();
            Assert.Equal(_t.GetState(), _t.RecordState());
            _t.RequestPause();
            Assert.Equal(_t.GetState(), _t.PauseRecordState());
            _t.RequestRecord();
            Assert.Equal(_t.GetState(), _t.RecordState());
            _t.RequestPause();
            Assert.Equal(_t.GetState(), _t.PauseRecordState());
            _t.RequestPause();
            Assert.Equal(_t.GetState(), _t.RecordState());

            Assert.Throws<TransitionException>(() => _t.RequestFastForward());
            Assert.Throws<TransitionException>(() => _t.RequestRewind());
            Assert.Throws<TransitionException>(() => _t.RequestPlay());
        }
    }
}
