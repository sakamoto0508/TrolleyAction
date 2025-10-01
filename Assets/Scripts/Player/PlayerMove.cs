using UnityEngine;

public class PlayerMove : MonoBehaviour, IStartSetVariables
{
    private float _moveSpeed;
    public void StartSetVariables(PlayerData playerData)
    {
        _moveSpeed = playerData.MoveSpeed;
    }
}
