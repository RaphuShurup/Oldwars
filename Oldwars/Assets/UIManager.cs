using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]  private Text woodCountText;
    [SerializeField]  private Text stoneCountText;

    public static UIManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void UpdateWoodText()
    {
        woodCountText.text = (ResourcesManager.Instance.GetWoodData()).ToString();
    }

    public void UpdateStoneText()
    {
        stoneCountText.text = (ResourcesManager.Instance.GetStoneData()).ToString();
    }
}
