using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFarmBuild : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("x");
        StartCoroutine(CreateStone());
    }

    IEnumerator CreateStone()
    {
        yield return new WaitForSeconds(BuilderManager.Instance.GetStoneTimerData());
        ResourcesManager.Instance.SetStoneData(BuilderManager.Instance.GetStoneValueData());
        StartCoroutine(CreateStone());
    }



}
