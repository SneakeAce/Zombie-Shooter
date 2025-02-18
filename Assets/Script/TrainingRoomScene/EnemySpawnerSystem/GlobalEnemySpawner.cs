using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GlobalEnemySpawner : EnemySpawner
{
    private const int MinRandomRangeValue = 0;
    private const float MinRotationValue = 0f;
    private const float MaxRotationValue = 360f;

    [SerializeField] private List<SpawnPoint> _spawnPoints;
    private List<EnemyType> _enemyTypes = new List<EnemyType>();

    private ObjectPool<EnemyCharacter> _selectedEnemyPool;

    public override void Initialization()
    {
        InitializationSpawnPoint();

        GetEnemyTypeCount();

        base.Initialization();
    }

    public override void SpawnEnemy()
    {
        EnemyCharacter enemy = GetEnemy();

        if (enemy == null)
            return;

        SwitchBehavioralPattern behavioralPattern = enemy.GetComponentInChildren<SwitchBehavioralPattern>();
        behavioralPattern.SetBehavioralPattern(enemy);
    }

    public override IEnumerator SpawningJob()
    {
        while (_isCanWork)
        {
            yield return new WaitForSeconds(_timeBetweenSpawn);
            
            SpawnEnemy();
        }
    }

    public override bool CheckEnemyAroundSpawnPoint(Vector3 spawnPointPosition)
    {
        Collider[] enemyInRadius = Physics.OverlapSphere(spawnPointPosition, _radiusCheckingEnemyAround, _enemyLayer);

        if (enemyInRadius.Length > 0)
            return false;

        return true;
    }

    public override bool CheckGroundUnderSpawnPoint(Vector3 spawnPointPosition)
    {
        Collider[] groundUnderEnemy = Physics.OverlapSphere(spawnPointPosition, _radiusCheckingObstacleAround, _groundLayer);

        if (groundUnderEnemy.Length > 0)
            return true;

        return false;
    }

    public override bool CheckObstacleAroundSpawnPoint(Vector3 spawnPointPosition)
    {
        Collider[] obstacleInRadius = Physics.OverlapSphere(spawnPointPosition, _radiusCheckingObstacleAround, _obstacleLayer);

        if (obstacleInRadius.Length > 0)
            return false;

        return true;
    }

    public Vector3 GetSpawnPoint(SpawnPoint selectedSpawnPoint)
    {
        if (_spawnPoints.Count == 0)
            return Vector3.zero;

        for (int attempt = 0; attempt < AttemptsForSearchNewSpawnPoint; attempt++)
        {
            Vector3 newPositionEnemy = selectedSpawnPoint.transform.position + (Random.insideUnitSphere * selectedSpawnPoint.RadiusSpawning);
            newPositionEnemy.y = 0;

            if (CheckEnemyAroundSpawnPoint(newPositionEnemy) && CheckGroundUnderSpawnPoint(newPositionEnemy) && CheckObstacleAroundSpawnPoint(newPositionEnemy)) 
            {
                return newPositionEnemy;
            }
        }

        Debug.LogWarning($"�� ������� ����� ����� ��� ������ � {selectedSpawnPoint.name}, ��������� �����������.");
        return selectedSpawnPoint.transform.position;
    }

    private void GetEnemyTypeCount()
    {
        _enemyTypes.Clear();

        _enemyTypes = Enum.GetValues(typeof(EnemyType)).Cast<EnemyType>().ToList();
    }

    private EnemyCharacter GetEnemy()
    {
        _selectedEnemyPool = null;

        if (_enemyTypes.Count == 0)
            return null; 

        int randomNumber = Random.Range(MinRandomRangeValue, _enemyTypes.Count);
        int additionalValue = 1;

        if (Enum.IsDefined(typeof(EnemyType), randomNumber))
        {
            EnemyType enemyTypeSelected = (EnemyType)randomNumber;

            if (PoolsEnemy.PoolDictionary.TryGetValue(enemyTypeSelected, out ObjectPool<EnemyCharacter> poolSelected))
            {
                _selectedEnemyPool = poolSelected;
            }
            else
            {
                Debug.LogWarning($"GetEnemy: ��� ��� {enemyTypeSelected} �� ������!");
                return null;
            }
            
            foreach (SpawnPoint spawnPoint in _spawnPoints)
            {
                if (spawnPoint.EnemyTypeInSpawner == enemyTypeSelected && spawnPoint.CurrentEnemyOnScene < spawnPoint.MaxEnemyOnScene)
                {
                    Vector3 newPosition = GetSpawnPoint(spawnPoint);

                    if (newPosition == Vector3.zero)
                        continue;

                    EnemyCharacter enemy = _selectedEnemyPool.GetPoolObject();

                    if (enemy == null)
                    {
                        Debug.LogWarning($"GetEnemy: �� ������� �������� ����� �� ���� {_selectedEnemyPool}!");
                        return null;
                    }

                    enemy.Initialize();
                    enemy.SetPool(_selectedEnemyPool);

                    enemy.transform.position = newPosition;
                    enemy.transform.rotation = Quaternion.Euler(MinRotationValue, Random.Range(MinRotationValue, MaxRotationValue), MinRotationValue);

                    spawnPoint.CurrentEnemyOnScene = spawnPoint.CurrentEnemyOnScene + additionalValue;

                    enemy.EnemyHealth.UnitDead += OnReturnEnemyToPool;

                    return enemy;
                }
                else
                {
                    continue;
                }
            }

        }

        Debug.LogWarning("GetEnemy: �� ������� ���������� ����� ��� ������.");
        return null;
    }

    private void InitializationSpawnPoint()
    {
        if (_spawnPoints.Count > 0)
        {
            foreach(SpawnPoint spawnPoint in _spawnPoints)
            {
                spawnPoint.Initialization();
            }
        }
    }

    private void OnReturnEnemyToPool(EnemyHealth enemyHealth)
    {
        int decreasingValue = 1;

        EnemyCharacter enemy = enemyHealth.Enemy;

        foreach (SpawnPoint point in _spawnPoints)
        {
            if (point.EnemyTypeInSpawner == enemy.EnemyType)
            {
                point.CurrentEnemyOnScene = point.CurrentEnemyOnScene - decreasingValue;
                break;
            }
        }

        enemy.ReturnToPool(enemyHealth);

        enemyHealth.UnitDead -= OnReturnEnemyToPool;
    }
}
