using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isIdle = Animator.StringToHash("isIdle");
    private static readonly int isRun = Animator.StringToHash("isRun");
    private static readonly int isJump = Animator.StringToHash("isJump");
    private static readonly int isHit = Animator.StringToHash("isHit");

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnJumpEvent += Jump;
    }

    private void Move(Vector2 vecter)
    {
        animator.SetBool(isRun, vecter.magnitude > magnituteThreshold);
        //animator.SetBool(isIdle, false);
    }

    private void Jump()
    {
        animator.SetBool(isJump, true);
        //animator.SetBool(isIdle, false);
    }

    private void Hit()
    {
        animator.SetBool(isHit, true);
    }

    private void Idle()
    {
        animator.SetBool(isIdle, true);
        animator.SetBool(isRun, false);
        animator.SetBool(isJump, false);
    }
}
