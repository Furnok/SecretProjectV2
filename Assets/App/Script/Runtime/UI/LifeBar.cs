using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : VisualUpdater<SLife>
{
    [Title("Reference")]
    [SerializeField] private Image[] hearts;

    [SerializeField] Sprite emptyHeart;
    [SerializeField] Sprite fullHeart;

    protected override void UpdateBar()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < rso.Value.CurrentLife)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}