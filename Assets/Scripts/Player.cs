using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rigidbody;

    void Start()
    {
        Cursor.visible = false;
        _rigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // MovePosition() should be used here instead of Transform.Translate().
        // MovePosition() takes in account of the physics engine; if interpolation is enabled, the forced movement will take that into account as well.
        _rigidbody.MovePosition(new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 50)).x, -17, 0));
            // ScreenToWorldPoint is enabling the position of the mouse to be captured as a position on the screen for controlling the padel.
    }
}
