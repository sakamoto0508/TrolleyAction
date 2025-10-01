using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;

    public float MoveSpeed => _moveSpeed;
    public float JumpForce => _jumpForce;
}
