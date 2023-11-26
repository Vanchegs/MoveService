using UnityEngine;

namespace MoveLogic
{
    public static class RbMove
    {
        public static void HorizontalMove(this Rigidbody2D playerRb, float speed)
        {
            if (playerRb == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
            playerRb.AddForce(input * speed, ForceMode2D.Force);
        }

        public static void VerticalMove(this Rigidbody2D playerRb, float speed)
        {
            if (playerRb == null) return;
            var input = new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
            playerRb.AddForce(input * speed, ForceMode2D.Force);
        }

        public static void TopDownMove(this Rigidbody2D playerRb, float speed)
        {
            if (playerRb == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            playerRb.AddForce(input * speed, ForceMode2D.Force);
        }
    }
}