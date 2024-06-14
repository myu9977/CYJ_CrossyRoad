using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speed = 5f;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        Vector3 playerCameraPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, playerCameraPos, speed * Time.deltaTime);
    }
}
