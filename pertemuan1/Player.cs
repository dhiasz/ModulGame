using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public void Attack(Enemy enemy)
    {
        int damage = Random.Range(10, 26);
        Debug.Log("Player memberikan " + damage + " damage");
        enemy.TakeDamage(damage);
    }
}


