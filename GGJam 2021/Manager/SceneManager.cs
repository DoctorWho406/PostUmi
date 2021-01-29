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
        private static Dictionary<Scene, List</*da definire*/>> scenes;

        static SceneManager() {
            scenes = new Dictionary<Scene, List</*da definire*/>>();
            for (int s = 0; s < (int)Scene.Count; s++) {
                scenes[(Scene)s] = new List</*da definire*/>();
            }
        }

        public static void AddtoScene(Scene room, /*da definire*/) {
            scenes[room].Add(/*da definire*/);
        }

        public static void LoadScene(Scene Scene) {
            activeScene = Scene;
        }

        public static void Draw() {
            foreach (/*da definire*/ in scenes[activeScene]) {
                /*da definire*/.Draw();
            }
        }
    }

}
