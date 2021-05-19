using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountUp : MonoBehaviour
{
    public Text Counter;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        Counter.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.name == "Debris(Clone)")
        {
            Score = Score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Counter.text = "" + Score;
    }
}
