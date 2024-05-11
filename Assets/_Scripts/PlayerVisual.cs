using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{

    [SerializeField] MeshRenderer headMeshRenderer;
    [SerializeField] MeshRenderer bodyMeshRenderer;
    [SerializeField] TextMeshPro playerName;


    Material material;

    private void Awake()
    {
        material = new Material(headMeshRenderer.material);
        headMeshRenderer.material = material;
        bodyMeshRenderer.material = material;
    }

    public void SetPlayerColor(Color color)
    {
        material.color = color;
    }

    public void SetName(string text)
    {
        playerName.text = text;
    }
}
