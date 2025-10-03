using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool IsGrounded = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Lane"))
        {
            IsGrounded = true;
        }
    }

    public bool ReturnIsGrounded()
    {
        return IsGrounded;
    }
}
