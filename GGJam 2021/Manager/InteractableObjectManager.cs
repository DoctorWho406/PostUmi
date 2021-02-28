using System.Collections.Generic;

namespace GGJam_2021 {
    static class InteractableObjectManager {
        public static Dictionary<Portrait, Portrait> orderList {
            get; private set;
        }

        static InteractableObjectManager() {
            orderList = new Dictionary<Portrait, Portrait>();
        }

        public static void Reset() {
            foreach (KeyValuePair<Portrait, Portrait> item in orderList) {
                item.Key.IsOpened = false;
            }
        }

        public static void AddPortarait(Portrait key, Portrait needed) {
            orderList[key] = needed;
        }

        public static bool CanOpenIt(Portrait key) {
            if (orderList.ContainsKey(key)) {
                if (orderList[key] == null) {
                    return true;
                }
                if (orderList[key].IsOpened) {
                    return true;
                }
            }
            return false;
        }
    }
}
