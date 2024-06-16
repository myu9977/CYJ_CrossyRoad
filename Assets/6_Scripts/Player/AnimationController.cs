using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected CharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }
}
