using OpenTK;

namespace GGJam_2021 {
    class Background : GameObject {
        public Vector2 ColliderCenter {
            get => collider.Position;
            set => collider.Position = value;
        }
        protected BoxCollider collider;

        public Background(string textureName, Scene scene, Vector2 colliderSize) : base(textureName, LayerMask.Background, scene) {
            collider = new BoxCollider(colliderSize);
        }
        public override void Scale(float scaleFactory) {
            base.Scale(scaleFactory);
            collider.Scale(scaleFactory);
            Vector2 distance = collider.Position - Position;
            collider.Position = Position + (distance * scaleFactory);
        }

        public override void Update() {
            if (!collider.IsInside((CircleCollider)Game.Player.Collider, out Vector2 offset)) {
                Game.Player.Position += offset;
                Game.Player.Stop();
            }
            //((BoxCollider)collider).sprite.position = collider.Position;
        }

        //public override void Draw() {
        //    base.Draw();
        //    ((BoxCollider)collider).Draw();
        //}
    }
}
