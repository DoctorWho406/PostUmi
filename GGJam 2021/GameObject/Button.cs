namespace GGJam_2021 {
    class Button : ChangeSceneObject {
        public Button(string textureName) : base(textureName, LayerMask.Middleground, Scene.Menu, Scene.Room, ColliderType.CircleCollider) {
        }

        public override void SetGlitch(bool value) {
        }

        public override void Update() {
            base.Update();
            if (IsClicked()) {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
