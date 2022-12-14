using OWML.ModHelper;
using System.IO;

namespace OWVoiceModTemplate;

public class OWVoiceModTemplate : ModBehaviour
{
    public IOWVoiceMod OWVoiceModAPI;

    private void Start()
    {
        OWVoiceModAPI = ModHelper.Interaction.TryGetModApi<IOWVoiceMod>("Krevace.VoiceMod");
        OWVoiceModAPI.RegisterAssets(Path.Combine(ModHelper.Manifest.ModFolderPath, "Assets"));
    }
}