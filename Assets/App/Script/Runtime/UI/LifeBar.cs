using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : VisualUpdater<SLife>
{
    [Title("Reference")]
    [SerializeField] private Slider slider;
    
    protected override void UpdateBar()
    {
        slider.value = rso.Value.CurrentLife / rso.Value.MaxLife;
    }
}