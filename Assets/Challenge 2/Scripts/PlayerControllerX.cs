using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 1.0f;
    private float lastSpawn;

    void Start()
    {
        lastSpawn = -spawnCooldown;
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if ((Input.GetKeyDown(KeyCode.Space)) && Time.time >= lastSpawn + spawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawn = Time.time;
        }
    }
}
