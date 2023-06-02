using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text mytext;
    public int scorepoints;
    public void Scoreupdate(int score)
    {
        scorepoints += score;
        mytext.text = scorepoints.ToString("0");
    }
}
