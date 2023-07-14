using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    [SerializeField] private float _xRotateSpeed;
    [SerializeField] private float _yRotateSpeed;
    [SerializeField] private float _zRotateSpeed;

    void FixedUpdate()
    {
        transform.Rotate(_xRotateSpeed, _yRotateSpeed, _zRotateSpeed);
    }
}
