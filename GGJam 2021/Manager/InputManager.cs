namespace GGJam_2021 {
    static class InputManager {
        private static bool isTriggerButtonClicked;

        static InputManager() {
            isTriggerButtonClicked = false;
        }

        public static void Update() {
            if (Game.Window.MouseRight) {
                if (!isTriggerButtonClicked) {
                    isTriggerButtonClicked = true;
                }
            } else {
                isTriggerButtonClicked = false;
            }

        }

        public static bool IsTriggerClicked() {
            if (Game.Window.MouseRight) {
                return !isTriggerButtonClicked;
            }
            return false;
        }
    }
}
