using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private const int AttemptsForSearchNewPoint = 5;

    [Header("Spawn Point and Enemy prefab")]
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private List<GameObject> _enemiesPrefabs;

    [Header("Enemy parameters")]
    [SerializeField] private LayerMask _enemyLayer;
    [SerializeField] private LayerMask _obstacleLayer;
    [SerializeField] private LayerMask _groundLayer;

    [Header("Parameters")]
    [SerializeField] private float _radiusSpawnNewEnemy;
    [SerializeField] private float _radiusCheckingEnemyAround;
    [SerializeField] private float _radiusCheckingObstacleAround;
    [SerializeField] private float _startTimeBetweenSpawn;
    [SerializeField] private int _maxEnemyOnScene;

    private float _timeBetweenSpawn;

    private int _currentEnemyOnScene;

    private bool _isCanStartWork = false;

    private SwitchBehavioralPattern _behavioralPattern;

    private List<GameObject> _enemies = new List<GameObject>();

    public void Initialization()
    {
        _timeBetweenSpawn = _startTimeBetweenSpawn;

        _isCanStartWork = true;
        Debug.Log("EnemySpawner / Initialize / _isCanStartWork = " + _isCanStartWork);
    }

    private void Update()
    {
        Debug.Log("EnemySpawner / Update / _isCanStartWork = " + _isCanStartWork);
        if (_isCanStartWork == false)
            return;

        _timeBetweenSpawn -= Time.deltaTime;

        if (_currentEnemyOnScene < _maxEnemyOnScene && _timeBetweenSpawn <= 0)
        {
            SpawnEnemy();
            _timeBetweenSpawn = _startTimeBetweenSpawn;
        }
    }

    private void SpawnEnemy()
    {
        float directionLook = Random.Range(0f, 360f);

        Vector3 newPositionEnemy = GetSpawnPoint();

        if (newPositionEnemy == Vector3.zero)
            return;

        GameObject instanceEnemy = Instantiate(_enemiesPrefabs[Random.Range(0, _enemiesPrefabs.Count)], newPositionEnemy, Quaternion.Euler(0, directionLook, 0));

        IMovable enemy = instanceEnemy.GetComponent<EnemyCharacter>();
        _behavioralPattern = enemy.EnemyCharacter.GetComponentInChildren<SwitchBehavioralPattern>();

        _behavioralPattern.SetBehavioralPattern(enemy);

        _enemies.Add(enemy.EnemyCharacter.gameObject);

        _currentEnemyOnScene++;

    }

    private Vector3 GetSpawnPoint()
    {
        for (int attempt = 0; attempt < AttemptsForSearchNewPoint; attempt++)
        {
            Vector3 newPositionEnemy = Random.insideUnitSphere * _radiusSpawnNewEnemy;
            newPositionEnemy.y = 0;

            if (CheckEnemyInSpawnRadius(newPositionEnemy) && CheckObstacleInSpawnRadius(newPositionEnemy) && CheckGroundUnderEnemy(newPositionEnemy))
            {
                return newPositionEnemy;
            }
        }

        return Vector3.zero;
    }

    private bool CheckEnemyInSpawnRadius(Vector3 spawnPointPosition)
    {
        Collider[] enemyInRadius = Physics.OverlapSphere(spawnPointPosition, _radiusCheckingEnemyAround, _enemyLayer);

        if (enemyInRadius.Length > 0)
            return false;

        return true;
    }    

    private bool CheckObstacleInSpawnRadius(Vector3 spawnPointPosition)
    {
        Collider[] obstacleInRadius = Physics.OverlapSphere(spawnPointPosition, _radiusCheckingObstacleAround, _obstacleLayer);

        if (obstacleInRadius.Length > 0)
            return false;

        return true;
    }

    private bool CheckGroundUnderEnemy(Vector3 spawnPointPosition)
    {
        Collider[] groundUnderEnemy = Physics.OverlapSphere(spawnPointPosition, _radiusCheckingObstacleAround, _groundLayer);

        if (groundUnderEnemy.Length > 0)
            return false;

        return true;
    }
}
