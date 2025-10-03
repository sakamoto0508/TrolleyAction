using UnityEngine;

public class PlayerMove : MonoBehaviour, IStartSetVariables
{
    private Rigidbody _rb;
    private float _moveForce;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void StartSetVariables(PlayerData playerData)
    {
        _moveForce = playerData.MoveForce;
    }

    public void Move(Vector2 input)
    {
        if (input.x < 0)
        {
            _rb.AddForce(Vector3.left * _moveForce, ForceMode.Impulse);
        }
        else if (input.x > 0)
        {
            _rb.AddForce(Vector3.right * _moveForce, ForceMode.Impulse);
        }
    }
}
