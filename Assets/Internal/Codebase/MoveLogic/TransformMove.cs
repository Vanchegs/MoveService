using UnityEngine;

namespace Internal.Codebase.MoveLogic
{
    public class TransformMove
    {
        public void ForwardMove(Transform transform, float speed)
        {
            
        }

        public void VerticalMove(Transform transform, float speed)
        {
            var moveInput = Input.GetAxisRaw("Vertical");
            Vector3 moveDirection = new Vector3(0, moveInput, 0);
            transform.Translate(moveDirection * speed * Time.deltaTime);
        } 

        public void HorizontalMove(Transform transform, float speed)
        {
            var moveInput = Input.GetAxisRaw("Horizontal");
            Vector3 moveDirection = new Vector3(moveInput, 0, 0); 
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }

        public void TopDownMove()
        {
            
        }
    }
}
