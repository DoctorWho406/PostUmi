using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    static class Game {
        public static Window Window;
        public static float DeltaTime => Window.DeltaTime;
        public static Vector2 WindowCenter {
            get; private set;
        }

        private static Player player;

        public static void Init() {
            //Init Window
            Window = new Window(1920, 1080, "GGJam 2021", true);
            //Disable VSync
            Window.SetVSync(false);
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            LoadAssets();
            player = new Player(WindowCenter, new Vector2(30));
        }

        private static void LoadAssets() {
            //AddTexture
            TextureManager.AddTexture("Background", Constants.TextureDirectory + "Background.png");
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "Player.png");
        }

        public static void Play() {
            while (Window.IsOpened) {
                //Exit on esc
                if (Window.GetKey(KeyCode.Esc)) {
                    break;
                }
                player.Input();
                UpdateManager.Update();
                DrawManager.Draw();
                Window.Update();
            }
        }
    }
}
