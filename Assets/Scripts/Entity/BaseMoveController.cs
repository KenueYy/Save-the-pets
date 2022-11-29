using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMoveController : MonoBehaviour
{
    [SerializeField] 
    private float speed;

    [SerializeField]
    private GameObject _target;

    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, speed * Time.deltaTime);
    }

    public void Initialize(GameObject target) {
        _target = target;
    }

}
