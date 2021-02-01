using OpenTK;

namespace GGJam_2021 {
    class Fridge : InteractableObject {
        protected Animation animation;
        private bool eating;
        private Vector2 textureOffset;
        public Fridge(Scene scene, ColliderType colliderType) : base("Frigorifero", LayerMask.Background, scene, colliderType, 460, 0) {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
        }

        public override void Update() {
            animation.Update(ref textureOffset);
            base.Update();
            if (IsClicked() && !eating) {
                Game.Player.IsActive = false;
                animation.Play();
                eating = true;
                StatsManager.AddStats(Constants.HungerFromFridge, Stat.Hunger);
            }
            if (eating && !animation.IsPlaying) {
                Game.Player.IsActive = true;
                animation.Stop(ref textureOffset);
                eating = false;
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
