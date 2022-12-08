using Enums;
using GameManagers.Interfaces;
using System.Collections.Generic;
using UI.LevelList;
using UnityEngine;

namespace GameManagers {

    internal class GameManager : MonoBehaviour, ILevelList, ILoadLevel {
        [SerializeField]
        private List<GameObject> levels = new List<GameObject>();
        private SceneLoader _sceneLoader => GetComponentInChildren<SceneLoader>();

        private int _loadLevel;

        #region ILevelList

        public List<GameObject> GetLevelList() {
            return levels;
        }

        public GameObject GetLevel(int level) {
            return levels[level];
        }

        #endregion

        #region ILoadLevel

        public int GetLoadedLevel() {
            return _loadLevel;
        }
        public void LoadLevel(int level) {
            _loadLevel = level;
            _sceneLoader.LoadSceneIfNeeded(Scenes.Game);
        }

        #endregion

        #region Monobehaviour

        private void Awake() {
            DontDestroyOnLoad(gameObject);
        }

        #endregion
    }
}
