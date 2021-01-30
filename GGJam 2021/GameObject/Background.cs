namespace GGJam_2021 {
    class Background : ColliderObject {


        public Background(string textureName, Scene scene) : base(textureName, LayerMask.Background, scene, ColliderType.BoxCollider) {
        }

        public override void Update() {
            base.Update();
            if (Collider.Collides(Game.Player.Collider)) {
                Game.Player.Stop();
            }
        }

        public override void Glitch() {
        }
    }
}
