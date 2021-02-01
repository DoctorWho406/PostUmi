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
        public static AudioSource MusicEmitter01;
        public static AudioSource MusicEmitter02;
        public static AudioSource MusicEmitter03;
        public static AudioSource MusicEmitter04;
        public static AudioSource MusicEmitter05;
        public static AudioSource MusicEmitter06;
        public static AudioSource MusicEmitter07;

        public static AudioClip RadioClip;
        public static AudioClip BgMusic01;
        public static AudioClip BgMusic02;
        public static AudioClip BgMusic03;
        public static AudioClip BgMusic04;
        public static AudioClip BgMusic05;
        public static AudioClip BgMusic06;
        public static AudioClip BgMusic07;
        public static AudioClip BgMusic08;
        public static AudioClip BgMusic09;
        public static AudioClip BgMusic10;
        public static AudioClip BgMusic11;

        private static float waitForMusic;

        public static int ObjectTaken;

        public static float DeltaTime { get { return Game.DeltaTime; } }

        public static void Start()
        {

            waitForMusic = 1;
            MusicEmitter01 = new AudioSource();
            MusicEmitter02 = new AudioSource();
            MusicEmitter03 = new AudioSource();
            MusicEmitter04 = new AudioSource();
            MusicEmitter05 = new AudioSource();
            MusicEmitter06 = new AudioSource();
            MusicEmitter07 = new AudioSource();
            RadioEmitter = new AudioSource();

            BgMusic01 = AudioManager.GetAudioClip("BgMusic01");
            BgMusic02 = AudioManager.GetAudioClip("BgMusic02");
            BgMusic03 = AudioManager.GetAudioClip("BgMusic03");
            BgMusic04 = AudioManager.GetAudioClip("BgMusic04");
            BgMusic05 = AudioManager.GetAudioClip("BgMusic05");
            BgMusic06 = AudioManager.GetAudioClip("BgMusic06");
            BgMusic07 = AudioManager.GetAudioClip("Intro");
            BgMusic08 = AudioManager.GetAudioClip("Credits");
            BgMusic09 = AudioManager.GetAudioClip("Outro01");
            BgMusic10 = AudioManager.GetAudioClip("Outro02");
            BgMusic11 = AudioManager.GetAudioClip("Outro03");
            RadioClip = AudioManager.GetAudioClip(AudioManager.Shuffle(AudioManager.RadioChannel, 3));

            MusicEmitter01.Volume = 1f;
            MusicEmitter02.Volume = 0f;
            MusicEmitter03.Volume = 0f;
            MusicEmitter04.Volume = 0f;
            MusicEmitter05.Volume = 0f;
            MusicEmitter06.Volume = 0f;
            MusicEmitter07.Volume = 0f;
            RadioEmitter.Volume = 0f;

            
        }

        public static void Update()
        {
            if (waitForMusic > 0)
            {
                waitForMusic -= DeltaTime;
            }
            else
            {
                MusicEmitter01.Stream(BgMusic01, DeltaTime);
                MusicEmitter02.Stream(BgMusic02, DeltaTime);
                MusicEmitter03.Stream(BgMusic03, DeltaTime);
            }

            if (ObjectTaken >= 3)
            {
                AudioManager.FadeIn(MusicEmitter02, MusicEmitter02.Volume, 1);
            }

            if (ObjectTaken >= 5)
            {
                AudioManager.FadeIn(MusicEmitter03, MusicEmitter03.Volume, 1);
            }

            if (ObjectTaken >= 7)
            {
                MusicEmitter04.Stream(BgMusic09, DeltaTime);
                MusicEmitter05.Stream(BgMusic10, DeltaTime);
                MusicEmitter06.Stream(BgMusic11, DeltaTime);

                AudioManager.FadeOut(MusicEmitter01, MusicEmitter01.Volume, 1);
                AudioManager.FadeOut(MusicEmitter02, MusicEmitter01.Volume, 1);
                AudioManager.FadeOut(MusicEmitter03, MusicEmitter01.Volume, 1);

                AudioManager.FadeIn(MusicEmitter04, MusicEmitter04.Volume, 1);
                AudioManager.FadeIn(MusicEmitter05, MusicEmitter05.Volume, 1);
                AudioManager.FadeIn(MusicEmitter06, MusicEmitter06.Volume, 1);
            }

            //if (//PortaFinaleIsOpened)
            //{
            //    AudioManager.FadeOut(MusicEmitter04, MusicEmitter04.Volume, 1);
            //    AudioManager.FadeOut(MusicEmitter05, MusicEmitter05.Volume, 1);
            //    AudioManager.FadeOut(MusicEmitter06, MusicEmitter06.Volume, 1);
            //    MusicEmitter07.Stream(BgMusic08, DeltaTime);
            //    AudioManager.FadeIn(MusicEmitter07, MusicEmitter07.Volume, 1);
            //}
        }
    }


}
