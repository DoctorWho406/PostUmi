using OpenTK;

namespace GGJam_2021
{
    abstract class ColliderObject : GameObject
    {
        public Collider Collider;

        public ColliderObject(string textureName, LayerMask layerMask, Scene scene, ColliderType colliderType) : base(textureName, layerMask, scene)
        {
            switch (colliderType)
            {
                case ColliderType.BoxCollider:
                    Collider = new BoxCollider(size);
                    break;
                case ColliderType.CircleCollider:
                    Collider = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X);
                    break;
            }
        }

        //public ColliderObject(int width, int height, Scene scene, ColliderType colliderType, bool isMoving) : base(width, height, scene, isMoving) {
        //    switch (colliderType) {
        //        case ColliderType.BoxCollider:
        //            Collider = new BoxCollider(size);
        //            break;
        //        case ColliderType.CircleCollider:
        //            Collider = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X);
        //            break;
        //    }
        //}

        public override void Scale(float scaleFactory)
        {
            base.Scale(scaleFactory);
            Collider.Scale(scaleFactory);
        }

        public override void Update()
        {
            Collider.Position = sprite.position;
        }
    }
}
