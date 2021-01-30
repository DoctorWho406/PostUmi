using System;
using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    static class Game {
        public static Random Random;
        public static Window Window;
        public static Vector2 WindowCenter {
            get; private set;
        }
        public static float DeltaTime => Window.DeltaTime;
        public static Player Player;
        public static Cursor Cursor;

        

        //private static Background background;

        public static void Init() {
            //Init Random
            Random = new Random();
            //Init Window
            Window = new Window(/*1920, 1080,*/ "GGJam 2021"/*, true*/);
            //Disable VSync
            Window.SetVSync(false);
            //Set WindowCenter
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            AssetsManager.Init();

            //Edit cursor
            Cursor = new Cursor();
            Window.SetMouseVisible(false);

            
            Player = new Player() {
                Position = Game.WindowCenter
            };
        }
        public static void Play() {
            while (Window.IsOpened) {
                //Exit on esc
                if (Window.GetKey(KeyCode.Esc)/* || !Player.isAlive*/) {
                    break;
                }

                Player.Input();

                SceneManager.Update();
                Cursor.Update();
                //Player.Update();
                //background.Update();
                //background.Draw();
                SceneManager.Draw();
                //Player.Draw();
                Cursor.Draw();

                Window.Update();
            }
        }
    }
}
