using UnityEngine;

public class PlayerMove : MonoBehaviour, IStartSetVariables
{
    private float _moveSpeed;
    private float _laneDistance;
    private int _currentLane = 1;
    private Vector3 _targetPosition;

    private void FixedUpdate()
    {
        
    }

    public void StartSetVariables(PlayerData playerData)
    {
        _moveSpeed = playerData.MoveSpeed;
        _laneDistance = playerData.LaneDistance;
    }

    public void Move(Vector2 input)
    {
        if (input.x < 0)
        {

        }
        else if (input.x > 0)
        {

        }
    }
}
