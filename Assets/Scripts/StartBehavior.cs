using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartBehavior : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputField;
    public void OnClick()
    {
        GameData.Instance.ActualPlayerName = InputField.text;
        SceneManager.LoadScene(1);
    }
}
