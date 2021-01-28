using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class Cursor {
        private Texture texture;
        private Sprite sprite;
        private Vector2 position {
            set => sprite.position = value;
        }

        public Cursor() {
            texture = TextureManager.GetTexture("Cursor");
            sprite = new Sprite(texture.Width, texture.Height) {
                position = Game.Window.MousePosition,
                scale = new Vector2(0.2f)
            };
        }

        public void Update() {
            position = Game.Window.MousePosition;
        }

        public void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
