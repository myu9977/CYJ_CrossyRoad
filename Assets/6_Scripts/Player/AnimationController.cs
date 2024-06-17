using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected CharacterController controller;

    protected virtual void Awake()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }
}
