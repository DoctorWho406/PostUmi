using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    abstract class GameObject {
        public Vector2 Position {
            get => sprite.position;
            set => sprite.position = value;
        }

        protected Sprite sprite;
        protected Texture texture;
        protected Vector2 velocity;

        protected GameObject(string textureName, Scene scene/*, int w = 0, int h = 0*/) {
            texture = TextureManager.GetTexture(textureName);
            sprite = new Sprite(/*w == 0 ?*/ texture.Width /*: w, h == 0 ?*/, texture.Height /*: h*/);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            SceneManager.AddGOToScene(scene, this);
        }

        public virtual void Update() {
            sprite.position += velocity * Game.DeltaTime;
        }

        public virtual void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
