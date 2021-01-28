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
        private static Cursor cur;


        public static void Init() {
            //Init Window
            Window = new Window(1920, 1080, "GGJam 2021", true);
            //Disable VSync
            Window.SetVSync(false);
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            LoadAssets();
            player = new Player(WindowCenter, new Vector2(30));
            cur = new Cursor();
        }

        private static void LoadAssets() {
            //AddTexture
            TextureManager.AddTexture("Background", Constants.TextureDirectory + "Background.png");
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "Player.png");
            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursore di prova.jpg");
        }

        public static void Play() {
            while (Window.IsOpened) {
                //Exit on esc
                if (Window.GetKey(KeyCode.Esc)) {
                    break;
                }

                player.Input();
                cur.Update();
                player.Update();
                cur.Draw();
                player.Draw();
                Window.Update();
            }
        }
    }
}
