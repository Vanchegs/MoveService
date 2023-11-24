using UnityEngine;

namespace Internal.Codebase.MoveLogic.Interfaces
{
    public interface IRbMovable
    {
        void HorizontalMove(Rigidbody2D rb, float speed);
        void VerticalMove(Rigidbody2D rb, float speed);
        void TopDownMove(Rigidbody2D rb, float speed);
    }
}
