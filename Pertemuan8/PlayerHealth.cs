using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    private int currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        Debug.Log("Player terkena damage: " + damage);
        Debug.Log("HP sekarang: " + currentHP);

        if (currentHP <= 0)
        {
            Debug.Log("Player Mati!");
        }
    }
}
