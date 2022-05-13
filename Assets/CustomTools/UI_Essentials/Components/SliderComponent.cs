using UnityEngine.UI;

namespace CustomTools.UI_Essentials.Components
{
    public abstract class SliderComponent : BaseComponent<Slider>
    {
        protected override void Awake()
        {
            base.Awake();
            Component.onValueChanged.AddListener(OnValueChanged);
        }

        protected abstract void OnValueChanged(float value);
    }
}