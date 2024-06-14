using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            CallJumpEvent();
        }
    }
}
