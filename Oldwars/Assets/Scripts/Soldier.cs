using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    private int health;
    private int damage;
    private Enemy target;

    [SerializeField] private SoldierScriptable soldierData;
    private void OnEnable()
    {
        health = soldierData.health;
        damage = soldierData.damage;
    }

    public void GiveDamage()
    {
        target.TakeDamage(damage);
    }

    public void SetTarget(Enemy _target)
    {
        target = _target;
    }

    public void TakeDamage(int damageValue)
    {
        health -= damageValue;
        if (health <= 0)
        {
            SoldierSpawner.Instance.DestroySoldier(this.gameObject);
        }
    }
}
