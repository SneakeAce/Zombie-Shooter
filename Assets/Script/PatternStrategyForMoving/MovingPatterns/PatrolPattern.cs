using System.Collections.Generic;
using UnityEngine;

public class PatrolPattern : IBehavioralPattern
{
    private const float MinDistanceToPoint = 0.11f;
    private const float MaxDistanceToPoint = 1.5f;

    private IMovable _movable;

    private Transform _currentPoint;
    private Vector3 _currentPositionMovable;

    private SpawnPatrolPoints _spawnPatrolPoints;
    private List<Transform> _patrolPoints = new List<Transform>();

    private float _startTimeBetweenGetNewPoint = 5f;
    private float _timeBetweenGetNewPoint;

    private bool _isMoving;
    private bool _hasPointReached;

    public PatrolPattern(IMovable movable, SpawnPatrolPoints spawnPatrolPoints)
    {
        _movable = movable;
        _movable.NavMeshAgent.stoppingDistance = 0;

        _spawnPatrolPoints = spawnPatrolPoints;

        _patrolPoints = _spawnPatrolPoints.GetPatrolPoints();

        if (_patrolPoints.Count > 0 )
            _currentPoint = _patrolPoints[Random.Range(0, _patrolPoints.Count)];
    }

    public void StartMove()
    {
        _timeBetweenGetNewPoint = _startTimeBetweenGetNewPoint;

        if (_patrolPoints.Count > 0)
        {
            _isMoving = true;
            _hasPointReached = false;

            _movable.NavMeshAgent.isStopped = false;
        }
    }

    public void StopMove()
    {
        _isMoving = false;
        _hasPointReached = false;

        _movable.NavMeshAgent.isStopped = true;

        if (_patrolPoints.Count > 0)
            _patrolPoints.Clear();
    }

    public void Update()
    {
        _currentPositionMovable = _movable.Transform.position;

        if (Vector3.Distance(_currentPositionMovable, _currentPoint.transform.position) <= MinDistanceToPoint)
        {
            _hasPointReached = true;

            GetNewPoint();
        }

        if (_hasPointReached)
        {
            StoppingMove();

            _movable.Animator.SetBool("IsRunning", _isMoving);
        }

        if (_movable.NavMeshAgent.isStopped && _hasPointReached == false) 
            RepeatCheckDistance();
        else if (_movable.NavMeshAgent.isStopped && _hasPointReached)
            return;

        _movable.NavMeshAgent.SetDestination(_currentPoint.transform.position);

        _movable.Animator.SetBool("IsRunning", _isMoving);
    }

    private void StoppingMove()
    {
        _isMoving = false;
        _hasPointReached = false;

        _movable.NavMeshAgent.isStopped = true;
    }

    private void GetNewPoint()
    {
        if (_timeBetweenGetNewPoint > 0)
        { 
            _timeBetweenGetNewPoint -= Time.deltaTime;
            return;
        }

        if (_patrolPoints.Count > 0)
        {
            if (_patrolPoints.Contains(_currentPoint))
            {
                _patrolPoints.Remove(_currentPoint);
                _spawnPatrolPoints.DestroyPoint(_currentPoint.gameObject);

                if (_patrolPoints.Count == 0)
                {
                    GetNewPatrolPoints();
                }
            }
        }

        _currentPoint = _patrolPoints[Random.Range(0, _patrolPoints.Count)];

        StartMove();
    }

    private void RepeatCheckDistance()
    {
        if (Vector3.Distance(_currentPositionMovable, _currentPoint.transform.position) <= MaxDistanceToPoint)
        {
            _hasPointReached = true;

            GetNewPoint();
        }
    }

    private void GetNewPatrolPoints()
    {
        _patrolPoints.Clear();

        _patrolPoints = _spawnPatrolPoints.GetPatrolPoints();
    }
}
