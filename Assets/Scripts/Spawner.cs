using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    [SerializeField] GameObject scoreKeeper;

    public int startingAmount;
    public int spawnDelay;
    public int maxZombies;

    int spawnCool;

    List<GameObject> zombies = new List<GameObject> { };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startingAmount; i++)
        {
            GameObject zomb = Instantiate(zombie, new Vector3(Random.Range(-25f, 25f), 0, Random.Range(-25f, 25f)) + transform.position, Quaternion.identity);
            zomb.GetComponent<Zombie>().SpawnerSet(gameObject);
            zombies.Add(zomb);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (zombies.Count < maxZombies && spawnCool <= 0)
        {
            GameObject zomb = Instantiate(zombie, new Vector3(Random.Range(-25f, 25f), 0, Random.Range(-25f, 25f)) + transform.position, Quaternion.identity);
            zomb.GetComponent<Zombie>().SpawnerSet(gameObject);
            zombies.Add(zomb);
            spawnCool = spawnDelay;
        }
        else
        {
            spawnCool--;
        }
    }

    public void dead(GameObject dead)
    {
        zombies.Remove(dead);
        scoreKeeper.GetComponent<Kills>().AddKill();
    }
}
