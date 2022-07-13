using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerController : MonoBehaviour
{
    private Rigidbody rb;
    public bool controltime;
    public Animator animcontrol;

    private void Start()
    {
        animcontrol = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void CloseVelocity()
    {
        rb.velocity = Vector3.zero;
    }

    public void Test()
    {
        controltime = true;
        Debug.Log("a");
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stone"))
        {
            animcontrol.SetBool("Stone", true);
            if (controltime == true)
            {
                ResourcesManager.Instance.SetStoneData(5);
                CloseVelocity();
                controltime = false;
            }

        }
        else if (collision.gameObject.CompareTag("Tree"))
        {
            animcontrol.SetBool("Tree", true);
            if (controltime == true)
            {
                ResourcesManager.Instance.SetWoodData(5);
                CloseVelocity();
                controltime = false;
            }


        }
        else if (collision.gameObject.CompareTag("WoodBuild"))
        {
            //UI dan paneli aç. Onaylarsa bizden kaynaðý eksilt ve binayý yap.
        }
        else if (collision.gameObject.CompareTag("StoneBuild"))
        {
            //UI dan paneli aç. Onaylarsa bizden kaynaðý eksilt ve binayý yap
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stone"))
        {
            animcontrol.SetBool("Stone", false);
            controltime = false;
        }

        if (collision.gameObject.CompareTag("Tree"))
        {
            animcontrol.SetBool("Tree", false);
            controltime = false;
        }
    }

}
