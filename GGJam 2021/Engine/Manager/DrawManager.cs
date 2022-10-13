using System.Collections.Generic;

namespace GGJam_2021 {
    static class DrawManager {
        private static List<IDrawable> items;

        static DrawManager() {
            items = new List<IDrawable>();
        }

        public static void AddItem(IDrawable item) {
            items.Add(item);
        }

        public static void RemoveItem(IDrawable item) {
            items.Remove(item);
        }

        public static void ClearAll() {
            items.Clear();
        }

        public static void Draw() {
            //update all items
            for (int i = 0; i < items.Count; i++) {
                items[i].Draw();
            }
        }
    }
}
