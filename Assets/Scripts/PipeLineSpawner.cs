using System.Collections;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private PipeLine pipeLinePrefab;
    [SerializeField] private float randomRange;

    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopCoroutine(spawnRoutine);
    }

    Coroutine spawnRoutine;

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Vector2 spawnPos = transform.position + Vector3.up * Random.Range(-randomRange, randomRange);
            Instantiate(pipeLinePrefab, spawnPos, transform.rotation);
        }
    }
}
