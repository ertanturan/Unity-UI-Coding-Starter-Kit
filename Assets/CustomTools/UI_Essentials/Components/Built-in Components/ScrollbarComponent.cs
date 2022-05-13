using UnityEngine;

namespace CustomTools.UI_Essentials.Components
{
    using UnityEngine.UI;

    [RequireComponent(typeof(Scrollbar))]
    public abstract class ScrollbarComponent : BaseComponent<Scrollbar>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
        }

        protected abstract void OnValueChanged(float value);
    }
}