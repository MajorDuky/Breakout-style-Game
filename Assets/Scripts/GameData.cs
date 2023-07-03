using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameData : MonoBehaviour
{
    public static GameData Instance { get; private set; }
    public string TopPlayerUsername;
    public string ActualPlayerName;
    public int HighScore;
    [SerializeField] private string savefile = "/savefile.json";

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        Instance.ActualPlayerName = "Name";
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    public void SaveHighScore(int score)
    {
        if (score > HighScore)
        {
            string path = Application.persistentDataPath + savefile;
            SaveData data = new SaveData();
            data.HighScore = score;
            data.Username = ActualPlayerName;

            string json = JsonUtility.ToJson(data);
            File.WriteAllText(path, json);
        }
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + savefile;
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            TopPlayerUsername = data.Username;
            HighScore = data.HighScore;
        }
    }
    
    [System.Serializable]
    public class SaveData
    {
        public int HighScore;
        public string Username;
    }
    
}
