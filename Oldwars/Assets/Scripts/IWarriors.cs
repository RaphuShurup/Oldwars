using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWarriors 
{
    public void SetTarget(GameObject _target);

    public void GiveDamage();


    public void TakeDamage(int damageValue);
    
}
