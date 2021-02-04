﻿using System.Collections.Generic;
using OpenTK;

namespace GGJam_2021 {

    enum Stat {
        Hunger,
        Paranoia,
        Count
    }

    static class StatsManager {
        public static float Hunger {
            get; private set;
        }
        public static float Paranoia {
            get; private set;
        }

        public static bool PlayerIsAlive => Hunger > 0 && Paranoia > 0;

        private static List<GameObject> glitchedGameObject;

        private static Slider paranoiaSlider, hungherSlider;

        static StatsManager() {
            Hunger = Constants.HungerMax;
            Paranoia = Constants.ParanoiaMax;
            paranoiaSlider = new Slider(new Vector2(Game.Window.Width - 25 - Constants.ParanoiaMax, Game.Window.Height - 25 - Constants.SliderHeight), Stat.Paranoia);
            hungherSlider = new Slider(new Vector2(25, Game.Window.Height - 25 - Constants.SliderHeight), Stat.Hunger);

            glitchedGameObject = new List<GameObject>();

        }

        public static void Reset() {
            Hunger = Constants.HungerMax;
            Paranoia = Constants.ParanoiaMax;
        }

        public static void LoadScene() {
            for (int i = 0; i < glitchedGameObject.Count; i++) {
                glitchedGameObject[i].SetGlitch(false);
            }
            glitchedGameObject.Clear();
        }


        public static void Update() {
            if (Game.Player.IsActive && !SceneManager.IsSceneChanging) {
                //Decrese hungry and paranoia
                Hunger -= Constants.HungerDecrease * Game.DeltaTime;
                Paranoia -= Constants.ParanoiaDecrease * Game.DeltaTime;

                //Update Slider
                paranoiaSlider.Update();
                hungherSlider.Update();
                List<GameObject> activeGameObjects = SceneManager.GetActiveObject();
                int elementi = (int)((1 - (Paranoia / Constants.ParanoiaMax)) * activeGameObjects.Count);
                //if (Paranoia >= 0) {
                //    System.Console.WriteLine($"Paranoia {Paranoia} -> Elementi {elementi}");
                //}
                if (elementi < glitchedGameObject.Count) {
                    //Remove
                    int itemToRelase = glitchedGameObject.Count - elementi;
                    for (int i = 0; i < itemToRelase; i++) {
                        int index = Game.Random.Next(0, glitchedGameObject.Count);
                        glitchedGameObject[index].SetGlitch(false);
                        glitchedGameObject.RemoveAt(index);
                    }
                } else if (elementi > glitchedGameObject.Count) {
                    //Add
                    if (elementi != 0) {
                        int itemToAdd = elementi - glitchedGameObject.Count;
                        for (int i = 0; i < itemToAdd; i++) {
                            int index;
                            do {
                                index = Game.Random.Next(0, activeGameObjects.Count);
                            } while (activeGameObjects[index].GetGlitch());
                            activeGameObjects[index].SetGlitch(true);
                            glitchedGameObject.Add(activeGameObjects[index]);
                        }
                    }
                }
            }
        }


        public static void AddStats(float value, Stat stat) {
            switch (stat) {
                case Stat.Hunger:
                    Hunger += value;
                    if (Hunger > Constants.HungerMax) {
                        Hunger = Constants.HungerMax;
                    }
                    break;
                case Stat.Paranoia:
                    Paranoia += value;
                    if (Paranoia > Constants.ParanoiaMax) {
                        Paranoia = Constants.ParanoiaMax;
                    }
                    break;
            }
        }

        public static void Draw() {
            //Draw Slider
            if ((SceneManager.ActiveScene != Scene.DialogueAlbum)
                && (SceneManager.ActiveScene != Scene.Menu)
                && (SceneManager.ActiveScene != Scene.DialogueAlcol)
                && (SceneManager.ActiveScene != Scene.DialogueBloccoDisegni)
                && (SceneManager.ActiveScene != Scene.DialogueBordello)
                && (SceneManager.ActiveScene != Scene.DialogueChitarra)
                && (SceneManager.ActiveScene != Scene.DialogueComputer)
                && (SceneManager.ActiveScene != Scene.DialogueDino)
                && (SceneManager.ActiveScene != Scene.DialogueFoto)
                && (SceneManager.ActiveScene != Scene.DialogueVomito)
                && (SceneManager.ActiveScene != Scene.BadEndGame)
                && (SceneManager.ActiveScene != Scene.GoodEndGame)
                && (SceneManager.ActiveScene != Scene.DialogueInit_1)
                && (SceneManager.ActiveScene != Scene.DialogueInit_2)
                && (SceneManager.ActiveScene != Scene.DialogueInit_3)) {
                paranoiaSlider.Draw();
                hungherSlider.Draw();
            }
        }
    }
}