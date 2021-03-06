using Autofac;
using SnackTime.Core.Database;
using SnackTime.Core.Media.Episodes;
using SnackTime.Core.Process;
using SnackTime.Core.Session;
using SnackTime.Core.Settings;
using SonarrSharp;

namespace SnackTime.Core
{
    public class DependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SonarrFactory>().AsSelf();

            builder.RegisterType<DatabaseFactory>().AsSelf();

            builder.RegisterType<SettingsService>().AsSelf();
            builder.RegisterType<SettingsRepo>().AsSelf();
            
            builder.RegisterType<LocalSessionRepo>().As<ILocalSessionRepo>();

            builder.RegisterType<TimeService>().AsSelf();
            builder.RegisterType<SessionFactory>().AsSelf();
            builder.RegisterType<Queue<Item>>().AsSelf().SingleInstance();

            builder.RegisterType<EpisodeFileLookupProvider>().AsSelf();
            builder.RegisterType<EpisodeProvider>().AsSelf();

            builder.RegisterType<ProcessManager>().AsSelf();
            builder.RegisterType<EpisodeBuilder>().AsSelf();
        }
    }

    public class SonarrFactory
    {
        private readonly SettingsService _settingsService;

        public SonarrFactory(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public SonarrClient GetClient()
        {
            var host = "localhost";
            var port = 8989;
            var apiKey = "2e8fcac32bf147608239cab343617485";

            var settings = _settingsService.Get();

            if (!string.IsNullOrWhiteSpace(settings.Remote.MediaServerAddress))
            {
                host = settings.Remote.MediaServerAddress;
            }


            return new SonarrClient(host, port, apiKey);
        }
    }
}