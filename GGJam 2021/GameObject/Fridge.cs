using OpenTK;

namespace GGJam_2021 {
    class Fridge : InteractableObject {
        private bool eating;

        public Fridge() : base("Frigorifero", LayerMask.Middleground, 460, 0, Constants.FPSFridgeAnimation) {
        }

        public override void Update() {
            base.Update();
            if (IsNearAndClicked() && !eating) {
                ((PlayScene)Game.CurrentScene).Player.CanMove = false;
                animation.Play();
                eating = true;
                StatsManager.AddStats(Constants.HungerFromFridge, Stats.Hunger);
            }
            if (eating && !animation.IsPlaying) {
                ((PlayScene)Game.CurrentScene).Player.CanMove = true;
                animation.Stop(ref textureOffset);
                eating = false;
            }
        }
    }
}
