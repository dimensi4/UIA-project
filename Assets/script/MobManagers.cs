using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobManagers : MonoBehaviour
{
    [SerializeField] GameObject ennemisPrefabs;
    [SerializeField] float timeBetweenSpawn = 0.5f;
    float curentTimeBetweenSpawn;

    Transform mobsParent;

    public static MobManagers instance;
    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        mobsParent = GameObject.Find("Mobs").transform;
    }

    private void Update()
    {
        curentTimeBetweenSpawn -= Time.deltaTime;

        if (curentTimeBetweenSpawn <= 0 ){
            SpawnMob();
            curentTimeBetweenSpawn = timeBetweenSpawn;
        }
    }

    Vector2 RandomPosition()
    { 
        return new Vector2(Random.Range(-16,16),Random.Range(-8,8));
    }

    void SpawnMob() { 
        var e = Instantiate(ennemisPrefabs, RandomPosition(), Quaternion.identity);
        e.transform.SetParent(mobsParent);
    }

    public void DestroyAllMobs()
    {
        foreach (Transform e in mobsParent) Destroy(e.gameObject);
    }

}
