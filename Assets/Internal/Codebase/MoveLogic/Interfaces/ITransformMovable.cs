using UnityEngine;

namespace Internal.Codebase.MoveLogic.Interfaces
{
    public interface ITransformMovable
    {
        void HorizontalMove(Transform transform, float speed);
        void VerticalMove(Transform transform, float speed);
        void TopDownMove(Transform transform, float speed);
        void ToPointMove(Transform startPoint, Transform finishPoint, float speed);
    }
}
