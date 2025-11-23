using UnityEngine;
using System;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }

    [Header("Resources")]
    [SerializeField] private int money;

    // Event to notify UI or other systems
    public event Action<int> OnMoneyChanged;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public int Money => money;

    public void AddMoney(int amount)
    {
        money += amount;
        OnMoneyChanged?.Invoke(money);
    }

    public void SpendMoney(int amount)
    {
        if (money < amount)
            return;

        money -= amount;
        OnMoneyChanged?.Invoke(money);
    }
}