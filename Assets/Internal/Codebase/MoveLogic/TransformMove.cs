using Internal.Codebase.MoveLogic.Interfaces;
using UnityEngine;

namespace Internal.Codebase.MoveLogic
{
    public class TransformMove : ITransformMovable
    {
        public void HorizontalMove(Transform transform, float speed)
        {
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
            transform.Translate(input * speed);
        }
        
        public void VerticalMove(Transform transform, float speed)
        { 
            var input = new Vector3(0, Input.GetAxisRaw("Vertical"), 0); 
            transform.Translate(input * speed);
        }
        
        public void TopDownMove(Transform transform, float speed)
        {
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.Translate(input * speed);
        }
    }
}
