using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021.Manager
{
    static class AudioClipInitManager
    {
        static public void Start()
        {
            AudioManager.AddClips("Intro", Constants.AudioClipsDirectory + "Intro.ogg");
            AudioManager.AddClips("Credits", Constants.AudioClipsDirectory + "Credits.ogg");
            AudioManager.AddClips("BgMusic01", Constants.AudioClipsDirectory + "GameLoop_layer_01.ogg");
            AudioManager.AddClips("BgMusic02", Constants.AudioClipsDirectory + "GameLoop_layer_02.ogg");
            AudioManager.AddClips("BgMusic03", Constants.AudioClipsDirectory + "GameLoop_layer_03.ogg");
            AudioManager.AddClips("BgMusic04", Constants.AudioClipsDirectory + "GameLoop_layer_01_glitch.ogg");
            AudioManager.AddClips("BgMusic05", Constants.AudioClipsDirectory + "GameLoop_layer_02_glitch.ogg");
            AudioManager.AddClips("BgMusic06", Constants.AudioClipsDirectory + "GameLoop_layer_03_glitch.ogg");
            AudioManager.AddClips("Outro01", Constants.AudioClipsDirectory + "Outro_layer_01.ogg");
            AudioManager.AddClips("Outro02", Constants.AudioClipsDirectory + "Outro_layer_02.ogg");
            AudioManager.AddClips("Outro03", Constants.AudioClipsDirectory + "Outro_layer_03.ogg");
            AudioManager.AddClips("Radio01", Constants.AudioClipsDirectory + "Radio01.ogg");
            AudioManager.AddClips("Radio02", Constants.AudioClipsDirectory + "Radio02.ogg");
            AudioManager.AddClips("Radio03", Constants.AudioClipsDirectory + "Radio03.ogg");
            AudioManager.AddClips("FootStep", Constants.AudioClipsDirectory + "FootStep.ogg");
            AudioManager.AddClips("Interaction", Constants.AudioClipsDirectory + "Interaction.ogg");

        }
    }
}
