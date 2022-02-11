using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public float score;
    public TMP_Text scoreTxt;
    public static ScoreManager mg;
    private void Start()
    {
        if (ScoreManager.mg == null) 
        {
            ScoreManager.mg = this;
        }
        else { Destroy(ScoreManager.mg);  }
    }
    private void Update()
    {
        scoreTxt.text = score.ToString();
    }
}
