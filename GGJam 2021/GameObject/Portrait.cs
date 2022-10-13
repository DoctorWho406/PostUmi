namespace GGJam_2021 {
	class Portrait : ChangeSceneObject {
		public bool IsOpened {
			get; set;
		}

		private float paranoia;

		public Portrait(string textureName, LayerMask layerMask, int fps = 0, int w = 0, float paranoia = 0) : base(textureName, layerMask, w, 0, fps) {
			IsOpened = false;
			this.paranoia = paranoia;
		}

		public override void Update() {
			base.Update();
			if (IsNearAndClicked()) {
				StatsManager.AddStats(paranoia, Stats.Paranoia);
				if (InteractableObjectManager.CanOpenIt(this)) {
					if (!IsOpened) {
						MusicManager.ObjectTaken++;
					}
					IsOpened = true;
				}

			}
		}
	}
}

