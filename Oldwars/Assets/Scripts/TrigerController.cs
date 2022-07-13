using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void CloseVelocity()
    {
        rb.velocity = Vector3.zero;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stone"))
        {
            ResourcesManager.Instance.SetStoneData(5);
            CloseVelocity();
        }

        if (collision.gameObject.CompareTag("Tree"))
        {
            ResourcesManager.Instance.SetWoodData(5);
            CloseVelocity();

        }
    }

}
