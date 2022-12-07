using System.Collections.Generic;
using UI.ScrollContainer;
using UnityEngine;

namespace UI.LevelList {
    internal class LevelListUI : BaseLevelScrollContainer<LabelScrollContainerItem, string, string> {
        [SerializeField]
        private List<GameObject> levels;

        protected override void OnCreateAllItems() {
            base.OnCreateAllItems();
            for (int i = 0; i < levels.Count; i++) {
                AddItem(i.ToString());
            }
        }
    }
}
