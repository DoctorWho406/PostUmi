namespace GGJam_2021 {
	abstract class PlayScene : Scene {
		private Player player;
		protected PlayScene() : base() {
		}

		public override void Input() {
			player.Input();
		}

		public override void Start() {
			base.Start();
			player = new Player();
		}

		protected override void LoadAssets() {
			base.LoadAssets();
            GfxManager.AddTexture("Player", Constants.TextureDirectory + "Player.png");
		}
	}
}
