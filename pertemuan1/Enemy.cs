using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public void Attack(Player player)
    {
        int damage = Random.Range(14, 31);
        Debug.Log("Musuh memberikan "+ damage + " damage");
        player.TakeDamage(damage);
    }
}