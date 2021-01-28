using System.Collections.Generic;

namespace GGJam_2021 {
    static class DrawManager {
        private static List<Object> objects;

        static DrawManager() {
            objects = new List<Object>();
        }

        public static void AddItem(Object obj) {
            objects.Add(obj);
        }

        public static void Draw() {
            for (int i = 0; i < objects.Count; i++) {
                objects[i].Draw();
            }
        }
    }
}
