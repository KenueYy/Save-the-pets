using Entity.Pets.Interfaces;
using System;
using UnityEngine;

namespace Entity.Pets.Controllers {

    [RequireComponent(typeof(Collider2D))]
    public class BaseDamageController : MonoBehaviour, IDamageController {
        public event Action<Collision2D> onCollisionEnter;



        private void OnCollisionEnter2D(Collision2D other) {
            onCollisionEnter?.Invoke(other);
        }
    }
}
