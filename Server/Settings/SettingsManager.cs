using System;
using System.IO;
using System.Text.Json;

namespace Server.Settings
{
    public class SettingsManager
    {
        private string SettingsFilename;

        public SettingsManager(string filename, Setting defaultSettings)
        {
            SettingsFilename = filename;

            if (!File.Exists(SettingsFilename))
                SaveSettings(defaultSettings);
        }
        public void SaveSettings(Setting settings)
        {
            try 
            { 
                var jsonString = JsonSerializer.Serialize(settings);

                using (var sw = new StreamWriter(SettingsFilename))
                {
                    sw.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error save settings: " + ex.Message);
            }
        }

        public Setting LoadSettings()
        {
            try
            {
                using (var sr = new StreamReader(SettingsFilename))
                {
                    var jsonString = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<Setting>(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error load settings: " + ex.Message);
                return null;
            }
        }

    }
}
