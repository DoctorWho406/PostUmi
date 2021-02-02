using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class Slider {
        private Sprite sprite;
        private Stat stat;

        public Slider(Vector2 position, Stat stat) {
            this.stat = stat;
            switch (stat) {
                case Stat.Hunger:
                    sprite = new Sprite(Constants.HungerMax, 50);
                    break;
                case Stat.Paranoia:
                    sprite = new Sprite(Constants.ParanoiaMax, 50);
                    break;
            }
            sprite.position = position;
        }

        public void Update() {
            sprite.scale = new Vector2(stat == Stat.Paranoia ? StatsManager.Paranoia/Constants.ParanoiaMax : StatsManager.Hunger/Constants.HungerMax, 1);
        }

        public void Draw() {
            sprite.DrawColor(new Vector4(255, 0, 0, 255));
        }
    }
}
