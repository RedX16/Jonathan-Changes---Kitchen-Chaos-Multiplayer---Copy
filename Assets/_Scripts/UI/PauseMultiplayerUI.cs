using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMultiplayerUI : MonoBehaviour
{

    private void Start()
    {
        KitchenGameManager.Instance.OnMultiplayerGamePaused += KitchenManager_OnMultiplayerGamePaused;
        KitchenGameManager.Instance.OnMultiplayerGameUnpaused += KitchenManager_OnMultiplayerGameUnpaused;

        Hide();
    }

    private void KitchenManager_OnMultiplayerGameUnpaused(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void KitchenManager_OnMultiplayerGamePaused(object sender, System.EventArgs e)
    {
        Show();
    }

    void Show()
    {
        gameObject.SetActive(true);
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }
}
