using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnScript : MonoBehaviour
{

    public GameObject wallPrefab;

    public float minx;
    public float maxx;
    public float minz;
    public float maxz;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPosition = new Vector3(Random.Range(minx, maxx), 0.5f, Random.Range(minz, maxz));

            Instantiate(wallPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
