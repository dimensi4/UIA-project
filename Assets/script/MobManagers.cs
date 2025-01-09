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
        curentTimeBetweenSpawn = Random.Range(0f, timeBetweenSpawn);
    }

    private void Update()
    {
        curentTimeBetweenSpawn -= Time.deltaTime;

        if (curentTimeBetweenSpawn <= 0)
        {
            SpawnMob();
            curentTimeBetweenSpawn = timeBetweenSpawn;
        }
    }

    Vector2 RandomPosition()
    {
        return new Vector2(Random.Range(-20, 20), Random.Range(-10, 10));
    }

    void SpawnMob()
    {
        var e = Instantiate(ennemisPrefabs, RandomPosition(), Quaternion.identity);
        e.transform.SetParent(mobsParent);
    }

    public void DestroyAllMobs()
    {
        foreach (Transform e in mobsParent) Destroy(e.gameObject);
    }
}