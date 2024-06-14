using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float moveX;

    void Start()
    {
        
    }

    void Update()
    {
        moveX = moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0, 0);
    }
}
