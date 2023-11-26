using UnityEngine;

namespace MoveLogic
{
    public static class TransformMove
    {
        public static void HorizontalMove(this Transform playerTransform, float speed)
        {
            if (playerTransform == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
            playerTransform.Translate(input * speed);
        }
        
        public static void VerticalMove(this Transform playerTransform, float speed)
        { 
            if (playerTransform == null) return;
            var input = new Vector3(0, Input.GetAxisRaw("Vertical"), 0); 
            playerTransform.Translate(input * speed);
        }
        
        public static void TopDownMove(this Transform playerTransform, float speed)
        {
            if (playerTransform == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            playerTransform.Translate(input * speed);
        }

        public static void ToPointMove(this Transform playerTransform, Transform finishPoint, float speed)
        {
            if (playerTransform == null || finishPoint == null) return;
            var step = speed * Time.deltaTime;
            playerTransform.position = Vector3.MoveTowards(playerTransform.position, finishPoint.position, step);
        }
    }
}
