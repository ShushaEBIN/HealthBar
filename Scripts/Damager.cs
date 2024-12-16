using System;
using UnityEngine;
using UnityEngine.UI;

public class Damager : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private int minDamage = 1;
    [SerializeField] private int maxDamage = 50;

    public int Damage { get; private set; }

    public event Action Damaged;

    private void OnEnable()
    {
        _button.onClick.AddListener(GiveDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(GiveDamage);
    }

    private void GiveDamage()
    {
        Damage = UnityEngine.Random.Range(minDamage, maxDamage + 1);
        
        Damaged?.Invoke();
    }
}