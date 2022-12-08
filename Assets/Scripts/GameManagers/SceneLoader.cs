using Enums;
using GameManagers.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameManagers.Interfaces {
    internal class SceneLoader : MonoBehaviour, ISceneLoader {
        public void LoadScene(Scenes scene) {
            SceneManager.LoadScene((int)scene);
        }

        public void LoadSceneIfNeeded(Scenes scene) {

            if (SceneManager.GetActiveScene().buildIndex == (int)scene) {
                return;
            }

            LoadScene(scene);
        }
    }
}
