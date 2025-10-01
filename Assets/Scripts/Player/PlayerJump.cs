using UnityEngine;

public class PlayerJump : MonoBehaviour,IStartSetVariables
{
    private Rigidbody _rb;
    private float _jumpForce;

    public void StartSetVariables(PlayerData playerData)
    {
        _jumpForce = playerData.JumpForce;
    }

    public void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
}
