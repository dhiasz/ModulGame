using UnityEngine;
using System.Collections;

namespace TopDown.Spawn
{
    public class Spawn : MonoBehaviour
    {
        [Header("Spawn Settings")]
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private float spawnInterval = 2f;

        private void Start()
        {
            StartCoroutine(SpawnRoutine());
        }

        private IEnumerator SpawnRoutine()
        {
            while (true)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(spawnInterval);
            }
        }

        private void SpawnEnemy()
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}