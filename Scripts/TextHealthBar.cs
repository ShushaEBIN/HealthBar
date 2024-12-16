using UnityEngine;
using UnityEngine.UI;

public class TextHealthBar : HealthBar
{
    [SerializeField] private Text _healthBar;   

    protected override void ChangeValue()
    {
        _currentHealth = _health.CurrentHealth;

        _healthBar.text = $"��������: {_currentHealth}/{_maxHealth}";
    }
}