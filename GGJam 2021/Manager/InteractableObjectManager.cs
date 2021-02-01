using System.Collections.Generic;

namespace GGJam_2021 {
    static class InteractableObjectManager {
        private static Dictionary<Portrait, Portrait> orderList;

        static InteractableObjectManager() {
            orderList = new Dictionary<Portrait, Portrait>();
        }

        public static void AddPortarait(Portrait key, Portrait needed) {
            orderList[key] = needed;
        }

        public static bool CanOpenIt(Portrait key) {
            if (orderList.ContainsKey(key)) {
                if (orderList[key] == null) {
                    return true;
                }
                if (orderList[key].isOpened) {
                    return true;
                }
            }
            return false;
        }
    }
}
