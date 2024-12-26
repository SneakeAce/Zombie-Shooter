using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Collider _collider;
    [SerializeField] private Animator _animator;

    private float _timeForSecondIdleAnimation = 30f;

    public Rigidbody Rigidbody { get => _rigidbody; }
    public Collider Collider { get => _collider; }
    public Animator Animator { get => _animator; }

    private void Update()
    {
        if (_timeForSecondIdleAnimation > 0)
        {
            _timeForSecondIdleAnimation -= Time.deltaTime;
        }
        else
        {
            ActiveSecondIdleAnimation();
        }
    }

    private void ActiveSecondIdleAnimation()
    {
        _timeForSecondIdleAnimation = 30f;

        _animator.SetTrigger("UseSecondIdleAnimation");
    }    

}
