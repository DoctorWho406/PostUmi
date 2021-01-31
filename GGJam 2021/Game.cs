using System;
using Aiv.Audio;
using Aiv.Fast2D;
using GGJam_2021.Manager;
using OpenTK;

namespace GGJam_2021
{
    static class Game
    {
        public static Random Random;
        public static Window Window;
        public static Vector2 WindowCenter
        {
            get; private set;
        }
        public static float DeltaTime => Window.DeltaTime;
        public static Player Player;
        public static Cursor Cursor;

        public static AudioSource RadioEmitter;
        private static AudioSource musicEmitter01;
        private static AudioSource musicEmitter02;
        private static AudioSource musicEmitter03;
        private static AudioSource musicEmitter04;
        private static AudioSource musicEmitter05;
        private static AudioSource musicEmitter06;

        public static AudioClip RadioClip;
        private static AudioClip bgMusic01;
        private static AudioClip bgMusic02;
        private static AudioClip bgMusic03;
        private static AudioClip bgMusic04;
        private static AudioClip bgMusic05;
        private static AudioClip bgMusic06;
        private static AudioClip bgMusic07;
        private static AudioClip bgMusic08;
        private static AudioClip bgMusic09;
        private static AudioClip bgMusic10;
        private static AudioClip bgMusic11;

        private static float waitForMusic;

        public static int ObjectTaken;

        public static void Init()
        {
            //Init Random
            Random = new Random();
            //Init Window
            Window = new Window(1920, 1080, "GGJam 2021", true);
            //Disable VSync
            Window.SetVSync(false);
            //Set WindowCenter
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            TextureInitManager.Start();
            SceneInitManager.Start();
            AudioClipInitManager.Start();
            //Edit cursor
            Cursor = new Cursor();
            Cursor.Scale(0.2f);
            Window.SetMouseVisible(false);

            Player = new Player();

            //AudioStuff
            waitForMusic = 1;
            musicEmitter01 = new AudioSource();
            musicEmitter02 = new AudioSource();
            musicEmitter03 = new AudioSource();
            musicEmitter04 = new AudioSource();
            musicEmitter05 = new AudioSource();
            musicEmitter06 = new AudioSource();
            RadioEmitter = new AudioSource();

            bgMusic07 = AudioManager.GetAudioClip("Intro");
            bgMusic01 = AudioManager.GetAudioClip("BgMusic01");
            bgMusic02 = AudioManager.GetAudioClip("BgMusic02");
            bgMusic03 = AudioManager.GetAudioClip("BgMusic03");
            bgMusic04 = AudioManager.GetAudioClip("BgMusic04");
            bgMusic05 = AudioManager.GetAudioClip("BgMusic05");
            bgMusic06 = AudioManager.GetAudioClip("BgMusic06");
            bgMusic09 = AudioManager.GetAudioClip("Outro01");
            bgMusic10 = AudioManager.GetAudioClip("Outro02");
            bgMusic11 = AudioManager.GetAudioClip("Outro03");
            bgMusic08 = AudioManager.GetAudioClip("Credits");
            RadioClip = AudioManager.GetAudioClip(AudioManager.Shuffle(AudioManager.RadioChannel, 3));

            musicEmitter01.Volume = 1f;
            musicEmitter02.Volume = 0f;
            musicEmitter03.Volume = 0f;
            musicEmitter04.Volume = 0f;
            musicEmitter05.Volume = 0f;
            musicEmitter06.Volume = 0f;
            RadioEmitter.Volume = 0f;

            ObjectTaken = 0;
        }
        public static void Play()
        {
            while (Window.IsOpened)
            {   

                //Exit on esc
                if (Window.GetKey(KeyCode.Esc)/* || !Player.isAlive*/)
                {
                    break;
                }

                if (waitForMusic > 0)
                {
                    waitForMusic -= DeltaTime;
                }
                else
                {
                    musicEmitter01.Stream(bgMusic01, DeltaTime);
                    musicEmitter02.Stream(bgMusic02, DeltaTime);
                    musicEmitter03.Stream(bgMusic03, DeltaTime);
                }

                if (ObjectTaken >= 3)
                {
                    AudioManager.FadeIn(musicEmitter02, musicEmitter02.Volume, 1);
                }

                if (ObjectTaken >=5)
                {
                    AudioManager.FadeIn(musicEmitter03, musicEmitter03.Volume, 1);
                }

                Console.WriteLine(Window.MousePosition.X + "x" + "  " + Window.MousePosition.Y + "y");
                Player.Input();

                SceneManager.Update();
                StatsManager.Update();

                SceneManager.Draw();
                StatsManager.Draw();
               

                Window.Update();
            }
        }
    }
}
