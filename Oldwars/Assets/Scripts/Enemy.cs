using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health;
    private int damage;
    [SerializeField] EnemyScriptable enemyData;

    private Soldier target;
    private void OnEnable()
    {
        Debug.Log("aaaaaaaaaa");
        health = enemyData.enemyHealth;
        damage = enemyData.enemyDamage;
    }

    public void SetTarget(Soldier _target)
    {
        target = _target;
    }

    public void GiveDamage()
    {
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damageValue)
    {
        if(health <= 0)
        {
            EnemySpawner.Instance.DestroyEnemy(this.gameObject);
        }
        health -= damageValue;
    }

}
