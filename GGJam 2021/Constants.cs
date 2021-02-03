using OpenTK;

namespace GGJam_2021 {
    static class Constants {
        //General
        public const Scene StartingScene = Scene.Menu;

        //Textures directory
        public const string TextureDirectory = "Assets/Textures/";
        public const string DialogueDirectory = "Assets/Textures/Dialogue/";
        public const string BackgroundDirectory = "Assets/Textures/Background/";
        public const string ItemsDirectory = "Assets/Textures/InteractableObject/Items/";
        public const string CollidableObjectDirectory = "Assets/Textures/CollidableObject/";
        public const string InteractableObjectDirectory = "Assets/Textures/InteractableObject/";
        public const string PortraitSpriteSheetDirectory = "Assets/Textures/PortraitSpriteSheet/";
        public const string AudioClipsDirectory = "Assets/AudioClips/";
        public const string SplashScreenDirectory = "Assets/Textures/SplashScreen/";

        /** ENUM
         * Enum Scene in SceneManager
         * Enum CollidersType in Collider
         * Enum LayerMask in GameObject
         **/

        //GameObject
        public const float GlitchTime = 0.5f;
        public static Vector4 tintaBlue = new Vector4(1, 1, 20, 1);
        public static Vector4 tintaGialla = new Vector4(1, 10, 10, 1);

        //Door 
        public const int FPSDoorAnimation = 5;

        //InteractableObject
        public const float TriggerColliderOffset = 350;

        //Portrait
        public const float ParanoiaValue = 15;

        //Fridge
        public const float HungerFromFridge = 25;

        //Player
        public const float PlayerSpeed = 250f;
        public const float HungerMax = 250f;
        public const float HungerDecrease = 2f;
        public const float ParanoiaMax = 250f;
        public const float ParanoiaDecrease = 1f;
        public const float OffsetFromTarge = 10f;
        public const int FPSPlayerAnimation = 5;

        //Slider
        public const int SliderHeight = 50;
    }
}