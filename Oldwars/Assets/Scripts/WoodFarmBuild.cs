using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodFarmBuild : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("x");
        StartCoroutine(CreateWood());
    }

    IEnumerator CreateWood()
    {
        yield return new WaitForSeconds(BuilderManager.Instance.GetWoodTimerData());
        ResourcesManager.Instance.SetWoodData(BuilderManager.Instance.GetWoodValueData());
        StartCoroutine(CreateWood());
    }
}
