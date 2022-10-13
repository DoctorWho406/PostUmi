namespace GGJam_2021 {
    class ChangeSceneObject : InteractableObject {
        public bool ReadyForChange {
            get; set;
		}

        protected bool clicked;

        public ChangeSceneObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, int fps = 0) : base(textureName, layerMask, w, h, fps) {
        }

		public override void Update() {
			base.Update();
            if (IsNearAndClicked() && !animation.IsPlaying) {
                animation.Play();
                clicked = true;
                ((PlayScene)Game.CurrentScene).Player.CanMove = false;
            }
            if (clicked && !animation.IsPlaying) {
                ((PlayScene)Game.CurrentScene).Player.CanMove = true;
                animation.Stop(ref textureOffset);
                ReadyForChange = true;
            }
        }
	}
}
