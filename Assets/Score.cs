using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text myText;
    int points;

    public int Points
    {
        get { return points; }
        set { points = value; myText.text = Points.ToString(); }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
     
    }
}
