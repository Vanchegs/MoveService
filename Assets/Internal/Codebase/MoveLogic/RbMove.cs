using MoveLogic.Interfaces;
using UnityEngine;

namespace MoveLogic
{
    public class RbMove : IRbMovable
    {
        public void HorizontalMove(Rigidbody2D rb, float speed)
        {
            if (rb == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
            rb.AddForce(input * speed, ForceMode2D.Force);
        }

        public void VerticalMove(Rigidbody2D rb, float speed)
        {
            if (rb == null) return;
            var input = new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
            rb.AddForce(input * speed, ForceMode2D.Force);
        }

        public void TopDownMove(Rigidbody2D rb, float speed)
        {
            if (rb == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            rb.AddForce(input * speed, ForceMode2D.Force);
        }
    }
}