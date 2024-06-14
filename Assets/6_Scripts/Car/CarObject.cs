using UnityEngine;

public class CarObject : MonoBehaviour
{
    public CarData carData;

    public void Initialize(CarData data)
    {
        // CarData�� �̿��Ͽ� �ڵ��� �ʱ�ȭ
        gameObject.name = data.carName;
        // �ٸ� �����Ϳ� ���� �ӵ�, ����, ũ�� �� ���� ����
        GetComponent<Rigidbody>().velocity = transform.forward * data.speed;
        GetComponent<Renderer>().material.color = data.color;
        transform.localScale = data.size;
    }
}
