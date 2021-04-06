using Server.Settings;

namespace Server
{
    public static class Config
    {
        public const string SettingsFilename = "settings.json";
        public static Setting DefaultSettings { get; } = new Setting { IntervalSec = 10 };
    }
}
