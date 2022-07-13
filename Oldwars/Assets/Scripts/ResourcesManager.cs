using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    public static ResourcesManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    [SerializeField] ResourceScriptable scriptable;
    public void SetWoodData(int value)
    {
        scriptable.wood += value;
    }

    public void SetStoneData(int value)
    {
        scriptable.stone += value;
    }

    public int GetWoodData()
    {
        return scriptable.wood;
    }

    public int GetStoneData()
    {
        return scriptable.wood;
    }
}
