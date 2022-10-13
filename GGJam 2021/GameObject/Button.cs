namespace GGJam_2021 {
	class Button : GameObject {
		public Button(string textureName, int w = 0, int h = 0, int fps = 0) : base(textureName, LayerMask.Middleground, w, h, fps) {
		}

		protected bool IsClicked() {
			if (Game.Window.MouseLeft) {
				if (!InputManager.IsTriggerButtonClicked) {
					InputManager.IsTriggerButtonClicked = true;
					if (Rigidbody.Collider.Contains(Game.Window.MousePosition)) {
						return true;
					}
				}
			} else {
				InputManager.IsTriggerButtonClicked = false;
			}
			return false;
		}
	}
}
