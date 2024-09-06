using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject smallSphere;
    public GameObject mediumSphere;
    public GameObject largeSphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandomSpheres()
    {
        int randomS = Random.Range(20, 50);
        int randomM = Random.Range(5, 10);
        int randomL = Random.Range(3, 5);

        //Vector3 spawnPos = new Vector3(1, 25, 1);

        for (int i = 0; i < randomS; i++) 
        {
            int spawnPointX = Random.Range(-3, 3);
            int spawnPointY = Random.Range(25, 35);
            int spawnPointZ = Random.Range(-12, -3);
            Vector3 spawnPosS = new Vector3(spawnPointX,spawnPointY,spawnPointZ);
            Instantiate(smallSphere, spawnPosS, Quaternion.identity);
        }
        for (int i = 0; i < randomM; i++)
        {
            int spawnPointX = Random.Range(-3, 3);
            int spawnPointY = Random.Range(25, 35);
            int spawnPointZ = Random.Range(-12, -3);
            Vector3 spawnPosM = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
            Instantiate(mediumSphere, spawnPosM, Quaternion.identity);
        }
        for (int i = 0; i < randomL; i++)
        {
            int spawnPointX = Random.Range(-3, 3);
            int spawnPointY = Random.Range(25, 35);
            int spawnPointZ = Random.Range(-12, -3);
            Vector3 spawnPosL = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
            Instantiate(largeSphere, spawnPosL, Quaternion.identity);
        }
    }
}
