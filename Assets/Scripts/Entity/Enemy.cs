using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour, IDamageDealer {

    [SerializeField]
    private EnemyObject data;

    [SerializeField]
    private GameObject _target;

    private float _damage => data.Damage;
    private float _speed => data.Speed;

    private BaseMoveController _moveController => GetComponentInChildren<BaseMoveController>();

#region IDamageDealer 

    public float GetDamage() {
        return _damage;
    }

#endregion

    private void Awake() {
        Initialize();
    }

    private void Initialize() {
        _moveController.Initialize(gameObject, _target, _speed);
    }

}
