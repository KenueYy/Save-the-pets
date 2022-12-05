using Entity.Pets.Interfaces;
using UnityEngine;

namespace Entity.Pets.Controllers {
    public class BaseHealthController : MonoBehaviour, IHealthView {

        public float CurrentHealth => _currentHealth;
        public float MaxHealth => _maxHealth;


        private float _currentHealth;
        private float _maxHealth;


        private IDamageController _damageController;


        public void Initialize(PetObject data) {
            _maxHealth = data.maxHealth;
            _currentHealth = _maxHealth;
        }

        private void Damage(Collision2D entity) {
            //TODO Получать компонент с уроном из коллайдера атакующего
            
            var enemy = entity.gameObject.GetComponent<IDamageDealer>();
            if (enemy == null) {
                return;
            }

            _currentHealth -= enemy.GetDamage();
        }

        private void Awake() {
            _damageController = GetComponent<BaseDamageController>();
            _damageController.onCollisionEnter += Damage;
        }
    }
}
