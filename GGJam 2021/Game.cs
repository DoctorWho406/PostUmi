using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    static class Game
    {
        public static Window Window;
        public static Vector2 WindowCenter
        {
            get; private set;
        }
        public static float DeltaTime => Window.DeltaTime;
        public static Player Player;
        private static Cursor cursor;
        private static Background background;

        public static void Init()
        {
            //Init Window
            Window = new Window(/*1920, 1080,*/ "GGJam 2021"/*, true*/);
            //Disable VSync
            Window.SetVSync(false);
            //Set WindowCenter
            WindowCenter = new Vector2(Window.Width * 0.5f, Window.Height * 0.5f);
            LoadAssets();

            //Edit cursor
            cursor = new Cursor();
            Window.SetMouseVisible(false);

            background = new Background();
            Player = new Player(WindowCenter, new Vector2(30));
        }

        private static void LoadAssets()
        {
            //AddTexture
            TextureManager.AddTexture("corridoio", Constants.TextureDirectory + "corridoio.png");
            TextureManager.AddTexture("soggiorno", Constants.TextureDirectory + "soggiorno.png");
            TextureManager.AddTexture("stanza", Constants.TextureDirectory + "stanza.png");
            TextureManager.AddTexture("Pngcucina", Constants.TextureDirectory + "Pngcucina.png");
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "player.png");
            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursore di prova.jpg");
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

                Player.Input();

                cursor.Update();
                Player.Update();
                background.Update();

                background.Draw();
                Player.Draw();
                cursor.Draw();

                Window.Update();
            }
        }
    }
}
