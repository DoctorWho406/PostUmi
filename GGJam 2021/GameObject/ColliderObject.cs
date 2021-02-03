using OpenTK;

namespace GGJam_2021
{
    class ColliderObject : GameObject
    {
        public Collider Collider;
        private Animation animation;

        public ColliderObject(string textureName, LayerMask layerMask, Scene scene, ColliderType colliderType, bool Loop = false, int w = 0, int h = 0) : base(textureName, layerMask, scene, w, h)
        {
            //if(Loop)
            //{
            //    animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, true);
            //}
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
            base.Update();
            //animation.Play();
            Collider.Position = sprite.position;
            if (Collider is BoxCollider)
            {
                ((BoxCollider)Collider).sprite.position = Collider.Position;
            }// else if (Collider is CircleCollider) {
            //    ((CircleCollider)Collider).sprite.position = Collider.Position;
            //}
            if (!(this is Player) && !(this is InteractableObject) && !(this is Button) && !(this is Portrait))
            {
                if (SceneManager.ActiveScene == scene)
                {
                    if (Collider.Collides((CircleCollider)Game.Player.Collider, out Vector2 offset))
                    {
                        Game.Player.Stop();
                        Game.Player.Position += offset;
                    }
                }
            }
        }

        public override void Draw()
        {
            base.Draw();
            //if (Collider is BoxCollider) {
            //    ((BoxCollider)Collider).Draw();
            //} else if (Collider is CircleCollider) {
            //    ((CircleCollider)Collider).Draw();
            //}
        }
    }
}
