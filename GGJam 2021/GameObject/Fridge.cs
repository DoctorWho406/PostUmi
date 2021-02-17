using OpenTK;

namespace GGJam_2021 {
    class Fridge : InteractableObject {
        private bool eating;

        public Fridge(Scene scene, ColliderType colliderType) : base("Frigorifero", LayerMask.Middleground, scene, colliderType, 460, 0) {
        }

        public override void Update() {
            animation.Update(ref textureOffset);
            base.Update();
            if (IsNearAndClicked() && !eating) {
                Game.Player.SetIsActive(false);
                animation.Play();
                eating = true;
                StatsManager.AddStats(Constants.HungerFromFridge, Stat.Hunger);
            }
            if (eating && !animation.IsPlaying) {
                Game.Player.SetIsActive(true);
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
