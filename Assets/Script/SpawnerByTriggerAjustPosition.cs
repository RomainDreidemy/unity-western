using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByTriggerAjustPosition : MonoBehaviour
{
    public GameObject[] ObjPrefabs;

    public int Min = -1;
    public int Max = 2;

    private GameObject LastSpawnee;

    // Start is called before the first frame update
    void Start()
    {
        this.SpawnPrefab();
    }

    public void SpawnPrefab()
    {
        int index = Random.Range(0, ObjPrefabs.Length);

        GameObject spawnee = GameObject.Instantiate(ObjPrefabs[index]);

        if(this.LastSpawnee != null){
            Vector3 LastSpawneePos = this.LastSpawnee.transform.position;

            // Modifier cette pos par la longueur du dernier spawnee
            BoxCollider coll = this.LastSpawnee.GetComponent<BoxCollider>();
            LastSpawneePos.x += coll.bounds.size.x;
            spawnee.transform.position = LastSpawneePos;

        }else{
            Vector3 spawnerPos = transform.position;
            spawnerPos.x += Random.Range(Min, Max);
            spawnee.transform.position = spawnerPos;
        }

        this.LastSpawnee = spawnee;        
    }
}
