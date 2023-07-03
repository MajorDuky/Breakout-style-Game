using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckUsernameInput : MonoBehaviour
{
    [SerializeField] private Button button;
    public void OnValueChanged(string text)
    {
        button.interactable = text != null;
    }
}
