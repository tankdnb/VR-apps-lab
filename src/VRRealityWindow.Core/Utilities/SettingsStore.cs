using System.Text.Json;

namespace VRRealityWindow.Core.Utilities;

public static class SettingsStore
{
    public static MvpSettings LoadOrCreate(string path)
    {
        if (File.Exists(path))
        {
            var json = File.ReadAllText(path);
            var settings = JsonSerializer.Deserialize<MvpSettings>(json, MvpSettings.CreateJsonOptions());

            if (settings is not null)
            {
                return settings;
            }
        }

        var defaults = MvpSettings.CreateDefault();
        Save(path, defaults);
        return defaults;
    }

    public static void Save(string path, MvpSettings settings)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");
        var json = JsonSerializer.Serialize(settings, MvpSettings.CreateJsonOptions());
        File.WriteAllText(path, json);
    }
}
