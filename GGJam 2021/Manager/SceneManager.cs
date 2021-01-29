using System.Collections.Generic;

namespace GGJam_2021 {
    enum Scene {
        Soggiorno,
        Stanza,
        Corridoio,
        Count
    }

    static class SceneManager {
        private static Scene activeScene;
        private static Dictionary<Scene, List<GameObject>> scenes;
        private static bool isSceneChanging;

        private static float stacchi;

        static SceneManager() {
            stacchi = 1 / Constants.ParanoiaMax;
            isSceneChanging = false;
            activeScene = Scene.Stanza;
            scenes = new Dictionary<Scene, List<GameObject>>();
            for (int s = 0; s < (int)Scene.Count; s++) {
                scenes[(Scene)s] = new List<GameObject>();
            }
        }

        public static void AddGOToScene(Scene room, GameObject gameObject) {
            scenes[room].Add(gameObject);
        }

        public static void LoadScene(Scene Scene) {
            isSceneChanging = true;
            if (scenes[activeScene].Contains(Game.Player)) {
                scenes[activeScene].Remove(Game.Player);
            }
            activeScene = Scene;
            scenes[activeScene].Add(Game.Player);
            isSceneChanging = false;
        }

        public static void Update() {
            if (!isSceneChanging) {
                for (int i = 0; i < scenes[activeScene].Count; i++) {
                    scenes[activeScene][i].Update();
                }
            }
        }

        public static void Draw() {
            int elementi = (int)((1 - Game.Player.Paranoia) / stacchi);
            int offset = 0, index = -1;
            if (elementi != 0) {
                offset = (int)(Constants.ParanoiaMax / elementi);
                for (int i = offset -1 ; i < scenes[activeScene].Count; i+= offset) {
                        scenes[activeScene][i].Glitch();
                }
            }
            if (!isSceneChanging) {
                for (int i = 0; i < scenes[activeScene].Count; i++) {
                    scenes[activeScene][i].Draw();
                }
            }
        }
    }

}
