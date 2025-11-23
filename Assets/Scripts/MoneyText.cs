using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{

    private void Start()
    {
        // Subscribe to changes
        ResourceManager.Instance.OnMoneyChanged += UpdateUI;

        // Initialize UI with current money
        UpdateUI(ResourceManager.Instance.Money);
    }

    private void UpdateUI(int value)
    {
        GetComponent<TextMeshPro>().text = "$" + value;
    }

    private void OnDestroy()
    {
        // Avoid errors when changing scenes
        if (ResourceManager.Instance != null)
            ResourceManager.Instance.OnMoneyChanged -= UpdateUI;
    }
}