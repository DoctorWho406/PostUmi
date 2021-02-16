using System.Collections.Generic;

namespace GGJam_2021 {
    static class UpdateManager {
        private static List<IUpdatable> items;

        static UpdateManager() {
            items = new List<IUpdatable>();
        }

        public static void AddItem(IUpdatable item) {
            items.Add(item);
        }

        public static void RemoveItem(IUpdatable item) {
            items.Remove(item);
        }

        public static void ClearAll() {
            items.Clear();
        }

        public static void Update() {
            //update all items
            for (int i = 0; i < items.Count; i++) {
                items[i].Update();
            }
        }
    }
}
