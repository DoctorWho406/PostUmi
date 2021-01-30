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
        }

        public static void Update() {
            if (IsActive) {
                int elementi = (int)((1 - Paranoia) / intervalli);
                if (elementi < ) {
                    //int offset = 0, index = -1;
                    if (elementi != 0) {
                        //offset = (int)(Constants.ParanoiaMax / elementi);
                        for (int i = offset - 1; i < scenes[activeScene].Count; i += offset) {
                            scenes[activeScene][i].Glitch();
                        }
                    }
                }
                //Decrese hungry and paranoia
                Hunger -= Constants.HungerDecrease * Game.DeltaTime;
                Paranoia -= Constants.ParanoiaDecrease * Game.DeltaTime;

                //Update Slider
                paranoiaSlider.Update();
                hungherSlider.Update();
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
