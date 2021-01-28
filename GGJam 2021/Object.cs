using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class Object {
        protected Vector2 position {
            get => sprite.position;
            set => sprite.position = value;
        }
        protected Sprite sprite;
        protected Texture texture;

        protected Object(Vector2 position, string texturteKey = "") {
            if (!(texturteKey == "")) {
                texture = TextureManager.GetTexture(texturteKey);
                sprite = new Sprite(texture.Width, texture.Height);
            } else {
                texture = null;
                sprite = new Sprite(0, 0);
            }
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            this.position = position;
        }

        public virtual void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
