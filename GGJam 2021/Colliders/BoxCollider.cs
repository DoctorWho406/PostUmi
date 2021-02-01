using System;
using OpenTK;
namespace GGJam_2021 {
    class BoxCollider : Collider {
        protected Vector2 size;
        protected Vector2 halfSize;

        //public Sprite sprite;

        public BoxCollider(Vector2 size) : base() {
            this.size = size;
            halfSize = size * 0.5f;

            //sprite = new Sprite(size.X, size.Y) { pivot = halfSize };
        }
        public override void Scale(float scaleFactory) {
            size *= scaleFactory;
            halfSize *= scaleFactory;

            //sprite.scale = new Vector2(scaleFactory);
        }

        protected override bool Collides(BoxCollider box) {
            float deltaX = box.Position.X - Position.X;
            float deltaY = box.Position.Y - Position.Y;

            return (Math.Abs(deltaX) <= halfSize.X + box.halfSize.Y) && (Math.Abs(deltaY) <= halfSize.X + box.halfSize.Y);
        }

        public override bool Collides(CircleCollider circle, out Vector2 offset) {
            float deltaX = circle.Position.X - Math.Max(Position.X - halfSize.X, Math.Min(circle.Position.X, Position.X + halfSize.X));
            float deltaY = circle.Position.Y - Math.Max(Position.Y - halfSize.Y, Math.Min(circle.Position.Y, Position.Y + halfSize.Y));
            offset = Vector2.Zero;
            if ((deltaX * deltaX + deltaY * deltaY) < (circle.Radius * circle.Radius))
            {
                if (deltaX * deltaX < deltaY * deltaY)
                {
                    if (deltaY > 0)
                    {
                        offset = new Vector2(0, circle.Radius - deltaY);
                    }
                    else
                    {
                        offset = new Vector2(0, -(circle.Radius + deltaY));
                    }
                }
                else
                {
                    if (deltaX > 0)
                    {
                        offset = new Vector2(circle.Radius - deltaX, 0);
                    }
                    else
                    {
                        offset = new Vector2(-(circle.Radius + deltaX), 0);
                    }
                }
                return true;
            }
            return false;

        }

        public bool IsInside(CircleCollider circle, out Vector2 offset) {
            float x = 0, y = 0;
            if (circle.Position.X < Position.X - halfSize.X + circle.Radius) {
                //Positivo 
                x = Position.X - halfSize.X - (circle.Position.X - circle.Radius);
            } else if (circle.Position.X > Position.X + halfSize.X - circle.Radius) {
                x = Position.X + halfSize.X - circle.Radius - circle.Position.X;
            }
            if (circle.Position.Y < Position.Y - halfSize.Y + circle.Radius) {
                //Positivo 
                y = Position.Y - halfSize.Y + circle.Radius - circle.Position.Y;
            } else if (circle.Position.Y > Position.Y + halfSize.Y - circle.Radius) {
                y = Position.Y + halfSize.Y - circle.Radius - circle.Position.Y;

            }
            offset = new Vector2(x, y);
            if (x != 0 || y != 0) {
                return false;
            }
            return true;
        }

        //public void Draw()
        //{
        //    sprite.DrawWireframe(0, 255, 0);
        //}
    }
}

