using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour {
    
    //Todo Допилить интерфейс чтобы с поинтер хендлера тоже можно было получать позицию и хранить в одном объекте
    public static Vector3 GetPointerPosition2D() {
        Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vector.z = 0;
        return vector;
    }
}
