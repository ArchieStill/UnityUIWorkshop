using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemText : MonoBehaviour
{
    public GameObject blueText;
    public GameObject redText;
    public GameObject greenText;
    public GameObject yellowText;
    public GameObject purpleText;
    public GameObject orangeText;

    public void textActive(int id)
    {
        TextColour colour = (TextColour)id;

        switch (colour)
        {
            case TextColour.BLUE:
                blueText.SetActive(true);
                break;
            case TextColour.RED:
                redText.SetActive(true);
                break;
            case TextColour.GREEN:
                greenText.SetActive(true);
                break;
            case TextColour.YELLOW:
                yellowText.SetActive(true);
                break;
            case TextColour.PURPLE:
                purpleText.SetActive(true);
                break;
            case TextColour.ORANGE:
                orangeText.SetActive(true);
                break;
        }
    }

    public void textInactive(int id)
    {
        TextColour colour = (TextColour)id;

        switch (colour)
        {
            case TextColour.BLUE:
                blueText.SetActive(false);
                break;
            case TextColour.RED:
                redText.SetActive(false);
                break;
            case TextColour.GREEN:
                greenText.SetActive(false);
                break;
            case TextColour.YELLOW:
                yellowText.SetActive(false);
                break;
            case TextColour.PURPLE:
                purpleText.SetActive(false);
                break;
            case TextColour.ORANGE:
                orangeText.SetActive(false);
                break;
        }
    }

    [Serializable] public enum TextColour { BLUE = 1, RED = 2, GREEN = 3, YELLOW = 4, PURPLE = 5, ORANGE = 6 }
}
