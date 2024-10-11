using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipa;
    public float spawnTime;
    public float yPosMin, yPosMax;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnPipeCoroutine()
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(pipa, transform.position + Vector3.up * Random.Range(yPosMin, yPosMax), Quaternion.identity);
        StartCoroutine(SpawnPipeCoroutine());
    }
}
