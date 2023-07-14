using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turnSpeed;
    [SerializeField] private float _verticalSpeed;

    private float _horizontalInput;
    private float _forwardInput;
    private float _verticalInput;

    private CameraFollow _cf;

    private void Start()
    {
    }

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        _verticalInput = Input.GetKey(KeyCode.E) ? 1f : (Input.GetKey(KeyCode.Q) ? -1f : 0f);

        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);

        transform.Translate(Vector3.up * Time.deltaTime * _verticalSpeed * _verticalInput);

        if(_cf != null)
        {
            _cf.SetRotation(transform.rotation);
        }
    }
}
