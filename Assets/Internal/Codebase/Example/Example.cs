using MoveLogic;
using MoveLogic.Interfaces;
using UnityEngine;

namespace Internal.Codebase.Example
{
    public class Example : MonoBehaviour
    {
        private ITransformMovable tMove = new TransformMove();
        private Transform pTransform;
        private float speed;

        private void Start()
        {
            speed = 0.1f;
            pTransform = GetComponent<Transform>();
        }

        private void FixedUpdate()
        {
            tMove.HorizontalMove(pTransform, speed);
        }
    }
}
