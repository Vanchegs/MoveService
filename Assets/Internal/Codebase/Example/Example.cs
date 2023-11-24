using Internal.Codebase.MoveLogic;
using Internal.Codebase.MoveLogic.Interfaces;
using UnityEngine;

namespace Internal.Example
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        [SerializeField] private Rigidbody2D rb;
        private const float tSpeed = 0.1f;
        private const float rbSpeeb = 20;
        private readonly ITransformMovable transformMove = new TransformMove();
        private readonly IRbMovable rbMovable = new RbMove();

        private void FixedUpdate()
        {
            rbMovable.TopDownMove(rb, rbSpeeb);
        }
    }
}
