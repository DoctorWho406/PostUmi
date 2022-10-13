using OpenTK;

namespace GGJam_2021 {
	abstract class InteractableObject : GlitchableObject {
		public InteractableObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, int fps = 0) : base(textureName, layerMask, w, h, fps) {

		}

		public bool IsNearAndClicked() {
			if (((CompoundCollider)Rigidbody.Collider).BoundingCollider.Collides(((PlayScene)Game.CurrentScene).Player.Rigidbody.Collider)) {
				if (Game.Window./*MouseRight*/MouseLeft) {
					if (!InputManager.IsTriggerButtonClicked) {
						if (Rigidbody.Collider.Contains(Game.Window.MousePosition)) {
							Player.PlayerSoundEmitter.Play(Player.Interaction);
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
	}
}
