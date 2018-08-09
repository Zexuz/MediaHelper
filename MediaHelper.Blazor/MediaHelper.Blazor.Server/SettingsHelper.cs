using System.IO;
using Newtonsoft.Json;

namespace MediaHelper.Blazor.Server.Controllers.v1
{
    public static class SettingsHelper
    {
        public static void Save(Settings settings)
        {
            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\\.settings", JsonConvert.SerializeObject(settings));
        }

        public static Settings Load()
        {
            return JsonConvert.DeserializeObject<Settings>(System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\.settings"));
        }
    }
}