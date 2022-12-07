using System;
using UnityEngine;

namespace UI.LevelList {
    internal class LevelClickCallback : MonoBehaviour {
        [SerializeField]
        private LevelListUI levelList;

        public event Action<int> onLevelClicked;

        private void Awake() {
            levelList.onItemClicked.AddListener(OnLevelItemClicked);
        }

        private void OnLevelItemClicked(string levelIndex) {
            onLevelClicked?.Invoke(int.Parse(levelIndex));
        }
    }
}

