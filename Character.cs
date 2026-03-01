using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int hp;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
            Debug.Log(GetType().Name + " ena damage: " + damage);
            Debug.Log(GetType().Name + " sisa HP: " + hp);
        }
        
    }

    public bool IsDead()
    {
        return hp <= 0;
    }
}

