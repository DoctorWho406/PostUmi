using Aiv.Fast2D;

namespace GGJam_2021
{
    class Background
    {
        Texture texture;
        Sprite sprite;

        public Background()
        {
            texture = TextureManager.GetTexture("stanza");
            sprite = new Sprite(texture.Width, texture.Height);
        }

        public void Update()
        {
           
        }
        public void Draw()
        {
            sprite.DrawTexture(texture);
        }
    }
}
