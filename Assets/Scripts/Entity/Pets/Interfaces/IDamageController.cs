using System;
using UnityEngine;

namespace Entity.Pets.Interfaces {
    interface IDamageController {
        event Action<Collision2D> onCollisionEnter;
    }
}
