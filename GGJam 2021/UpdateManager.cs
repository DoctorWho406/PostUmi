using System.Collections.Generic;

namespace GGJam_2021 {
    static class UpdateManager {
        private static List<GameObject> gameObjects;

        static UpdateManager() {
            gameObjects = new List<GameObject>();
        }

        public static void AddItem(GameObject gameObject) {
            gameObjects.Add(gameObject);
        }

        public static void Update() {
            for (int i = 0; i < gameObjects.Count; i++) {
                gameObjects[i].Update();
            }
        }
    }
}
