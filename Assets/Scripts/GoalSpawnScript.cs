using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpawnScript : MonoBehaviour
{

    public GameObject goalPrefab;

    public float minx;
    public float maxx;
    public float minz;
    public float maxz;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(minx, maxx), 0.5f, Random.Range(minz, maxz));

        Instantiate(goalPrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            Vector3 spawnPosition = new Vector3(Random.Range(minx, maxx), 0.5f, Random.Range(minz, maxz));

            Instantiate(goalPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
