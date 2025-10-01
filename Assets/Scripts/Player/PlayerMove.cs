using UnityEngine;

public class PlayerMove : MonoBehaviour, IStartSetVariables
{
    private Rigidbody _rb;
    private float _moveSpeed;
    private float _jumpForce;
    private float _laneDistance;
    private int _currentLane = 1;
    private Vector3 _targetPosition;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _targetPosition,
            _moveSpeed * Time.deltaTime);
    }

    public void StartSetVariables(PlayerData playerData)
    {
        _moveSpeed = playerData.MoveSpeed;
        _jumpForce = playerData.JumpForce;
        _laneDistance = playerData.LaneDistance;
    }

    public void Move(Vector2 input)
    {
        if (input.x < 0)
        {
            MoveLane(-1);
        }
        else if (input.x > 0)
        {
            MoveLane(1);
        }
    }
    
    private void MoveLane(int direction)
    {
        //Mathf.Clamp‚Å”ÍˆÍ“à‚ÉŽû‚ß‚é
        _currentLane = Mathf.Clamp(_currentLane + direction, 0, 2);
        UpdateTargetPosition();
    }

    private void UpdateTargetPosition()
    {
        _targetPosition=new Vector3 ((_currentLane-1)*_laneDistance,transform.position.y,1f);
    }
}
