using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int points = 100;
    public Vector3 rotator;
    public float rotationSpeed;

    void Start()
    {
        transform.Rotate(rotator * (transform.position.x + transform.position.y * rotationSpeed));
    }

    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        // TODO Add point score
        if (hits <= 0)
        {
            Destroy(gameObject);
        }
    }
}
