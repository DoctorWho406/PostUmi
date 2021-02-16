using OpenTK;

namespace GGJam_2021 {
    class Door : ChangeSceneObject {
        public Vector2 positionPlayer;

        protected Animation animation;
        private Vector2 textureOffset;
        private bool readyForChange;

        private Door nextDoor;

        public Door(string texturName, Scene actualScene, Scene nextScene, Vector2 positionPlayer, int w = 0, bool Flip = false, LayerMask layerMask = LayerMask.Background) : base(texturName, layerMask, actualScene, nextScene, ColliderType.BoxCollider, w) {
            sprite.FlipX = Flip;
            spriteGlitch1.FlipX = Flip;
            spriteGlitch2.FlipX = Flip;
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
            this.positionPlayer = positionPlayer;
        }

        public void SetNextDoor(Door nxtDoor) {
            nextDoor = nxtDoor;
        }

        public override void Update() {
            animation.Update(ref textureOffset);
            base.Update();
            if (IsNearAndClicked() && !animation.IsPlaying) {
                animation.Play();
                readyForChange = true;
            }
            if (animation.IsPlaying) {
                Game.Player.SetIsActive(false);
            }
            if (readyForChange && !animation.IsPlaying) {
                Game.Player.SetIsActive(true);
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
