using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatteredDebris : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CountUp.ScoreValue += 1;
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
