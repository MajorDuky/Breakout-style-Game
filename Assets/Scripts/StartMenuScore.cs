using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartMenuScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameData.Instance.LoadHighScore();
        if (GameData.Instance.HighScore != 0)
        {
            gameObject.GetComponent<TMP_Text>().text = $"Best Score : {GameData.Instance.TopPlayerUsername} : {GameData.Instance.HighScore}";
        }
        else 
        {
            gameObject.SetActive(false);
        }  
    }
}
