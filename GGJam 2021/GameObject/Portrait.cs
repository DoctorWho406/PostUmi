using OpenTK;

namespace GGJam_2021 {
    class Portrait : ChangeSceneObject {
        private Animation animation;
        private Scene scene;

        private Vector2 textureOffset;
        private bool isAnimated;

        public Portrait(string textureName, LayerMask layerMask, Scene scene, Scene nextScene, ColliderType colliderType, int fotogrammi = 0, int w = 0, int h = 0, ) : base(textureName, layerMask, scene, nextScene, colliderType, w, h) {
            if (fotogrammi == 0) {
                animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, fotogrammi, false);
            }
        }

        public override void Update() {
            base.Update();
            if (animation != null) {
                animation.Update(ref textureOffset);
                if (SceneManager.ActiveScene == scene) {
                    animation.Play();
                    isAnimated = true;
                }
                if (isAnimated && !animation.IsPlaying) {
                    animation.Stop(ref textureOffset);
                    isAnimated = false;
                }
            }
            if (IsClicked()) {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
