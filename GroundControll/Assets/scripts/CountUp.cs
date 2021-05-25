using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountUp : MonoBehaviour
{
    public Text Counter;
    protected int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Counter.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Counter.text = "" + Score;
    }
}
