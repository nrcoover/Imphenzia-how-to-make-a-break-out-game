using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int points = 100;
    public Vector3 rotator;
    public float rotationSpeed;
    public Material crackedMaterial;
    Material _orgMaterial;
    // The renderer is responsible for getting the material onto the screen.
    Renderer _renderer;

    void Start()
    {
        transform.Rotate(rotator * (transform.position.x + transform.position.y * rotationSpeed));
        _renderer = GetComponent<Renderer>();
        // this is a shared material because shared materials increase the speed.
        _orgMaterial = _renderer.sharedMaterial;
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

        _renderer.sharedMaterial = crackedMaterial;

        Invoke("RestoreMaterial", 0.1f);
    }

    void RestoreMaterial()
    {
        _renderer.sharedMaterial = _orgMaterial;
    }
}
