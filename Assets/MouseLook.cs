using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float _tX = 0;
    // Start is called before the first frame update
    void Start()
    {
        var body = GetComponent<Rigidbody>();
        if(body != null) body.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        _tX-=Input.GetAxis("Mouse Y") * 9.0f;
        _tX=Mathf.Clamp(_tX,-45f,45f);
        transform.localEulerAngles = new Vector3(
            _tX,
            Input.GetAxis("Mouse X") * 9.0f + transform.localEulerAngles.y,
            0
        );
    }
}
