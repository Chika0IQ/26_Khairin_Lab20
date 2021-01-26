using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject wallPrefab;

    public int numberofSpawn;
    


    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        for(int i = 0; i < numberofSpawn; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(50,50), 0, Random.Range(50,50));

            if(Random.Range(0, 2) < 1)
            {
                Instantiate(wallPrefab, randomPos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
