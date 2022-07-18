using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using TMPro;


public class UIHandler : MonoBehaviour
{
    public TMP_InputField PlayerName;
    public GameObject PlayerNameWarning;
    public void StartNew()
    {
        var text = PlayerName.text;
        if (string.IsNullOrEmpty(text))
        {
            PlayerNameWarning.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
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
