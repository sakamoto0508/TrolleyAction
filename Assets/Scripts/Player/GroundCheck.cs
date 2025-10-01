using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private bool _isGrounded=true;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Lane"))
        {
            _isGrounded = true;
        }
    }

    public bool ReturnIsGrounded()
    {
        return _isGrounded;
    }
}
