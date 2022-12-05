using Entity.Pets;
using UnityEngine;

public class LevelManager : MonoBehaviour { 

    public static LevelManager instance;

    [SerializeField] private Pet pet;

    private void Awake() {
        instance = this;
    }

    public GameObject GetPet() {
        return pet.gameObject;
    }


}
