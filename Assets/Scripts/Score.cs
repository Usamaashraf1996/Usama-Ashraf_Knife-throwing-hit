using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI sCORE;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        

    }
    

    // Update is called once per frame
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        sCORE.text = "SCORE: " + score.ToString();
        Debug.Log(score.ToString());
       
        score+=1;
    }
}
