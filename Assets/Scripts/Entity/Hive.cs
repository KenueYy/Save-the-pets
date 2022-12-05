using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.ObjectPooller;

public class Hive : MonoBehaviour
{
    [SerializeField]
    private PoolObject poolObject;
    private void Start() {
        Spawner.instance.PreparationPool(poolObject);
        StartCoroutine(nameof(SpawnCorutine));
    }

    private IEnumerator SpawnCorutine() {
        for(uint i = 0; i < poolObject.poolCount; i++) {
            Spawner.instance.SpawnObject(poolObject);
            yield return new WaitForSeconds(1);
        }
    }
}
