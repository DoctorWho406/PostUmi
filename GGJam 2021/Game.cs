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

        private static Sprite doorSprite;

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
            LoadAssets();
            LoadBackground();

            //Edit cursor
            Cursor = new Cursor();
            Window.SetMouseVisible(false);

            //background = new Background();
            Player = new Player() {
                Position = Game.WindowCenter
            };
        }

        private static void LoadBackground() {
            new Background("room", Scene.Stanza) {
                Position = Game.WindowCenter
            };
            new Door("Empty", Scene.Stanza, Scene.Corridoio) {
                Position = Game.WindowCenter
            };
            new Door("Empty", Scene.Corridoio, Scene.Stanza) {
                Position = Game.WindowCenter
            };
            doorSprite = new Sprite(50, 50) {
                position = Game.WindowCenter
            };
            new Background("salone", Scene.Corridoio) {
                Position = Game.WindowCenter
            };
        }

        private static void LoadAssets() {
            //AddTexture
            TextureManager.AddTexture("room", Constants.BackgroundDirectory + "room_prova.png");
            TextureManager.AddTexture("salone", Constants.BackgroundDirectory + "salone_prova.png");

            TextureManager.AddTexture("corridoio", Constants.TextureDirectory + "corridoio.png");
            TextureManager.AddTexture("soggiorno", Constants.TextureDirectory + "soggiorno.png");
            TextureManager.AddTexture("stanza", Constants.TextureDirectory + "stanza.png");
            TextureManager.AddTexture("Pngcucina", Constants.TextureDirectory + "Pngcucina.png");
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "player.png");
            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursore di prova.jpg");
            TextureManager.AddTexture("Empty", Constants.TextureDirectory + "Empty.png");
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
                doorSprite.DrawColor(new Vector4(255, 0, 0, 255));
                //Player.Draw();
                Cursor.Draw();

                Window.Update();
            }
        }
    }
}
