namespace GGJam_2021 {
    static class Constants {
        //Textures directory
        public const string TextureDirectory = "Assets/Textures/";
        public const string BackgroundDirectory = "Assets/Textures/Background/";

        /** ENUM
         * Enum Scene in SceneManager
         * Enum CollidersType in Collider
         **/

        //InteractableObject
        public const float TriggerColliderOffset = 10;

        //Player
        public const float PlayerSpeed = 250f;
        public const float HungerMax = 100f;
        public const float HungerDecrease = 0.1f;
        public const float ParanoiaMax = 100f;
        public const float ParanoiaDecrease = 0.05f;
        public const float OffsetFromTarge = 10f;
    }
}