using UnityEngine;
using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
    public class BaseComponent<T> : MonoBehaviour where T : Selectable
    {
        public  T Component { get => _component; private set => _component = value; }
        private T _component;

        protected virtual void Awake()
        {
            Component = GetComponent<T>();
        }
    }
}