using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Text text;

    public void setHealth(int health)
    {
        text.text = "Pontos de vida: " + health;
    }
}
