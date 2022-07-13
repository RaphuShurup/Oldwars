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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stone"))
        {
            ResourcesManager.Instance.SetStoneData(5);
            CloseVelocity();
        }
        else if (collision.gameObject.CompareTag("Tree"))
        {
            ResourcesManager.Instance.SetWoodData(5);
            CloseVelocity();
        }
        else if (collision.gameObject.CompareTag("WoodBuild"))
        {
           //UI dan paneli a�. Onaylarsa bizden kayna�� eksilt ve binay� yap.
        }
        else if (collision.gameObject.CompareTag("StoneBuild"))
        {
            //UI dan paneli a�. Onaylarsa bizden kayna�� eksilt ve binay� yap
        }
    }

}
