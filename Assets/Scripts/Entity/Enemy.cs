using Entity.Pets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour, IDamageDealer {

    [SerializeField]
    private EnemyObject data;

    private float _damage => data.Damage;
    private float _speed => data.Speed;

    private BaseMoveController _moveController => GetComponentInChildren<BaseMoveController>();

#region IDamageDealer 

    public float GetDamage() {
        return _damage;
    }

#endregion

    private void OnEnable() {
        GameObject target = LevelManager.instance.GetPet();
        Initialize(target);
    }

    private void Initialize(GameObject target) {
        _moveController.Initialize(gameObject, target, _speed);
    }

}
