namespace GGJam_2021 {
    class Cursor : ColliderObject {
        public Cursor() : base("Cursor", LayerMask.UI, Scene.Always, ColliderType.CircleCollider) {
        }

        public override void Update() {
            base.Update();
            sprite.position = Game.Window.MousePosition;
        }
    }
}
