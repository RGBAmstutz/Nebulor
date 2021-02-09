using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    TMP_Text healthText;
    Player player;
    
    void Start()
    {
        healthText = GetComponent<TMP_Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        Health();
    }

    private void Health()
    {
        if (player.GetHealth() <= 0)
        {
            healthText.text = "0";
        }
        else
        {
            healthText.text = player.GetHealth().ToString();
        }
    }
}
