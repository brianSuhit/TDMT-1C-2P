using UnityEngine;
using UnityEngine.UI;

public class HealthPointsBar : MonoBehaviour
{
    [SerializeField] private Image bar;

    [SerializeField] private HealthPoints healthPoints;

    private void Update()
    {
        bar.fillAmount = 1.0f * healthPoints.health / healthPoints.maxHealth;
    }
}
