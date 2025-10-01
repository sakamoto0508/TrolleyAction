using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _laneDistance = 9f;

    public float MoveSpeed => _moveSpeed;
    public float JumpForce => _jumpForce;
    public float LaneDistance => _laneDistance;
}
