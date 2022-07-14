using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Queue<GameObject> enemies;
    [SerializeField] private float poolCount;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float delay;
    private GameObject temp;
    [SerializeField] private Transform parent;
    [SerializeField] private EnemyScriptable enemyData;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        PrepareEnemies();
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(enemyData.spawnTime);
        for (int i = 0; i < enemyData.spawnValue; i++)
        {
            temp = SpawnEnemy(spawnPoint.position);
            yield return new WaitForSeconds(.1f);
        }
        StartCoroutine(SpawnEnemies());
    }

    private void PrepareEnemies()
    {
        enemies = new Queue<GameObject>();
        for (int i = 0; i < poolCount; i++)
        {
            temp = Instantiate(enemy, transform.position, Quaternion.identity, parent);
            enemies.Enqueue(temp);
            temp.SetActive(false);
        }
    }

    private GameObject SpawnEnemy(Vector3 spawnPoint)
    {
        if (enemies.Count > 0)
        {
            temp = enemies.Dequeue();
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

    public void DestroyEnemy(GameObject enemy)
    {
        enemies.Enqueue(enemy);
        enemy.SetActive(false);
    }

}
