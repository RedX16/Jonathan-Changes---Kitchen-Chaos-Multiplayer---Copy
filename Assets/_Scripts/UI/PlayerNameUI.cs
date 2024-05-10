using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;

public class PlayerNameUI : MonoBehaviour
{
    [SerializeField] TextMeshPro playerNameText;
    [SerializeField] int playerIndex;

    private void Start()
    {
        //UpdatePlayer();
        UpdatePlayerNameServerRpc();
        KitchenGameMultiplayer.Instance.OnPlayerDataNetworkListChanged += KitchenGameMultiplayer_OnPlayerDataNetworkListChange;
        CharacterSelectReady.Instance.OnReadyChanged += CharacterSelectReady_OnReadyChanged;
    }

    private void CharacterSelectReady_OnReadyChanged(object sender, System.EventArgs e)
    {
        //UpdatePlayer();
        UpdatePlayerNameServerRpc();
    }

    private void KitchenGameMultiplayer_OnPlayerDataNetworkListChange(object sender, System.EventArgs e)
    {
        //UpdatePlayer();
        UpdatePlayerNameServerRpc();
    }

    /* void UpdatePlayer()
     {
         if (KitchenGameMultiplayer.Instance.IsPlayerIndexConnected(playerIndex))
             {
                 PlayerData playerData = KitchenGameMultiplayer.Instance.GetPlayerDataFromPlayerIndex(playerIndex);
                 playerNameText.text = playerData.playerName.ToString();
             }
         }*/

    [ServerRpc(RequireOwnership = false)]
    void UpdatePlayerNameServerRpc()
    {
        UpdatePlayerNameClientRpc();
    }

    [ClientRpc]
    void UpdatePlayerNameClientRpc()
    {
        playerNameText.text = KitchenGameMultiplayer.Instance.GetPlayerName();
    }

}
