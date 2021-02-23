using System;
using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    static class Game {
        public static Random Random {
            get; private set;
        }
        public static Window Window {
            get; private set;
        }
        public static Vector2 WindowCenter {
            get; private set;
        }
        public static float DeltaTime => Window.DeltaTime;
        public static Player Player;
        public static Cursor Cursor;

        public static void Init() {
            //Init Random
            Random = new Random();
            //Init Window
            Window = new Window(1920, 1080, "GGJam 2021", true);
            //Disable VSync
            Window.SetVSync(false);
            //Set WindowCenter
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            TextureInitManager.Start();
            AudioClipInitManager.Start();
            Player = new Player() {
                //IsActive = true,
                //IsVisible = true,
            };
            Player.Scale(0.35f);
            SceneInitManager.Start();
            //Edit cursor
            Cursor = new Cursor();
            Cursor.Scale(0.2f);
            Window.SetMouseVisible(false);
            MusicManager.Start();
        }

        public static void Play() {
            while (Window.IsOpened) {
                //Exit on esc
                //Console.WriteLine(Window.MousePosition);
                if (Window.GetKey(KeyCode.Esc)/* || !Player.isAlive*/) {
                    break;
                }
                if (SceneManager.ActiveScene != Scene.BadEndGame && !StatsManager.PlayerIsAlive) {
                    SceneManager.LoadScene(Scene.BadEndGame);
                }

                Player.Input();

                SceneManager.Update();
                MusicManager.Update();

                SceneManager.Draw();

                Window.Update();
            }
        }
    }
}
