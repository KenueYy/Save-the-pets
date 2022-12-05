using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelClick : MonoBehaviour, IPointerClickHandler {
    public event Action onEmptyPanelClick;
    public void OnPointerClick(PointerEventData eventData) {
        onEmptyPanelClick?.Invoke();
    }
}
