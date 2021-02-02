using OpenTK;


namespace GGJam_2021 {
    class Portrait : ChangeSceneObject {
        public bool isOpened {
            get; set;
        }

        private Animation animation;
        private Vector2 textureOffset;

        public Portrait(string textureName, LayerMask layerMask, Scene scene, Scene nextScene, ColliderType colliderType, int fotogrammi = 0, int fps = 0, int w = 0, int h = 0) : base(textureName, layerMask, scene, nextScene, colliderType, w, h) {
            textureOffset = Vector2.Zero;
            isOpened = false;
            if (fotogrammi == 0) {
                animation = null;
            } else {
                animation = new Animation((int)sprite.Width, (int)sprite.Height, fps, fotogrammi, true);
            }
        }

        public override void SetGlitch(bool value) {
            if (animation == null) {
                base.SetGlitch(value);
            }
        }

        public override void Update() {
            base.Update();
            if (animation != null) {
                if (IsClicked()) {
                    SceneManager.LoadScene(nextScene);
                }
                animation.Update(ref textureOffset);
                if (SceneManager.ActiveScene == scene) {
                    animation.Play();
                }
            } else if (IsNearAndClicked()) {
                if (InteractableObjectManager.CanOpenIt(this)) {
                    SceneManager.LoadScene(nextScene);
                    if (!isOpened) {
                        MusicManager.ObjectTaken++;
                    }
                    isOpened = true;
                }

            }
        }
        public override void Draw() {
            if (animation != null) {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            } else {
                base.Draw();
            }
        }
    }
}

