using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class MenuManager : MonoBehaviour
{

    
    public TMP_InputField inputField;
    public TMP_Text HighScore;
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {

        {
            HighScoreTable.Instance.LoadHighScoreData();
            HighScore.text = "Best Score: " + HighScoreTable.Instance.bestPlayer + ": " + HighScoreTable.Instance.bestScore;
        }

    }




    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerName()
    {
        playerName = inputField.text;
        HighScoreTable.Instance.playerName = playerName;
    }


    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }


    public void Exit()
        
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        
    }

}
