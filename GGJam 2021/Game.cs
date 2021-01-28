using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    static class Game
    {
        public static Window Window;
        public static float DeltaTime => Window.DeltaTime;
        public static Vector2 WindowCenter
        {
            get; private set;
        }
        public static Player Player;

        private static Cursor cur;
        private static Background background;

        public static void Init()
        {
            //Init Window
            Window = new Window(/*1920, 1080,*/ "GGJam 2021"/*, false*/);

            //foreach(string device in Window.Displays)
            //{
            //    System.Console.WriteLine(device);
            //}
          
            //Disable VSync
            Window.SetVSync(false);
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            LoadAssets();
            Player = new Player(WindowCenter, new Vector2(30));
            cur = new Cursor();
            Window.SetMouseVisible(false);
            background = new Background();
        }

        private static void LoadAssets()
        {
            //AddTexture
            TextureManager.AddTexture("Background", Constants.TextureDirectory + "Background.png");
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "player.png");
            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursore di prova.jpg");
        }

        public static void Play()
        {
            while (Window.IsOpened)
            {
                //Exit on esc
                if (Window.GetKey(KeyCode.Esc)||!Player.isAlive)
                {
                    break;
                }
                
                Player.Input();

                cur.Update();
                Player.Update();

                background.Draw();
                Player.Draw();
                cur.Draw();

                Window.Update();
            }
        }
    }
}
