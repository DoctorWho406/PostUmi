using OpenTK;

namespace GGJam_2021 {
	abstract class InteractableObject : GlitchableObject {
		public InteractableObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, int fps = 0) : base(textureName, layerMask, w, h, fps) {

		}

		protected bool IsNearAndClicked() {
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

		//protected bool IsClicked() {
		//	//Controllo click
		//	if (Game.Window./*MouseRight*/MouseLeft) {
		//		if (!InputManager.IsTriggerButtonClicked) {
		//			if (Collider.Collides((CircleCollider)Game.Cursor.Collider, out Vector2 v)) {
		//				//System.Console.WriteLine("Hai cliccato su un InteractableObject");
		//				InputManager.IsTriggerButtonClicked = true;
		//				Player.PlayerSoundEmitter.Play(Player.Interaction);
		//				return true;
		//			}
		//		}
		//	} else {
		//		InputManager.IsTriggerButtonClicked = false;
		//	}
		//	return false;
		//}
	}
}
