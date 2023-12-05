using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleRotation : MonoBehaviour
{
    public Vector3 rotation;
    [Range(0, 1)] public float speed=1f;
    void Update()
    {
        transform.Rotate(rotation*Time.deltaTime*speed);
    }
}
