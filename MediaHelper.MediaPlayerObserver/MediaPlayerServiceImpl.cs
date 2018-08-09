using System;
using System.Threading.Tasks;
using Grpc.Core;
using LocalNetflix.Protobuf.MediaPlayerModels;
using LocalNetflix.Protobuf.MediaPlayerServices;
using LocalNetflix.Protobuf.MiscModels;
using MPC_HC.Domain;

namespace MediaHelper.MediaPlayerObserver
{
    public class MediaPlayerServiceImpl : MediaPlayerService.MediaPlayerServiceBase
    {
        public static event EventHandler StopEvent; 
        public static event EventHandler StartEvent; 
        public static event EventHandler InitEvent;
        
        
        private readonly IMPCHomeCinema _mpcHomeCinemaClient;
        private readonly ProcessManager _processManager;
        private          string         _mpchcPath;

        public MediaPlayerServiceImpl(IMPCHomeCinema mpcHomeCinemaClient)
        {
            _mpcHomeCinemaClient = mpcHomeCinemaClient;
            _processManager = ProcessManager.Instance;
        }

        public override Task<EmptyMessage> Init(Init request, ServerCallContext context)
        {
            _mpchcPath = request.MediaPlayerPath;
            InitEvent?.Invoke(this, EventArgs.Empty);
            return Task.FromResult(new EmptyMessage());
        }

        public override Task<EmptyMessage> Start(EmptyMessage request, ServerCallContext context)
        {
            _processManager.StartProcess(_mpchcPath);
            try
            {
                StartEvent?.Invoke(this,EventArgs.Empty);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return Task.FromResult(new EmptyMessage());
        }

        public override Task<IsRunning> IsRunning(EmptyMessage request, ServerCallContext context)
        {
            return Task.FromResult(new IsRunning
            {
                Value = _processManager.IsProcessRunning(_mpchcPath)
            });
        }

        public override Task<EmptyMessage> Stop(EmptyMessage request, ServerCallContext context)
        {
            _processManager.StopProcess(_mpchcPath);
            StopEvent?.Invoke(this, EventArgs.Empty);
            return Task.FromResult(new EmptyMessage());
        }

        public override async Task<EmptyMessage> Open(OpenFile request, ServerCallContext context)
        {
            await _mpcHomeCinemaClient.OpenFileAsync(request.FileName);
            await Task.Delay(1000);
            await _mpcHomeCinemaClient.SetPosition(TimeSpan.FromSeconds(request.FromSeconds));

            //todo here we need to close MPCHC and then reOpen it to ensure the fullscreen has not changed.
//            await _mpcHomeCinemaClient.
            return new EmptyMessage();
        }

        public override async Task<PlayingMediaInfo> Info(EmptyMessage request, ServerCallContext context)
        {
            var info = await _mpcHomeCinemaClient.GetInfo();

            var model = new PlayingMediaInfo
            {
                Duration = (int) info.Duration.TotalSeconds,
                Eplipsed = (int) info.Position.TotalSeconds,
                FileName = info.FileName,
                State = info.State.Convert(),
            };

            return model;
        }
    }
}