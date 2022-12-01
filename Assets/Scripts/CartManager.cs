using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    public BalanceManager balanceManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            balanceManager.Add(100);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            balanceManager.Remove(100);
        }
    }
}
