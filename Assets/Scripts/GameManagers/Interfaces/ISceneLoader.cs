
using Enums;
using UnityEngine.SceneManagement;

namespace GameManagers.Interfaces {
    interface ISceneLoader {
        public void LoadScene(Scenes scene);
        public void LoadSceneIfNeeded(Scenes scene);
    }
}
