using UnityEngine;
using UnityEngine.Pool;

public class CarSpawner : MonoBehaviour
{
    //public GameObject carPrefab;
    public ObjectPool objectPool;
    public Transform spawnPoint;
    public CarData[] carDataArray;

    void Start()
    {
        //GameObject carGO = Instantiate(carPrefab, spawnPoint.position, Quaternion.identity);
        //carGO.transform.SetParent(spawnPoint);

        SpawnCar();
    }

    private void SpawnCar()
    {
        // �����ϰ� �ڵ��� �����͸� ����
        int randomIndex = Random.Range(0, carDataArray.Length);
        CarData carData = carDataArray[randomIndex];

        // Ǯ���� �ڵ����� ������ �ʱ�ȭ
        GameObject carGO = objectPool.SpawnFromPool("Car", spawnPoint.position, spawnPoint.rotation);
        if (carGO != null)
        {
            carGO.GetComponent<CarObject>().Initialize(carData);
        }
    }

}
