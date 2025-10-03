using UnityEngine;

public class PlayerJump : MonoBehaviour,IStartSetVariables
{
    private Rigidbody _rb;
    private GroundCheck _groundCheck;
    private float _jumpForce;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _groundCheck = GetComponentInChildren<GroundCheck>();
    }

    public void StartSetVariables(PlayerData playerData)
    {
        _jumpForce = playerData.JumpForce;
    }

    public void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        _groundCheck.IsGrounded = false;
    }
}
