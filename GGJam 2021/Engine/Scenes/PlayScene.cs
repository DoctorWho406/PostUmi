namespace GGJam_2021 {
	abstract class PlayScene : Scene {
		public Player Player;
		protected PlayScene() : base() {
		}

		public override void Input() {
			Player.Input();
		}

		public override void Start() {
			base.Start();
			Player = new Player();
		}

		protected override void LoadAssets() {
			base.LoadAssets();
            GfxManager.AddTexture("Player", Constants.TextureDirectory + "Player.png");
		}
	}
}
