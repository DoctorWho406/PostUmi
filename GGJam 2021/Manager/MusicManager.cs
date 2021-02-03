using Aiv.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021
{
    static class MusicManager
    {
        public static AudioSource RadioEmitter;
        public static AudioSource IntroEmitter;
        public static AudioSource BgMusicEmitter01;
        public static AudioSource BgMusicEmitter02;
        public static AudioSource BgMusicEmitter03;
        public static AudioSource OutroEmitter01;
        public static AudioSource OutroEmitter02;
        public static AudioSource OutroEmitter03;
        public static AudioSource CreditsEmitter;

        public static AudioClip RadioClip;
        public static AudioClip Intro;
        public static AudioClip BgMusic01;
        public static AudioClip BgMusic02;
        public static AudioClip BgMusic03;
        public static AudioClip Outro01;
        public static AudioClip Outro02;
        public static AudioClip Outro03;
        public static AudioClip Credits;

        private static float waitForMusic;

        public static int ObjectTaken;

        public static float DeltaTime { get { return Game.DeltaTime; } }

        public static void Start()
        {

            waitForMusic = 1;
            ObjectTaken = 0;
            RadioEmitter = new AudioSource();
            IntroEmitter = new AudioSource();
            BgMusicEmitter01 = new AudioSource();
            BgMusicEmitter02 = new AudioSource();
            BgMusicEmitter03 = new AudioSource();
            OutroEmitter01 = new AudioSource();
            OutroEmitter02 = new AudioSource();
            OutroEmitter03 = new AudioSource();
            CreditsEmitter = new AudioSource();

            RadioClip = AudioManager.GetAudioClip(AudioManager.Shuffle(AudioManager.RadioChannel, 3));
            Intro = AudioManager.GetAudioClip("Intro");
            BgMusic01 = AudioManager.GetAudioClip("BgMusic01");
            BgMusic02 = AudioManager.GetAudioClip("BgMusic02");
            BgMusic03 = AudioManager.GetAudioClip("BgMusic03");
            Outro01 = AudioManager.GetAudioClip("Outro01");
            Outro02 = AudioManager.GetAudioClip("Outro02");
            Outro03 = AudioManager.GetAudioClip("Outro03");
            Credits = AudioManager.GetAudioClip("Credits");

            RadioEmitter.Volume = 0f;
            IntroEmitter.Volume = 0f;
            BgMusicEmitter01.Volume = 0f;
            BgMusicEmitter02.Volume = 0f;
            BgMusicEmitter03.Volume = 0f;
            OutroEmitter01.Volume = 0f;
            OutroEmitter02.Volume = 0f;
            OutroEmitter03.Volume = 0f;
            CreditsEmitter.Volume = 0f;
        }

        public static void Reset()
        {
            waitForMusic = 0;
            ObjectTaken = 0;
        }

        public static void Update()
        {


            if (waitForMusic > 0)
            {
                waitForMusic -= DeltaTime;
            }
            else
            {
                if (SceneManager.ActiveScene == Scene.Menu || SceneManager.ActiveScene == Scene.DialogueInit_1 || SceneManager.ActiveScene == Scene.DialogueInit_2 || SceneManager.ActiveScene == Scene.MeDialogueInit_3)
                {
                    AudioManager.FadeOut(CreditsEmitter, CreditsEmitter.Volume, Credits);
                    AudioManager.FadeIn(IntroEmitter, IntroEmitter.Volume, Intro);

                }

                if (SceneManager.ActiveScene != Scene.Menu && SceneManager.ActiveScene != Scene.DialogueInit_1 || SceneManager.ActiveScene != Scene.DialogueInit_2 || SceneManager.ActiveScene != Scene.MeDialogueInit_3 && SceneManager.ActiveScene != Scene.GoodEndGame && SceneManager.ActiveScene != Scene.BadEndGame)
                {
                    AudioManager.FadeOut(IntroEmitter, IntroEmitter.Volume, Intro);
                    AudioManager.FadeIn(BgMusicEmitter01, BgMusicEmitter01.Volume, BgMusic01);
                    BgMusicEmitter02.Stream(BgMusic02, DeltaTime);
                    BgMusicEmitter03.Stream(BgMusic03, DeltaTime);
                }

                if (SceneManager.ActiveScene == Scene.BadEndGame)
                {
                    AudioManager.FadeOut(BgMusicEmitter01, BgMusicEmitter01.Volume, BgMusic01);
                    AudioManager.FadeIn(CreditsEmitter, CreditsEmitter.Volume, Credits);
                }

                if (ObjectTaken >= 3)
                {
                    AudioManager.FadeIn(BgMusicEmitter02, BgMusicEmitter02.Volume);
                }

                if (ObjectTaken >= 5)
                {
                    AudioManager.FadeIn(BgMusicEmitter03, BgMusicEmitter03.Volume);
                }

                if (ObjectTaken >= InteractableObjectManager.orderList.Count)
                {
                    AudioManager.FadeOut(BgMusicEmitter01, BgMusicEmitter01.Volume, BgMusic01);
                    AudioManager.FadeOut(BgMusicEmitter02, BgMusicEmitter02.Volume, BgMusic02);
                    AudioManager.FadeOut(BgMusicEmitter03, BgMusicEmitter03.Volume, BgMusic03);
                    AudioManager.FadeIn(OutroEmitter01, OutroEmitter01.Volume, Outro01);
                    AudioManager.FadeIn(OutroEmitter02, OutroEmitter02.Volume, Outro02);
                    AudioManager.FadeIn(OutroEmitter03, OutroEmitter03.Volume, Outro03);
                }

                if (SceneManager.ActiveScene == Scene.GoodEndGame)
                {
                    AudioManager.FadeOut(OutroEmitter01, OutroEmitter01.Volume, Outro01);
                    AudioManager.FadeOut(OutroEmitter02, OutroEmitter02.Volume, Outro02);
                    AudioManager.FadeOut(OutroEmitter03, OutroEmitter03.Volume, Outro03);
                    AudioManager.FadeIn(CreditsEmitter, CreditsEmitter.Volume, Credits);
                }
                
            }
        }
    }
}
