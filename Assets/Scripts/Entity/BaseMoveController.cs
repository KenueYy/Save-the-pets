using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMoveController : MonoBehaviour
{
    private float _speed;

    private GameObject _target;
    private GameObject _moveObject;

    private void Update() {
        _moveObject.transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public void Initialize(GameObject moveObject,GameObject target, float speed) {
        _target = target;
        _speed = speed;
        _moveObject = moveObject;
    }

}
