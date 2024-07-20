using UnityEngine;
using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
    public class BaseComponent<T> : MonoBehaviour where T : Selectable
    {
        public  T Component { get; private set; }

        protected virtual void Awake()
        {
            Component = GetComponent<T>();
        }
    }
}