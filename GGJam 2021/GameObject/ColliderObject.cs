namespace GGJam_2021 {
    class ColliderObject : GameObject {
        public Collider Collider;

        public ColliderObject(string textureName, Scene scene, ColliderType colliderType, bool isMoving) : base(textureName, scene, isMoving) {
            switch (colliderType) {
                case ColliderType.BoxCollider:
                    Collider = new BoxCollider(size);
                    break;
                case ColliderType.CircleCollider:
                    Collider = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X);
                    break;
            }
        }

        public ColliderObject(int width, int height, Scene scene, ColliderType colliderType, bool isMoving) : base(width, height, scene, isMoving) {
            switch (colliderType) {
                case ColliderType.BoxCollider:
                    Collider = new BoxCollider(size);
                    break;
                case ColliderType.CircleCollider:
                    Collider = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X);               
                    break;
            }
        }
    }
}
