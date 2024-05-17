using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainFunctions;
public class GameManager : MonoBehaviour
{
    spawnManager spawner =new ();
    public GameObject[] enemies;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawner());
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator enemySpawner()
    {
        while (true)
        {
            spawner.randomSpawn(enemies, spawnPoints);
            yield return new WaitForSeconds(1f);

        }
    }
}
