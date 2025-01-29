using System;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerHp = 100;
    public TMP_Text playerHpText;

    void Start() {
        playerHpText.text = playerHp.ToString();
    }

    public void TakeDamage(int amount) {
        playerHp -= amount;
        UpdateUI();
    }

    void UpdateUI() {
        playerHpText.text = playerHp.ToString();
    }
}
