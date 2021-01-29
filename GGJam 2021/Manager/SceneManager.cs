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

        static SceneManager() {
            scenes = new Dictionary<Scene, List<GameObject>>();
            for (int s = 0; s < (int)Scene.Count; s++) {
                scenes[(Scene)s] = new List<GameObject>();
            }
        }

        public static void AddGOToScene(Scene room, GameObject gameObject) {
            scenes[room].Add(gameObject);
        }

        public static void LoadScene(Scene Scene) {
            activeScene = Scene;
        }

        public static void Draw() {

            foreach (GameObject gameObject in scenes[activeScene]) {
                gameObject.Draw();
            }
        }
    }

}
