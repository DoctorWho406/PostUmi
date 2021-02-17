using System.Collections.Generic;
using OpenTK;

namespace GGJam_2021 {

    enum Stats {
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

        private static Queue<GlitchableObject> glitchableObjects;
        private static Stack<GlitchableObject> glitchedObjects;

        private static ProgressBar paranoiaSlider, hungherSlider;

        static StatsManager() {
            Hunger = Constants.HungerMax;
            Paranoia = Constants.ParanoiaMax;
            paranoiaSlider = new ProgressBar("Paranoia", "TODO", new Vector2(20)) {
                Position = new Vector2(Game.Window.Width - 25 - Constants.ParanoiaMax, Game.Window.Height - 25 - Constants.SliderHeight)
            };
            hungherSlider = new ProgressBar("Hungher", "TODO", new Vector2(20)) {
                Position = new Vector2(25, Game.Window.Height - 25 - Constants.SliderHeight)
            };

            glitchableObjects = new Queue<GlitchableObject>();
            glitchedObjects = new Stack<GlitchableObject>();
        }

        public static void AddGlitcableObject(GlitchableObject item) {
            glitchableObjects.Enqueue(item);
        }

        public static void Reset() {
            Hunger = Constants.HungerMax;
            hungherSlider.Scale(1);
            Paranoia = Constants.ParanoiaMax;
            paranoiaSlider.Scale(1);
        }

        //public static void LoadScene() {
        //    for (int i = 0; i < glitchedGameObject.Count; i++) {
        //        glitchedGameObject[i].SetGlitch(false);
        //    }
        //    glitchedGameObject.Clear();
        //}

        public static void Update() {
            //if (Game.Player.IsActive && !SceneManager.IsSceneChanging) {
            //Decrese hungry and paranoia
            Hunger -= Constants.HungerDecrease * Game.DeltaTime;
            Paranoia -= Constants.ParanoiaDecrease * Game.DeltaTime;

            //Update Slider
            paranoiaSlider.Scale(Paranoia);
            hungherSlider.Scale(Hunger);

            int elementi = (int)((1 - Paranoia) * (glitchableObjects.Count + glitchedObjects.Count));
            //if (Paranoia >= 0) {
            //    System.Console.WriteLine($"Paranoia {Paranoia} -> Elementi {elementi}");
            //}
            if (elementi < glitchedObjects.Count) {
                //Remove
                int itemToRelase = glitchedObjects.Count - elementi;
                for (int i = 0; i < itemToRelase; i++) {
                    GlitchableObject glitchableObject = glitchedObjects.Pop();
                    glitchableObject.SetGlitch(false);
                    glitchableObjects.Enqueue(glitchableObject);
                }
            } else if (elementi > glitchedObjects.Count) {
                //Add
                int itemToAdd = elementi - glitchedObjects.Count;
                for (int i = 0; i < itemToAdd; i++) {
                    GlitchableObject glitchableObject = glitchableObjects.Dequeue();
                    glitchableObject.SetGlitch(true);
                    glitchedObjects.Push(glitchableObject);
                }
            }
            //}
        }

        public static void AddStats(float value, Stats stat) {
            value = MathHelper.Clamp(value, -1, 1);

            switch (stat) {
                case Stats.Hunger:
                    Hunger += value;
                    if (Hunger > Constants.HungerMax) {
                        Hunger = Constants.HungerMax;
                    }
                    break;
                case Stats.Paranoia:
                    Paranoia += value;
                    if (Paranoia > Constants.ParanoiaMax) {
                        Paranoia = Constants.ParanoiaMax;
                    }
                    break;
            }
        }

        public static void Draw() {
            //Draw Slider
            //if ((SceneManager.ActiveScene != Scene.DialogueAlbum) && (SceneManager.ActiveScene != Scene.Menu) && (SceneManager.ActiveScene != Scene.DialogueAlcol)&& (SceneManager.ActiveScene != Scene.DialogueBloccoDisegni) && (SceneManager.ActiveScene != Scene.DialogueBordello) && (SceneManager.ActiveScene != Scene.DialogueChitarra) && (SceneManager.ActiveScene != Scene.DialogueComputer)                 && (SceneManager.ActiveScene != Scene.DialogueDino)                 && (SceneManager.ActiveScene != Scene.DialogueFoto) && (SceneManager.ActiveScene != Scene.DialogueVomito)                 && (SceneManager.ActiveScene != Scene.BadEndGame) && (SceneManager.ActiveScene != Scene.GoodEndGame) & (SceneManager.ActiveScene != Scene.DialogueInit_1) && (SceneManager.ActiveScene != Scene.DialogueInit_2)                 && (SceneManager.ActiveScene != Scene.DialogueInit_3)) {
                paranoiaSlider.Draw();
                hungherSlider.Draw();
            //}
        }
    }
}