using Aiv.Fast2D;

namespace GGJam_2021 {
    static class Game {
        public static Window Window;
        public static float DeltaTime => Window.DeltaTime;

        public static void Init() {
            //Init Window
            Window = new Window(1920, 1080, "GGJam 2021", true);
            //Disable VSync
            Window.SetVSync(false);
            LoadAssets();
        }

        private static void LoadAssets() {
            //AddTexture
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "Player.png");
        }

        public static void Play() {
            while (Window.IsOpened) {
                //Exit on esc
                if (Window.GetKey(KeyCode.Esc)) {
                    break;
                }
                Window.Update();
            }
        }
    }
}
