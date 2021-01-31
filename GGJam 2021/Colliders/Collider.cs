using OpenTK;

namespace GGJam_2021
{
    enum ColliderType
    {
        BoxCollider,
        CircleCollider,
        Count
    }

    abstract class Collider
    {
        //Position relative to center 
        public Vector2 Position;

        protected Collider()
        {
        }

        public abstract void Scale(float scaleFactory);

        public bool Collides(Collider collider,out Vector2 offset)
        {
            if (collider is BoxCollider)
            {
                return Collides((BoxCollider)collider, out offset);
            }
            else
            {
                return Collides((CircleCollider)collider, out offset);
            }
        }

        protected abstract bool Collides(BoxCollider box);

        protected abstract bool Collides(CircleCollider circle, out Vector2 offset);
    }
}
