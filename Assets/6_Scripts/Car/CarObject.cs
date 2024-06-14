using UnityEngine;

public class CarObject : MonoBehaviour
{
    public CarData carData;

    public void Initialize(CarData data)
    {
        // CarData를 이용하여 자동차 초기화
        gameObject.name = data.carName;
        // 다른 데이터에 따라 속도, 색상, 크기 등 설정 가능
        GetComponent<Rigidbody>().velocity = transform.forward * data.speed;
        GetComponent<Renderer>().material.color = data.color;
        transform.localScale = data.size;
    }
}
