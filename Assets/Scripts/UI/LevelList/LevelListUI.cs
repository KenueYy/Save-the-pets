using GameManagers;
using GameManagers.Interfaces;
using System.Collections.Generic;
using UI.ScrollContainer;
using UnityEngine;

namespace UI.LevelList {

    internal class LevelListUI : BaseLevelScrollContainer<LabelScrollContainerItem, string, string> {

        private List<GameObject> _levels;
        private ILevelList _levelList => FindObjectOfType<GameManager>().GetComponent<ILevelList>();

        private void Awake() {
            _levels = _levelList.GetLevelList();
        }

        protected override void OnCreateAllItems() {
            base.OnCreateAllItems();
            for (int i = 0; i < _levels.Count; i++) {
                AddItem(i.ToString());
            }
        }
    }
}
