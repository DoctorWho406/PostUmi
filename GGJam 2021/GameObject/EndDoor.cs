using OpenTK;

namespace GGJam_2021 {
    class EndDoor : ChangeSceneObject {
        protected Animation animation;
        private Vector2 textureOffset;
        private bool readyForChange;

        public EndDoor(int w = 0) : base("EndDoor", LayerMask.Background, Scene.AnteroomExit, Scene.GoodEndGame, ColliderType.BoxCollider, w) {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
        }

        public override void SetGlitch(bool value) {
        }

        public override void Update() {
            animation.Update(ref textureOffset);
            base.Update();
            if (MusicManager.ObjectTaken == InteractableObjectManager.orderList.Count) {
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
                    SceneManager.LoadScene(nextScene);
                }
            }
        }

        public override void Draw() {
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
        }
    }
}
