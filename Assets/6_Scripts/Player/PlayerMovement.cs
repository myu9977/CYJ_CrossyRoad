using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController movementController;
    private Rigidbody movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private bool isGrounded;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float rotationSpeed = 10f;

    [SerializeField] private AudioClip moveSoundClip;
    [SerializeField] private AudioClip jumpSoundClip;


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
        CheckGround();
    }

    private void Move(Vector2 direction)
    {

        movementDirection = direction;
        SoundManager.PlayClip(moveSoundClip);
    }

    private void ApplyMovement(Vector2 direction)
    {
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y).normalized * moveSpeed;
        Vector3 moveVelocity = new Vector3(moveDirection.x, movementRigidbody.velocity.y, moveDirection.z);
        movementRigidbody.velocity = moveVelocity;

        if (direction != Vector2.zero)
        {
            Vector3 targetDirection = new Vector3(direction.x, 0, direction.y); // �̵� ���⿡ ���� ȸ�� ��ǥ ����
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection); // �÷��̾ targetDirection ������ ���ϵ��� �ϴ� ȸ��
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed); // ȸ�� �ӵ� ����
        }
    }

    private void Jump()
    {

        if (isGrounded)
        {
            movementRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            SoundManager.PlayClip(jumpSoundClip);
            isGrounded = false;
        }
        
    }

    private void CheckGround()
    {
        if (Physics.Raycast(transform.position, Vector3.down, 1.1f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
