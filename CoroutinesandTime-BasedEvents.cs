//Write a coroutine to create a delay in spawning objects or triggering actions.
//Learn to use yield return new WaitForSeconds() to pause code execution within coroutines.
//Mini Project: Spawn an enemy or object every few seconds with a coroutine.

using System.Collections;
using UnityEngine;

public class TimeBased : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public float spawnRadius = 5f;
    public float spawnInterval = 5f;
    public float destroyRadius = 3f;

    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    IEnumerator spawnEnemy()
    {
        while (true)
        {
            float randomX = Player.transform.position.x + Random.Range(-spawnRadius, spawnRadius);
            Vector2 randomPosition = new Vector2(randomX, Player.transform.position.y);

            GameObject generatedEnemy = Instantiate(Enemy, randomPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);

            while (Vector2.Distance(Player.transform.position, generatedEnemy.transform.position) < destroyRadius)
            {
                yield return null;
            }

            Destroy(generatedEnemy);
        }
    }
}

