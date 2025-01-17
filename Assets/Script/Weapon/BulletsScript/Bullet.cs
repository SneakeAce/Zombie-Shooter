using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private MoveBullet _moveBullet;

    protected float _damage;

    public Rigidbody Rigidbody { get => _rigidbody; }

    public void InitializeBullet(Vector3 startPoint, float distanceFlying, float bulletDamage)
    {
        _damage = bulletDamage;
        _moveBullet.Initialize(this, startPoint, distanceFlying);
    }

    public virtual void DamageDeal()
    {
        //������� �����, ������� ������� ����, � ������������ � ������.
    }

    // ���, ������� �������� �� ������������ � �������������.

}
