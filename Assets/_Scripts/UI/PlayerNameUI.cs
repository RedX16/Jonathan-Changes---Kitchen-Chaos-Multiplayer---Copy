using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public class PlayerNameUI : MonoBehaviour
{
    [SerializeField] TextMeshPro playerNameText;


    void UpdatePlayerName()
    {
        playerNameText.text = KitchenGameMultiplayer.Instance.GetPlayerName();
    }
}
