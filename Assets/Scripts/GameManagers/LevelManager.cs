using Entity.Pets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManagers {
    public class LevelManager : MonoBehaviour {

        public static LevelManager instance;

        [SerializeField] private Pet pet;

        private void Awake() {
            instance = this;
        }

        public GameObject GetPet() {
            return pet.gameObject;
        }


    }
}
