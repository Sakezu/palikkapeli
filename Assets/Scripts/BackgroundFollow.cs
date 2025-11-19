using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BackgroundFollow : MonoBehaviour
{
    public Transform target;  // Pelaaja tai kamera

    private Vector3 offset;

    void Start()
    {
        // S‰ilytet‰‰n alkuper‰inen et‰isyys
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Seuraa t‰sm‰lleen targetia x-akselilla
        transform.position = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
