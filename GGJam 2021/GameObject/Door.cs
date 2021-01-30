using OpenTK;

namespace GGJam_2021
{
    class Door : InteractableObject
    {
        protected Animation animation;

        private Vector2 textureOffset;
        private bool readyForChange;

        public Door(string textureName, Scene actualScene, Scene nextScene) : base("Empty", LayerMask.Background, actualScene, nextScene, ColliderType.BoxCollider)
        {
            texture = TextureManager.GetTexture(textureName);
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
        }

        public override void Update()
        {
            base.Update();
            animation.Update(ref textureOffset);
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
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
        }
    }
}
