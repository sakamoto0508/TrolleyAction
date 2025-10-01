using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(InputBuffer), typeof(PlayerData))]
public class PlayerController : MonoBehaviour
{
    public bool IsGrounded { get; private set; } = true;
    private InputBuffer _inputBuffer;
    private PlayerData _playerData;
    private PlayerMove _playerMove;
    private PlayerJump _playerJump;
    private GroundCheck _groundCheck;

    private void Awake()
    {
        _inputBuffer = GetComponent<InputBuffer>();
        _playerData = GetComponent<PlayerData>();
        _playerMove = GetComponent<PlayerMove>();
        _playerJump = GetComponent<PlayerJump>();
        _groundCheck = GetComponentInChildren<GroundCheck>();
    }

    void Start()
    {
        _inputBuffer.MoveAction.started += OnInputMove;
        _playerMove.StartSetVariables(_playerData);
    }

    private void OnDestroy()
    {
        _inputBuffer.MoveAction.started -= OnInputMove;
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = _groundCheck.ReturnIsGrounded();
    }

    private void OnInputMove(InputAction.CallbackContext context)
    {
        if (IsGrounded)
        {
            _playerJump?.Jump();
        } 
        _playerMove?.Move(context.ReadValue<Vector2>());
    }
}
