using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity.Enemy.Scriptable {

    [CreateAssetMenu]
    public class EnemyObject : ScriptableObject {
        public float Damage;
        public float MovementSpeed;
        public float RotationSpeed;

    }
}
