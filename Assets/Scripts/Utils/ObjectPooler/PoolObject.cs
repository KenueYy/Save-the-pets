using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.ObjectPooller {

    [CreateAssetMenu(menuName = "CustomObject/PoolObject")]
    public class PoolObject : ScriptableObject {

        public GameObject prefab;
        public int poolCount;
        public bool autoExpand;

    }
}