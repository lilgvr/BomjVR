using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    public BalanceManager balanceManager;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag) {
            case "jar":
                balanceManager.Add(50);
                break;
            case "bottle":
                balanceManager.Add(100);
                break;
        }

        Destroy(other.gameObject);
    }
}
