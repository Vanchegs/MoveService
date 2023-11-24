using Internal.Codebase.MoveLogic;
using UnityEngine;

namespace Internal.Example
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        private float speed = 30;
        private TransformMove transformMove;

        private void FixedUpdate()
        {
            if ()
            {
                
            }
            transformMove.VerticalMove(playerTransform, speed);
        }
    }
}
