﻿namespace GGJam_2021 {
    static class Constants {
        //General
        public const Scene StartingScene = Scene.Room;

        //Textures directory
        public const string TextureDirectory = "Assets/Textures/";
        public const string BackgroundDirectory = "Assets/Textures/Background/";
        public const string InteractableObjectDirectory = "Assets/Textures/InteractableObject/";

        /** ENUM
         * Enum Scene in SceneManager
         * Enum CollidersType in Collider
         * Enum LayerMask in GameObject
         **/

        //InteractableObject
        public const float TriggerColliderOffset = 10;

        //Door 
        public const int FPSDoorAnimation = 5;

        //Player
        public const float PlayerSpeed = 250f;
        public const float HungerMax = 100f;
        public const float HungerDecrease = 0.1f;
        public const float ParanoiaMax = 100f;
        public const float ParanoiaDecrease = 0.05f;
        public const float OffsetFromTarge = 10f;
    }
}