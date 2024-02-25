using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform cameratarget;
    private float xRotation = 0f;
    private float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        CameraRotation();
    }

    void CameraRotation()
    {
        xRotation += Input.GetAxis("Mouse X");
        yRotation += Input.GetAxis("Mouse Y");
        Quaternion rotation = Quaternion.Euler(xRotation, yRotation, 0);
        cameratarget.rotation = rotation;
    }
}
