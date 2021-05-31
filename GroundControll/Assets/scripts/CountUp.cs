using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountUp : MonoBehaviour
{
    public static int ScoreIron;
    public static int ScoreCobalt;
    public static int ScoreGold;
    public Text TextIron;
    public Text TextGold;
    public Text TextCobalt;
    // Start is called before the first frame update
    void Start()
    {
        TextIron = GetComponent<Text>();
        ScoreIron = 0;
        ScoreCobalt = 0;
        ScoreGold = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextIron.text = "" + ScoreIron;
        TextGold.text = "" + ScoreGold;
        TextCobalt.text = "" + ScoreCobalt;
    }
}
