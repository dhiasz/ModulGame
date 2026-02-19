using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;

namespace TopDown.Spawn
{
    public class Spawn : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public Transform spawnPoint;

        void Start()
        {
            SpawnEnemy();
        }

        void SpawnEnemy()
        {
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}

