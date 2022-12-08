using System.Collections.Generic;
using UnityEngine;

namespace GameManagers.Interfaces {

    interface ILevelList {
        public List<GameObject> GetLevelList();
        public GameObject GetLevel(int level);

    }
}
