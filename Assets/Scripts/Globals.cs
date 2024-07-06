using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Globals : MonoBehaviour
{
    public static Globals Instance;
    public string playerName;
    public string highScorePlayerName;
    public int highScore;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        LoadHighScore();
        
        if (highScore == 0)
        {
            highScore = 5;
            highScorePlayerName = "Nouge"; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    class SaveData 
    {
        public int highScore;
        public string highScorePlayerName;
    } 

    void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/highscoresave.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highScorePlayerName = data.highScorePlayerName;
        }
    }
}
