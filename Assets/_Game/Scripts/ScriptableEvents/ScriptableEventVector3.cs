using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;

namespace DefaultNamespace.ScriptableEvents
{
    [CreateAssetMenu(fileName = "new ScriptableEventVec3", menuName = "ScriptableObjects/ScriptableEvent-Vec3",
        order = 1)]
    public class ScriptableEventVector3 : ScriptableEvent<Vector3>
    {

    }
}
