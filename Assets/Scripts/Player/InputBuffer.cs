using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputBuffer : MonoBehaviour
{
    private const string MOVE_ACTION = "Move";
    private const string ATTACK_ACTION = "Attack";

    public InputAction MoveAction => _moveAction;
    public InputAction AttackAction => _attackAction;

    private InputAction _moveAction;
    private InputAction _attackAction;

    private void Awake()
    {
        if(TryGetComponent<PlayerInput>(out var playerInput))
        {
            _moveAction = playerInput.actions[MOVE_ACTION];
            _attackAction = playerInput.actions[ATTACK_ACTION]; 
        }
    }
}
