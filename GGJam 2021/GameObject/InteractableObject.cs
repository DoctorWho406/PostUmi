using OpenTK;

namespace GGJam_2021 {
    abstract class InteractableObject : ColliderObject {
        protected Collider trigger;

        public InteractableObject(string textureName, LayerMask layerMask, Scene scene, ColliderType colliderType, int w = 0, int h = 0) : base(textureName, layerMask, scene, colliderType, w, h) {
            switch (colliderType) {
                case ColliderType.BoxCollider:
                    trigger = new BoxCollider(size + new Vector2(Constants.TriggerColliderOffset));
                    break;
                case ColliderType.CircleCollider:
                    trigger = new CircleCollider(halfSize.X > halfSize.Y ? halfSize.Y : halfSize.X + Constants.TriggerColliderOffset);
                    break;
            }
        }

        public override void Scale(float scaleFactory) {
            base.Scale(scaleFactory);
            trigger.Scale(scaleFactory);
        }

        protected bool IsNearAndClicked() {
            if (trigger.Collides((CircleCollider)Game.Player.Collider, out Vector2 V)) {
                //Controllo click
                //System.Console.WriteLine("NEAR");
                if (Game.Window.MouseRight) {
                    if (!InputManager.IsTriggerButtonClicked) {
                        if (Collider.Collides((CircleCollider)Game.Cursor.Collider, out Vector2 v)) {
                            //System.Console.WriteLine("Hai cliccato su un InteractableObject");
                            InputManager.IsTriggerButtonClicked = true;
                            Player.PlayerSoundEmitter.Play(Player.Interaction);
                            return true;
                        }
                    }
                } else {
                    InputManager.IsTriggerButtonClicked = false;
                }
            }
            return false;
        }

        protected bool IsClicked() {
            //Controllo click
            if (Game.Window.MouseRight) {
                if (!InputManager.IsTriggerButtonClicked) {
                    if (Collider.Collides((CircleCollider)Game.Cursor.Collider, out Vector2 v)) {
                        //System.Console.WriteLine("Hai cliccato su un InteractableObject");
                        InputManager.IsTriggerButtonClicked = true;
                        Player.PlayerSoundEmitter.Play(Player.Interaction);
                        return true;
                    }
                }
            } else {
                InputManager.IsTriggerButtonClicked = false;
            }
            return false;
        }

        public override void Update() {
            base.Update();
            trigger.Position = sprite.position;
        }
    }
}
