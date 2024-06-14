using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController movementController;
    private Rigidbody movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float rotationSpeed = 10f;

    private void Awake()
    {
        movementController = GetComponent<CharacterController>();
        movementRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
        movementController.OnJumpEvent += Jump;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {

        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y).normalized * moveSpeed;
        Vector3 moveVelocity = new Vector3(moveDirection.x, movementRigidbody.velocity.y, moveDirection.z);
        movementRigidbody.velocity = moveVelocity;

        if (direction != Vector2.zero)
        {
            Vector3 targetDirection = new Vector3(direction.x, 0, direction.y); // 이동 방향에 따른 회전 목표 설정
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection); // 플레이어가 targetDirection 방향을 향하도록 하는 회전
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed); // 회전 속도 조절
        }
    }

    private void Jump()
    {
        movementRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
