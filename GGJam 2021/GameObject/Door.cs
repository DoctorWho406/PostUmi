using OpenTK;

namespace GGJam_2021 {
    class Door : ChangeSceneObject
    {
        protected Animation animation;

        private Vector2 textureOffset;
        private bool readyForChange;

        public Door(Scene actualScene, Scene nextScene) : base("FrontDoor", LayerMask.Background, actualScene, nextScene, ColliderType.BoxCollider, 390, 0)
        {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
        }

        public override void Update()
        {
            animation.Update(ref textureOffset);
            base.Update();
            if (IsClicked())
            {
                animation.Play();
                readyForChange = true;
            }
            if (readyForChange && !animation.IsPlaying)
            {
                animation.Stop(ref textureOffset);
                readyForChange = false;
                SceneManager.LoadScene(nextScene);
                
            }
        }

        public override void Draw()
        {
            if (!glitch)
            {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            }
            else
            {
                if (glithched)
                {
                    spriteGlitch1.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
                else
                {
                    spriteGlitch2.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
            }
        }
    }
}
