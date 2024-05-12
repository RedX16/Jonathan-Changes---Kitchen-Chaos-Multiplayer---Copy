using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    [SerializeField] TextMeshPro playerName;


    public void SetName(string text)
    {
        playerName.text = text;
    }
}
