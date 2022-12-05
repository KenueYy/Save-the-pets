using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMoveController : MonoBehaviour
{
    private float _movementSpeed;
    private float _rotateSpeed= 5;

    private GameObject _target;
    private GameObject _moveObject;
    private Rigidbody2D _rb => GetComponentInParent<Rigidbody2D>();

    private void Update() {
        Vector2 direction = _target.transform.position - _moveObject.transform.position;

        _rb.AddForce(direction * _movementSpeed * Time.deltaTime, ForceMode2D.Impulse);
        _moveObject.transform.right = Vector2.MoveTowards(_moveObject.transform.right, direction, Time.deltaTime * _rotateSpeed);
    }

    public void Initialize(GameObject moveObject,GameObject target, float speed) {
        _target = target;
        _movementSpeed = speed;
        _moveObject = moveObject;
    }

}
