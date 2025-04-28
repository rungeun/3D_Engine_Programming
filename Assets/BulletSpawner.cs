using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPerfab;
    public float spawnRateMin = 0.5f;
    public float spawnRatrMax = 3f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
