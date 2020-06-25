using MelonLoader;
using UnityEngine;

namespace ForceMode7point1
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            AudioConfiguration a = AudioSettings.GetConfiguration();
            a.speakerMode = AudioSpeakerMode.Mode7point1;
            if (AudioSettings.Reset(a))
            {
                MelonModLogger.Log("Successful change");
            }
            else
            {
                MelonModLogger.LogError("Change failed");
            }
        }
    }
}
