using UnityEngine;

namespace Feif.UI
{
    [RequireComponent(typeof(RectTransform))]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    public abstract class AdapterBase : MonoBehaviour
    {
        public abstract void Adapt();
    }
}