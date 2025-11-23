using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    private TextMeshProUGUI moneyText;

    private void Start()
    {
        moneyText = GetComponent<TextMeshProUGUI>();
        ResourceManager.RM.OnMoneyChanged += UpdateUI;
        UpdateUI(ResourceManager.RM.Money);
    }

    private void UpdateUI(int value)
    {
        moneyText.text = "$" + value;
        Debug.unityLogger.Log("Money UI updated: $" + value);
    }

    private void OnDestroy()
    {
        // Avoid errors when changing scenes
        if (ResourceManager.RM != null)
            ResourceManager.RM.OnMoneyChanged -= UpdateUI;
    }
}