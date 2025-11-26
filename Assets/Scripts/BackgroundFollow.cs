using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BackgroundFollow : MonoBehaviour
{
    public Transform target;       // Pelaaja tai kamera
    public float xFollowSpeed = 100f; // Kuinka nopeasti tausta seuraa x-akselilla
    public float yFollowSpeed = 100f; // Kuinka nopeasti tausta seuraa y-akselilla

    private Vector3 offset;

    void Start()
    {
        // S‰ilytet‰‰n alkuper‰inen et‰isyys
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Seuraa x-akselilla pehme‰sti
        float newX = Mathf.Lerp(transform.position.x, target.position.x + offset.x, xFollowSpeed * Time.deltaTime);

        // Seuraa y-akselilla pehme‰sti
        float newY = Mathf.Lerp(transform.position.y, target.position.y + offset.y, yFollowSpeed * Time.deltaTime);

        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
