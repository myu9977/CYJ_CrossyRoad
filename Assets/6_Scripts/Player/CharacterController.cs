using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action OnJumpEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallJumpEvent()
    {
        OnJumpEvent?.Invoke();
    }
}
