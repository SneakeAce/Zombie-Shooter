using System.Collections;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class Weapon : MonoBehaviour
{
    [Header("Main parameters weapon")]
    [SerializeField] protected WeaponConfig _weaponConfig;
    [SerializeField] protected int _maxMagazineCapacity;
    protected int _currentMagazineCapacity;
    protected int _currentReleasedBulletAtTime = 1;

    [Header("Delay before firing")]
    private const float MinDelayBeforeFiring = 0.1f;
    [SerializeField] protected float _delayBeforeFiring;
    [SerializeField] protected float _startDelayBeforeFiring;

    protected bool _isReloading;
    protected Unit _character;

    protected Coroutine _reloadingWeaponCoroutine;

    public WeaponConfig WeaponConfig => _weaponConfig;

    public void Initialize(Unit character)
    {
        _character = character;

        _currentMagazineCapacity = _maxMagazineCapacity;

        _startDelayBeforeFiring = MinDelayBeforeFiring;
        _delayBeforeFiring = _startDelayBeforeFiring;
    }

    protected virtual void Update()
    {
        if (_delayBeforeFiring > 0)
            _delayBeforeFiring -= Time.deltaTime;

        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButton(0)) && _delayBeforeFiring <= 0 && _currentMagazineCapacity > 0)
        {
            _character.Animator.SetTrigger("Firing");

            Shooting();
        }
        else if (_currentMagazineCapacity == 0 && _isReloading == false)
        {
            _isReloading = true;
            Debug.Log("Update Weapon Start Reloading");
            if (_reloadingWeaponCoroutine != null)
            {
                StopCoroutine(_reloadingWeaponCoroutine);
                _reloadingWeaponCoroutine = null;
            }

            _reloadingWeaponCoroutine = StartCoroutine(ReloadingJob(WeaponConfig.WeaponStatsConfig.ReloadingTime));
        }

        // �������� ����� ��� �������� � ������� ��������, ���������� ��������� � ���������� ��������. ����� Enum � ������� �������
    }

    protected abstract IEnumerator PrepareWeaponToShootingJob(); // ��� �������� ���������� ������ � ��������
    protected abstract void Shooting(); // ��� �������� � �������� ��������
    protected abstract IEnumerator ReloadingJob(float timeReload); // ��� �������� ����������� 

}
