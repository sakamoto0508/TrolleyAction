using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputBuffer _inputBuffer;
    private PlayerData _playerData;
    private PlayerMove _playerMove;

    private void Awake()
    {
        _inputBuffer = GetComponent<InputBuffer>();
        _playerData = GetComponent<PlayerData>();
        _playerMove = GetComponent<PlayerMove>();
    }

    void Start()
    {
        _inputBuffer.MoveAction.started += OnInputMove;
        _inputBuffer.JumpAction.started += OnInputJump;
        _playerMove.StartSetVariables(_playerData);
    }

    private void OnDestroy()
    {
        _inputBuffer.MoveAction.started -= OnInputMove;
        _inputBuffer.JumpAction.started -= OnInputJump;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnInputMove(InputAction.CallbackContext context)
    {
        
    }

    private void OnInputJump(InputAction.CallbackContext context)
    {

    }
}
