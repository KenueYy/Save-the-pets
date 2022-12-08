using GameManagers;
using GameManagers.Interfaces;
using System;
using UnityEngine;

namespace UI.LevelList {
    internal class LevelClickCallback : MonoBehaviour {

        public event Action<int> onLevelClicked;

        [SerializeField]
        private LevelListUI levelList;

        private ILoadLevel _gameManager;

        private void OnEnable() {
            _gameManager = FindObjectOfType<GameManager>().GetComponent<ILoadLevel>();
            levelList.onItemClicked.AddListener(OnLevelItemClicked);
            onLevelClicked += _gameManager.LoadLevel;
        }

        private void OnDisable() {
            onLevelClicked -= _gameManager.LoadLevel;
        }

        private void OnLevelItemClicked(string levelIndex) {
            onLevelClicked?.Invoke(int.Parse(levelIndex));
        }
    }
}

