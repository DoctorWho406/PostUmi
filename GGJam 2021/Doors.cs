namespace GGJam_2021 {
    class Doors {
        private Scene next;
        private BoxCollider boxCollider;

        public void Update() {
            if (boxCollider.Collides(Game.Player.Collider)) {
                SceneManager.LoadScene(next);
            }
        }
    }
}
