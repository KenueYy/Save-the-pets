using Entity.Enemy.Controllers;
using Entity.Enemy.Interfaces;
using Entity.Enemy.Scriptable;
using UnityEngine;

namespace Entity.Enemy {

    public class Enemy : MonoBehaviour, IDamageDealer {

        [SerializeField]
        private EnemyObject data;

        private BaseMoveController _moveController => GetComponentInChildren<BaseMoveController>();

        #region IDamageDealer 

        public float GetDamage() {
            return data.Damage;
        }

        #endregion

        private void OnEnable() {
            GameObject target = LevelManager.instance.GetPet();
            Initialize(target);
        }

        private void Initialize(GameObject target) {
            _moveController.Initialize(gameObject, target, data.MovementSpeed, data.RotationSpeed);
        }

    }
}
