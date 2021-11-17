using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedData : MonoBehaviour
{
    public static SavedData Instance;

    public string playerName;

    public int bestScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    //Method to save json of best player name and score

    //Method to retrieve json best player name and score
}
