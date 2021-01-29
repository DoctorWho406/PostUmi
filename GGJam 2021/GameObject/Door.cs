namespace GGJam_2021 {
    class Door : InteractableObject {
        private Scene next;

        public Door(int width, int height, Scene scene, ColliderType colliderType, Scene nextScene) : base(width, height, scene, colliderType) {
            next = nextScene;
        }

        public override void Update() {
            base.Update();
            if (IsClicked()) {
                System.Console.WriteLine("Aperto la porta");
                SceneManager.LoadScene(next);
            }
        }
    }
}
