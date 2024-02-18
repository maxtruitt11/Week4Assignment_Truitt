using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mole : MonoBehaviour
{
    Score myScore;
    [SerializeField] Button moleButton;

    void Start()
    {
        myScore = FindObjectOfType<Score>();
        moleButton.onClick.AddListener(Click);
    }

    void Click()
    {
        myScore.Points += 1;
    }
}
