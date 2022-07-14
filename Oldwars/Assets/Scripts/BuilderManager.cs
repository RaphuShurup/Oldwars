using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderManager : MonoBehaviour
{
    public static BuilderManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    //private void CheckWoodData(int price)
    //{
    //    if(ResourcesManager.Instance.GetWoodData() >= price)
    //    {
    //        ResourcesManager.Instance.SetWoodData(-price);
    //    }
    //}

    //private void CheckSToneData(int price)
    //{
    //    if (ResourcesManager.Instance.GetStoneData() >= price)
    //    {
    //        ResourcesManager.Instance.SetStoneData(-price);
    //    }
    //}

    [SerializeField] BuildDataManager scriptable;
    public void UpgradeWoodValueData(int value,int price)
    {
        if (ResourcesManager.Instance.GetWoodData() >= price)
        {
            ResourcesManager.Instance.SetWoodData(-price);
            scriptable.woodCreateValue += value;
        }
    }

    public void UpgradeWoodTimerData(float value,int price)
    {
        if (ResourcesManager.Instance.GetWoodData() >= price)
        {
            ResourcesManager.Instance.SetWoodData(-price);
            scriptable.woodCreateTimer -= value;
        }
    }

    public void UpgradeStoneValueData(int value,int price)
    {
        if (ResourcesManager.Instance.GetStoneData() >= price)
        {
            ResourcesManager.Instance.SetStoneData(-price);
            scriptable.stoneCreateValue += value;
        }
    }

    public void UpgradeStoneTimerData(float value,int price)
    {
    
        if (ResourcesManager.Instance.GetStoneData() >= price)
        {
            ResourcesManager.Instance.SetStoneData(-price);
            scriptable.stoneCreatTimer -= value;
        }

    }

    public int GetWoodValueData()
    {
        return scriptable.woodCreateValue;
    }

    public float GetWoodTimerData()
    {
        return scriptable.woodCreateTimer;
    }

    public int GetStoneValueData()
    {
        return scriptable.stoneCreateValue;
    }

    public float GetStoneTimerData()
    {
        return scriptable.stoneCreatTimer;
    }
}
