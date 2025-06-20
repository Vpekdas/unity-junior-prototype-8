using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject BallPrefab;
    [SerializeField] private float _spawnInterval;
    [SerializeField] private float _spawnRange;

    private Counter _counter;
    private bool _isGameActive;
    void Start()
    {
        _counter = GameObject.Find("Box").GetComponent<Counter>();
        _isGameActive = _counter.IsGameActive;
        StartCoroutine(SpawnBallRoutine());
    }



    IEnumerator SpawnBallRoutine()
    {
        _isGameActive = _counter.IsGameActive;
        while (_isGameActive)
        {
            Instantiate(BallPrefab, GenerateRandomSpawn(), BallPrefab.transform.rotation);
            yield return new WaitForSeconds(_spawnInterval);
        }
    }

    private Vector3 GenerateRandomSpawn()
    {
        float spawnX = Random.Range(-_spawnRange, _spawnRange);
        float spawnY = Random.Range(_spawnRange / 2, _spawnRange);
        float spawnZ = Random.Range(-_spawnRange, _spawnRange);
        return new Vector3(spawnX, spawnY, spawnZ);
    }
}
