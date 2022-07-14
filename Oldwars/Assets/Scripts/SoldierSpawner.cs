using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour
{
    public static SoldierSpawner Instance;

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Queue<GameObject> soldiers;
    [SerializeField] private float poolCount;
    [SerializeField] private GameObject soldier;
    [SerializeField] private float delay;
    private GameObject temp;
    [SerializeField] private Transform parent;
    [SerializeField] private SoldierScriptable soldierData;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        PrepareSoldiers();
    }


    private void PrepareSoldiers()
    {
        soldiers = new Queue<GameObject>();
        for (int i = 0; i < poolCount; i++)
        {
            temp = Instantiate(soldier, transform.position, Quaternion.identity, parent);
            soldiers.Enqueue(temp);
            temp.SetActive(false);
        }
    }

    private GameObject SpawnSoldier(Vector3 spawnPoint)
    {
        if (soldiers.Count > 0)
        {
            temp = soldiers.Dequeue();
            temp.transform.position = spawnPoint;
            temp.SetActive(true);
            return temp;
        }
        else
        {
            Debug.Log("Pool boþaldý");
            return null;
        }
    }

    public void DestroySoldier(GameObject soldier)
    {
        soldiers.Enqueue(soldier);
        soldier.SetActive(false);
    }

}
