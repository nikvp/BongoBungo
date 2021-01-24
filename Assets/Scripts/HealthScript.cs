using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthScript : MonoBehaviour
{
    public int health;
    public Text healthText;


    void Update()
    {
        healthText.text = "HEALTH: " + health;
    }
}
