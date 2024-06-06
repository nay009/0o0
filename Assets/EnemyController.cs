using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
 
{
    public GameObject enemyPrefads;
    public float spawnCycle;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    // Update is called once per frame
    private IEnumerator SpawnEnemys()
    {
        float WaitTime = 1;
        yield return new WaitForSeconds(WaitTime);

        while(true)
        {
            Vector3 position = new Vector3(Random.Range(-8.65f, 8.65f), 5.25f, 0);
            Instantiate(enemyPrefads, position, Quaternion.identity);
            yield return new WaitForSeconds(spawnCycle);

        }
    }
}
