using MoveLogic.Interfaces;
using UnityEngine;

namespace MoveLogic
{
    public class TransformMove : ITransformMovable
    {
        public void HorizontalMove(Transform transform, float speed)
        {
            if (transform == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
            transform.Translate(input * speed);
        }
        
        public void VerticalMove(Transform transform, float speed)
        { 
            if (transform == null) return;
            var input = new Vector3(0, Input.GetAxisRaw("Vertical"), 0); 
            transform.Translate(input * speed);
        }
        
        public void TopDownMove(Transform transform, float speed)
        {
            if (transform == null) return;
            var input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.Translate(input * speed);
        }

        public void ToPointMove(Transform playerTransform, Transform finishPoint, float speed)
        {
            if (playerTransform == null || finishPoint == null) return;
            var step = speed * Time.deltaTime;
            playerTransform.position = Vector3.MoveTowards(playerTransform.position, finishPoint.position, step);
        }
    }
}
