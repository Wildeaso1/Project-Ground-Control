using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountUp : MonoBehaviour
{
    public static int ScoreValue;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        ScoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "" + ScoreValue;
    }
}
