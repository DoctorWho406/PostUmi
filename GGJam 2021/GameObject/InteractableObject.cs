using OpenTK;

namespace GGJam_2021 {
    abstract class InteractableObject : ColliderObject {
        protected Collider trigger;
        protected Scene nextScene;

        public InteractableObject(string textureName, LayerMask layerMask, Scene scene, Scene nextScene, ColliderType colliderType) : base(textureName, layerMask, scene, colliderType) {
            this.nextScene = nextScene;
            switch (colliderType) {
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
            if (trigger.Collides(Game.Player.Collider)) {
                //Controllo click
                System.Console.WriteLine("NEAR");
                if (Game.Window.MouseRight) {
                    if (!InputManager.IsTriggerButtonClicked) {
                        if (Collider.Collides(Game.Cursor.Collider)) {
                            //System.Console.WriteLine("Hai cliccato su un InteractableObject");
                            InputManager.IsTriggerButtonClicked = true;
                            return true;
                        }
                    }
                } else {
                    InputManager.IsTriggerButtonClicked = false;
                }
            }
            return false;
        }

        public override void Update() {
            base.Update();
            trigger.Position = sprite.position;
        }
    }
}
