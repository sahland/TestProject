using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private float _smoothSpeed = 2.5f;
    private Vector3 _desiredPosition;
    private Quaternion _desiredRotation; 

    public void SetRotation(Quaternion rotation)
    {
        _desiredRotation = rotation;
    }

    private void LateUpdate()
    {
        _desiredPosition = _target.position + _offset;

        transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, _desiredRotation, _smoothSpeed * Time.deltaTime);
    }
}
