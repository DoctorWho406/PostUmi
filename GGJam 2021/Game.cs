using Aiv.Fast2D;

namespace GGJam_2021 {
    static class Game {
        public static float DeltaTime => Window.DeltaTime;

        private static Window Window;

        public static void Init() {
            //Init Window
            Window = new Window(1920, 1080, "GGJam 2021", true);
            //Disable VSync
            Window.SetVSync(false);
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
