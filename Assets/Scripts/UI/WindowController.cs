using UnityEngine;
using UnityEngine.UI;

namespace UI {
    public class WindowController : MonoBehaviour {
        [SerializeField]
        private GameObject window;

        [SerializeField]
        private Button closeButton;

        [SerializeField]
        private Button openButton;

        private PanelClick _closePanel => GetComponentInChildren<PanelClick>(true);

        #region MonoBehaviour

        private void Awake() {
            closeButton.onClick.AddListener(Close);
            openButton.onClick.AddListener(Open);
            _closePanel.onEmptyPanelClick += Close;
        }
        private void OnDisable() {
            _closePanel.onEmptyPanelClick -= Close;
        }
        #endregion

        private void Open() {
            window.SetActive(true);
        }

        private void Close() {
            window.SetActive(false);
        }
    }
}
