using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * 6;
        float dz = Input.GetAxis("Vertical") * 6;
        var movement = new Vector3(dx, 0, dz);
        movement=Vector3.ClampMagnitude(movement,6);
        movement *= Time.deltaTime;
        movement=transform.TransformDirection(movement);
        movement.y=-9.8f;
        _characterController.Move(movement);
    }
}
