using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        UIManager.Instance.UpdateWoodText();
    }

    public void SetStoneData(int value)
    {
        scriptable.stone += value;
        UIManager.Instance.UpdateStoneText();
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
