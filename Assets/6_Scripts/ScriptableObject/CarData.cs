using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Car", menuName = "New Car")]
public class CarData : ScriptableObject
{
    [Header(" Info ")]
    public string carName;
    public float speed;
    public Color color;
    public Vector3 size;
}
