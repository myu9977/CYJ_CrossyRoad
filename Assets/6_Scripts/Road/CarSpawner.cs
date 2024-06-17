using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab;
    public Transform spawnPoint;

    void Start()
    {
        GameObject carGO = Instantiate(carPrefab, spawnPoint.position, Quaternion.identity);
        carGO.transform.SetParent(spawnPoint);
    }

}
