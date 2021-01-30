﻿using OpenTK;

namespace GGJam_2021 {
    static class Constants {
        //General
        public const Scene StartingScene = Scene.Room;

        //Textures directory
        public const string TextureDirectory = "Assets/Textures/";
        public const string BackgroundDirectory = "Assets/Textures/Background/";
        public const string InteractableObjectDirectory = "Assets/Textures/InteractableObject/";
        public const string ItemsDirectory = "Assets/Textures/InteractableObject/Items/";

        /** ENUM
         * Enum Scene in SceneManager
         * Enum CollidersType in Collider
         * Enum LayerMask in GameObject
         **/
        //GameObject
        public const float GlitchTime = 0.5f;
        public static Vector4 tintaBlue = new Vector4(1, 1, 20, 1);
        public static Vector4 tintaGialla = new Vector4(1, 10, 10, 1);

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
        public const int FPSPlayerAnimation = 5;
    }
}