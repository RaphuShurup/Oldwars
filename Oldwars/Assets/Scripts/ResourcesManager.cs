using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesManager : MonoBehaviour
{
    public static ResourcesManager Instance;

    public Text woodcounttext;
    public Text stonecounttext;

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
        woodcounttext.text = (scriptable.wood).ToString();
    }

    public void SetStoneData(int value)
    {
        scriptable.stone += value;
        stonecounttext.text = (scriptable.stone).ToString();
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
