using OpenTK;

namespace GGJam_2021
{
    class InteractableObject : ColliderObject
    {
        protected Collider trigger;

        public InteractableObject(string textureName, LayerMask layerMask, Scene scene, ColliderType colliderType) : base(textureName, layerMask, scene, colliderType)
        {
            switch (colliderType)
            {
                case ColliderType.BoxCollider:
                    trigger = new BoxCollider(size + new Vector2(Constants.TriggerColliderOffset));
                    break;
                case ColliderType.CircleCollider:
                    trigger = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X + Constants.TriggerColliderOffset);
                    break;
            }
        }

        //public InteractableObject(int width, int height, Scene scene, ColliderType colliderType) : base(width, height, scene, colliderType, false) {
        //    switch (colliderType) {
        //        case ColliderType.BoxCollider:
        //            trigger = new BoxCollider(size + new Vector2(Constants.TriggerColliderOffset));
        //            break;
        //        case ColliderType.CircleCollider:
        //            trigger = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X + Constants.TriggerColliderOffset);
        //            break;
        //    }
        //}

        public override void Scale(float scaleFactory) {
            base.Scale(scaleFactory);
            trigger.Scale(scaleFactory);
        }

        protected bool IsClicked() {
            if (trigger.Collides((CircleCollider)Game.Player.Collider)) {
                //Controllo click
                System.Console.WriteLine("NEAR");
                if (Game.Window.MouseRight && Collider.Collides(Game.Cursor.Collider))
                {
                    System.Console.WriteLine("Hai cliccato su un InteractableObject");
                    return true;
                }
            }
            return false;
        }

        public override void Update()
        {
            base.Update();
            trigger.Position = sprite.position;
        }
    }
}
