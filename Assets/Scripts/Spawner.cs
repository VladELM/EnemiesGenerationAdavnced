using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;
    [SerializeField] private int _timeDelay = 2;


    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab);
        enemy.Initialize(transform.position, _target.transform);
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds interval = new WaitForSeconds(_timeDelay);

        while (enabled)
        {
            yield return interval;
            GenerateEnemy();
        }
    }
}
