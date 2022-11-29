using Entity.Pets.Controllers;
using Entity.Pets.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity.Pets {
    public class Pet : MonoBehaviour {

        [SerializeField]
        private PetObject pet;

        private BaseHealthController _healthController;
        private IHealthView _healthView;

        private void Awake() {

            _healthController = GetComponentInChildren<BaseHealthController>();
            _healthView = GetComponentInChildren<IHealthView>();
            _healthController.Initialize(pet);

        }

        private void OnDestroy() {
            Debug.Log(_healthView.CurrentHealth);
        }

    }
}
