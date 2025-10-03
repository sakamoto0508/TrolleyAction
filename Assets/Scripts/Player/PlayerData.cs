using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float _moveForce;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _laneDistance = 9f;

    public float MoveForce => _moveForce;
    public float JumpForce => _jumpForce;
    public float LaneDistance => _laneDistance;
}
