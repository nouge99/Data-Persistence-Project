using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] TMP_InputField nameField;
    [SerializeField] GameObject noNameError;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        if (nameField.text != "What's your name?")
        {
            Globals.Instance.playerName = nameField.text;
            SceneManager.LoadScene(1);
        }
        else
        {
            noNameError.gameObject.SetActive(true);
        }
    }
}
