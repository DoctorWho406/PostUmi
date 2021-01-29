using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    abstract class GameObject
    {
        protected Sprite sprite;
        protected Texture texture;
        protected Vector2 velocity;
        public Vector2 Position
        {
            get { return sprite.position; }
            set { sprite.position = value; }
        }
        protected GameObject(string textureName, Scene scene/*, int w = 0, int h = 0*/)
        {
            texture = TextureManager.GetTexture(textureName);
            sprite = new Sprite(/*w == 0 ?*/ texture.Width /*: w, h == 0 ?*/, texture.Height /*: h*/);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            SceneManager.AddtoScene(scene,);

        }
        public virtual void Update()
        {
                sprite.position += velocity * Game.DeltaTime;
        }
        public virtual void Draw()
        {
                sprite.DrawTexture(texture);
        }
    }
}
