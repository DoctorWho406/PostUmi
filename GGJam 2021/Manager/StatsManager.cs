using System.Collections.Generic;
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
        public static bool IsActive;

        private static List<GameObject> glitchedGameObject;

        private static float intervalli;
        private static Slider paranoiaSlider, hungherSlider;

        static StatsManager() {
            Hunger = 1f;
            Paranoia = 1f;
            paranoiaSlider = new Slider(new Vector2(25), Stat.Paranoia);
            hungherSlider = new Slider(new Vector2(25, Game.Window.Height - 75), Stat.Hunger);

            intervalli = 1 / Constants.ParanoiaMax;
            glitchedGameObject = new List<GameObject>();
            IsActive = true;
        }

        public static void LoadScene() {
            for (int i = 0; i < glitchedGameObject.Count; i++) {
                glitchedGameObject[i].Glitch(false);
            }
            glitchedGameObject.Clear();
        }


        public static void Update() {
            if (IsActive && !SceneManager.IsSceneChanging) {
                //Decrese hungry and paranoia
                Hunger -= Constants.HungerDecrease * Game.DeltaTime;
                Paranoia -= Constants.ParanoiaDecrease * Game.DeltaTime;

                //Update Slider
                paranoiaSlider.Update();
                hungherSlider.Update();
                int elementi = (int)((1 - Paranoia) / intervalli);
                if (elementi < glitchedGameObject.Count) {
                    //remove
                    int itemToRelase = glitchedGameObject.Count - elementi;
                    for (int i = 0; i < itemToRelase; i++) {
                        int index = Game.Random.Next(0, glitchedGameObject.Count);
                        glitchedGameObject[index].Glitch(false);
                        glitchedGameObject.RemoveAt(index);
                    }
                } else if (elementi > glitchedGameObject.Count) {
                    //Add
                    if (elementi != 0) {
                        int itemToAdd = elementi - glitchedGameObject.Count;
                        List<GameObject> activeGameObjects = SceneManager.GetActiveObject();
                        for (int i = 0; i < itemToAdd; i++) {
                            int index = Game.Random.Next(0, activeGameObjects.Count);
                            activeGameObjects[index].Glitch(true);
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
                    break;
                case Stat.Paranoia:
                    Paranoia += value;
                    break;
            }
        }

        public static void Draw() {
            //Draw Slider
            paranoiaSlider.Draw();
            hungherSlider.Draw();
        }
    }
}