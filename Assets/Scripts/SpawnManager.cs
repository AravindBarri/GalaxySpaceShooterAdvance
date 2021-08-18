using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] powerUps;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
        StartCoroutine(PowerUpsSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-8, 8), 6, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
    IEnumerator PowerUpsSpawn()
    {
        while (true)
        {
            int r = Random.Range(0, powerUps.Length);
            Instantiate(powerUps[r], new Vector3(Random.Range(-8, 8), 6, 0), Quaternion.identity);
            yield return new WaitForSeconds(10.0f);
        }
    }
}
