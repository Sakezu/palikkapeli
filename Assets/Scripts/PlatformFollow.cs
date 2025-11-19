using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFollow : MonoBehaviour
{
    public Transform target;     // Pelaaja (Cube)
    public Vector3 offset;       // Etäisyys pelaajaan

    void Update()
    {
        transform.position = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);
    }
}

