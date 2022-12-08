using UnityEngine;

namespace UI.LevelList {

    [RequireComponent(typeof(LevelClickCallback))]
    internal class LevelClickHandler : MonoBehaviour {
        private LevelClickCallback _levelClickCallback => GetComponent<LevelClickCallback>();

        private void Awake() {
            _levelClickCallback.onLevelClicked += Action;
        }

        private void Action(int index) {
            Debug.Log($"Загружаю {index} уровень");

        }
    }
}
