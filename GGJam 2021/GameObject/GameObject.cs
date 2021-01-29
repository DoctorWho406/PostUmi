using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    enum LayerMask {
        Background,
        Middleground,
        Foreground,
        UI,
        Count
    }

    abstract class GameObject {
        public Vector2 Position {
            get => sprite.position;
            set => sprite.position = value;
        }
        public LayerMask LayerMask;

        protected Sprite sprite;
        protected Texture texture;
        protected Vector2 size;
        protected Vector2 halfSize {
            get; private set;
        }
        protected bool glitch;

        public GameObject(string textureName, LayerMask layerMask, Scene scene/*, int w = 0, int h = 0*/) {
            //Set LayerMask
            LayerMask = layerMask;
            //Set Texture and Sprite
            texture = TextureManager.GetTexture(textureName);
            sprite = new Sprite(/*w == 0 ?*/ texture.Width /*: w, h == 0 ?*/, texture.Height /*: h*/);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            size = new Vector2(sprite.Width, sprite.Height);
            halfSize = new Vector2(size.X * 0.5f, size.Y * 0.5f);
            //Add to Scene
            SceneManager.AddGOToScene(scene, this);
        }

        //public GameObject(int width, int height, Scene scene) {
        //    sprite = new Sprite(width, height);
        //    sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
        //    size = new Vector2(sprite.Width, sprite.Height);
        //    halfSize = new Vector2(size.X * 0.5f, size.Y * 0.5f);
        //    SceneManager.AddGOToScene(scene, this);
        //}

        public virtual void Scale(float scaleFactory) {
            sprite.scale = new Vector2(scaleFactory);
            size *= scaleFactory;
            halfSize *= scaleFactory;
        }

        public virtual void Glitch() {
            glitch = true;
        }

        public abstract void Update();

        public virtual void Draw() {
            //if (texture != null) {
            //if (glitch) {
            //    float r = Game.Random.Next(0, 255);
            //    float g = Game.Random.Next(0, 255);
            //    float b = Game.Random.Next(0, 255);
            //    sprite.SetAdditiveTint(r, g, b, 0);
            //    sprite.DrawTexture(texture);
            //    sprite.SetAdditiveTint(0, 0, 0, 0);
            //    glitch = false;
            //} else {
            sprite.DrawTexture(texture);
            //}
            //}
        }
    }
}
