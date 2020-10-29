using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    public Text text;

    public void setPoints(int points)
    {
        text.text = "Pontuação atual: " + points;
    }
}
