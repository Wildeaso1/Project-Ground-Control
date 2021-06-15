using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public float AsteroidHPSmallDeath;
    public float AsteroidHPSmall;
    public float AsteroidHPSmallV;
    public float AsteroidHPSmallMax;
    public AsteroidHealthBar asteroidHealthBar;
    public Rigidbody2D _rigidbody;

    private void Start()
    {
        AsteroidHPSmallDeath = AsteroidHPSmallMax / AsteroidHPSmallMax;
        AsteroidHPSmall = AsteroidHPSmallMax;
        AsteroidHPSmallV = AsteroidHPSmallMax;
        asteroidHealthBar.SetMaxHealth(AsteroidHPSmallMax);
    }

    private void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            StartCoroutine(FreezeFrame());
            TakeDamage(1);
            AsteroidHPSmallV = Mathf.Lerp(AsteroidHPSmallV, AsteroidHPSmall, 5f) * Time.deltaTime;
        }
    }

    private void TakeDamage(int Damage)
    {

         AsteroidHPSmall -= Damage;
         asteroidHealthBar.SetHealth(AsteroidHPSmallV);
    }

    public void FreezeFrame2()
    {
        _rigidbody.bodyType = RigidbodyType2D.Kinematic;
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
    }

    IEnumerator FreezeFrame()
    {
        var SaveVelocity = _rigidbody.velocity;
        var SaveAngularVelocity = _rigidbody.angularVelocity;
        _rigidbody.bodyType = RigidbodyType2D.Kinematic;
        yield return new WaitForSecondsRealtime(1);
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
    }

}
