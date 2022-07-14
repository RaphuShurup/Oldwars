using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 _offSet;
    [SerializeField] private GameObject targetObj;
    [SerializeField] private float lerpValue;

    private void Start()
    {
        _offSet = Camera.main.transform.position - targetObj.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetObj.transform.position + _offSet,lerpValue);
    }
}
