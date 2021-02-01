using OpenTK;

namespace GGJam_2021 {
    class Door : ChangeSceneObject {
        public Vector2 positionPlayer;

        protected Animation animation;

        private Vector2 textureOffset;
        private bool readyForChange;

        private Door nextDoor;

        public Door(string texturName, Scene actualScene, Scene nextScene, Door nextDoor, Vector2 positionPlayer) : base(texturName, LayerMask.Background, actualScene, nextScene, ColliderType.BoxCollider, 390, 0) {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
            this.positionPlayer = positionPlayer;
            this.nextDoor = nextDoor;
        }

        public override void Update() {
            animation.Update(ref textureOffset);
            base.Update();
            if (IsClicked() && !animation.IsPlaying) {
                animation.Play();
                readyForChange = true;
            }
            if (animation.IsPlaying) {
                Game.Player.IsActive = false;
            }
            if (readyForChange && !animation.IsPlaying) {
                Game.Player.IsActive = true;
                animation.Stop(ref textureOffset);
                readyForChange = false;
                SceneManager.LoadScene(nextScene, nextDoor.positionPlayer);

            }
        }

        public override void Draw() {
            if (!glitch) {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            } else {
                if (glithched) {
                    spriteGlitch1.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                } else {
                    spriteGlitch2.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
            }
        }
    }
}
