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
        // 랜덤하게 자동차 데이터를 선택
        int randomIndex = Random.Range(0, carDataArray.Length);
        CarData carData = carDataArray[randomIndex];

        // 풀에서 자동차를 가져와 초기화
        GameObject carGO = objectPool.SpawnFromPool("Car", spawnPoint.position, spawnPoint.rotation);
        if (carGO != null)
        {
            carGO.GetComponent<CarObject>().Initialize(carData);
        }
    }

}
