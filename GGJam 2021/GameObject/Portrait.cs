using OpenTK;


namespace GGJam_2021 {
    class Portrait : ChangeSceneObject {
        private Animation animation;
        private Vector2 textureOffset;
        private bool isAnimated;
        public bool isOpened {
            get; private set;
        }

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
                if (animation == null) {
                    if (InteractableObjectManager.CanOpenIt(this)) {
                        SceneManager.LoadScene(nextScene);
                        Game.ObjectTaken++;
                        isOpened = true;
                    }
                } else {
                    SceneManager.LoadScene(nextScene);
                    Game.ObjectTaken++;
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

