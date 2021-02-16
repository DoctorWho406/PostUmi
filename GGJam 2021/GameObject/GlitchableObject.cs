using Aiv.Fast2D;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021
{
    class GlitchableObject : GameObject
    {
        public override Vector2 Position
        {
            get => sprite.position;
            set
            {
                spriteGlitch1.position = value;
                spriteGlitch2.position = value;
            }
        }
        protected bool glitch;
        private float timer;
        protected bool glithched;

        public GlitchableObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, float fps = 0) : base(textureName, layerMask, w, h, fps)
        {
            spriteGlitch1 = new Sprite(w, h);
            spriteGlitch2 = new Sprite(w, h);

            spriteGlitch1.SetMultiplyTint(Constants.tintaBlue);
            spriteGlitch2.SetMultiplyTint(Constants.tintaGialla);

            spriteGlitch1.pivot = sprite.pivot;
            spriteGlitch2.pivot = sprite.pivot;
        }

        public override void Scale(float scaleFactory)
        {
            spriteGlitch1.scale = new Vector2(scaleFactory);
            spriteGlitch2.scale = new Vector2(scaleFactory);
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

        public override void Draw()
        {
            if (!glitch)
            {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            }
            else
            {
                if (glithched)
                {
                    spriteGlitch1.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
            }
        }
    }
}
