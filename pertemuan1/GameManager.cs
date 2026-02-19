using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player Pemain = new Player();
        Pemain.hp = 100;

        Enemy Musuh = new Enemy();
        Musuh.hp = 70;


        while (true)
        {
            int bagian = Random.Range(1, 3);
            if (bagian == 1){
                Pemain.Attack(Musuh);
            }else if (bagian == 2) { 
                Musuh.Attack(Pemain);
            }

            if (Pemain.IsDead())
            {
                Debug.Log("GAME OVER!!!");
                Pemain.hp = 0;
                break;
            }

            if (Musuh.IsDead())
            {
                Debug.Log("Musuh Kalah Kamu menang");
                Pemain.hp = 0;
                break;
            }

            
        }

    }
}
