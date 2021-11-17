using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    InputField iField;

    string playerName;

    private void Start()
    {
        iField = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void PlayBtnClicked()
    {
        
        playerName = iField.text;
        SavedData.Instance.playerName = playerName;
        SceneManager.LoadScene(1);

    }
    
}
