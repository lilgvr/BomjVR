using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BalanceManager : MonoBehaviour
{
    public int balanceValue { get; set; }
    public TextMeshPro balanceText;

    // Start is called before the first frame update
    void Start()
    {
        balanceText.text = balanceValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add(int newValue)
    {
        balanceValue += newValue;
        balanceText.text = balanceValue.ToString();
    }

    public void Remove(int newValue)
    {
        if (balanceValue - newValue < 0)
        {
            balanceValue = 0;
        } else
        {
            balanceValue -= newValue;
        }
        balanceText.text = balanceValue.ToString();
    }
}
