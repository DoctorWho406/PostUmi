using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    enum LayerMask
    {
        Background,
        Middleground,
        Foreground,
        UI,
        Count
    }

    abstract class GameObject
    {
        public Vector2 Position
        {
            get => sprite.position;
            set
            {
                sprite.position = value;
                spriteGlitch1.position = value;
                spriteGlitch2.position = value;
            }
        }
        public LayerMask LayerMask;

        protected Sprite sprite, spriteGlitch1, spriteGlitch2;
        protected Texture texture;
        protected Vector2 size;
        protected Vector2 halfSize
        {
            get; private set;
        }
        protected bool glitch;
        private float timer;
        protected bool glithched;
        protected Scene scene;
        public GameObject(string textureName, LayerMask layerMask, Scene scene, int w = 0, int h = 0)
        {
            //Set LayerMask
            LayerMask = layerMask;
            //Set Texture and Sprite
            texture = TextureManager.GetTexture(textureName);
            this.scene = scene;
            sprite = new Sprite(w == 0 ? texture.Width : w, h == 0 ? texture.Height : h);
            spriteGlitch1 = new Sprite(w == 0 ? texture.Width : w, h == 0 ? texture.Height : h);
            spriteGlitch2 = new Sprite(w == 0 ? texture.Width : w, h == 0 ? texture.Height : h);

            spriteGlitch1.SetMultiplyTint(Constants.tintaBlue);
            spriteGlitch2.SetMultiplyTint(Constants.tintaGialla);

            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            spriteGlitch1.pivot = sprite.pivot;
            spriteGlitch2.pivot = sprite.pivot;

            size = new Vector2(sprite.Width, sprite.Height);
            halfSize = new Vector2(size.X * 0.5f, size.Y * 0.5f);
            //Add to Scene
            SceneManager.AddGOToScene(scene, this);
        }

        public virtual void Scale(float scaleFactory)
        {
            sprite.scale = new Vector2(scaleFactory);
            spriteGlitch1.scale = new Vector2(scaleFactory);
            spriteGlitch2.scale = new Vector2(scaleFactory);
            size *= scaleFactory;
            halfSize *= scaleFactory;
        }

        public virtual void SetGlitch(bool value)
        {
            glitch = value;
        }
        public bool GetGlitch()
        {
            return glitch;
        }
        public virtual void Update()
        {
            if (glitch)
            {
                timer += Game.DeltaTime;
                if (timer > Constants.GlitchTime)
                {
                    timer = 0f;
                    glithched = !glithched;
                }
            }
        }

        public virtual void Draw()
        {
            if (!glitch)
            {
                sprite.DrawTexture(texture);
            }
            else
            {
                if (glithched)
                {
                    spriteGlitch1.DrawTexture(texture);
                }
                else
                {
                    spriteGlitch2.DrawTexture(texture);
                }
            }
        }
    }
}
