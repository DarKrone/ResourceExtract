using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private TextMeshProUGUI _copperText;
    [SerializeField] private TextMeshProUGUI _ironText;

    private void Awake()
    {
        Instance = this;
        UpdateUI();
    }


    public void UpdateUI()
    {
        _copperText.text = "Copper: " + Storage.Instance.CheckResourceAmount(ResourceType.Copper);
        _ironText.text = "Iron: " + Storage.Instance.CheckResourceAmount(ResourceType.Iron);
    }
}
