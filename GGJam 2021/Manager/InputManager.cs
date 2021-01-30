using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021 {
    static class InputManager {
        private static bool isTriggerButtonClicked;

        static InputManager() {
            isTriggerButtonClicked = false;
        }

        public static bool IsTriggerClicked() {
            if (Game.Window.MouseRight) {
                if (!isTriggerButtonClicked) {
                    isTriggerButtonClicked = true;
                    return true;
                }
            } else {
                isTriggerButtonClicked = false;
            }
            return false;
        }
    }
}
