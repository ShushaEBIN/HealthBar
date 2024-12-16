using System;
using UnityEngine;
using UnityEngine.UI;

public class Healher : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private int minHealth = 1;
    [SerializeField] private int maxHealth = 50;

    public int Health { get; private set; }

    public event Action Healthed;

    private void OnEnable()
    {
        _button.onClick.AddListener(GiveHeal);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(GiveHeal);
    }

    private void GiveHeal()
    {
        Health = UnityEngine.Random.Range(minHealth, maxHealth + 1);

        Healthed?.Invoke();
    }
}