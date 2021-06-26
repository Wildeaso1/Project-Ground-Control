using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    // Variablen voor het ship
    public float thrustSpeed = 15.0f;
    public float thrustSpeedBackwards = -0.5f;
    public float rotationSpeed = 3.0f;
    private Rigidbody2D _rigidbody;
    private bool _thrusting;
    private bool _thrustingBack;
    private float _turnDirection;
    public AudioSource Shooting;
    public GameObject Map;
    public GameObject TargetIndicators;
    private bool Pause = false;
    public GameObject Waypoints;
    public Vector3 Position;
    [SerializeField]private GameObject Fire;
    

    // Shooting sound effect
    public void ShootingEffect()
    {
        Shooting.Play();
        
    }


    // Rigidbody
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Fire.SetActive(false);
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));
    }

    // Sideways Movement
    void Update()
    {
        SavingPosition();

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _turnDirection = 1.0f;
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _turnDirection = -1.0f;
        }

        else
        {
            _turnDirection = 0.0f;
        }


        if (Input.GetKey(KeyCode.W))
        {
            Fire.SetActive(true);
        }
        else
        {
            Fire.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (Pause)
            {
                MapResume();
            }

            else
            {
                MapPause();
            }
        }
    }


    public void MapResume()
    {
        Map.SetActive(false);
        Time.timeScale = 1f;
        Pause = false;
        TargetIndicators.SetActive(false);
        Waypoints.SetActive(false);
    }

    public void MapPause()
    {
        Map.SetActive(true);
        Time.timeScale = 0f;
        Pause = true;
        TargetIndicators.SetActive(true);
        Waypoints.SetActive(true);
    }

    private void FixedUpdate()
    {
        // Movement Up, Down and Rotation
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(transform.up * thrustSpeed);
            
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
          _rigidbody.AddForce(transform.up /thrustSpeedBackwards);
        }


        if (_turnDirection != 0.0f)
        {
            _rigidbody.AddTorque(rotationSpeed * _turnDirection);
        }
    }


    // Score updaten met de juiste ores die je oppakt
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Cobalt":
                Inventory.ScoreCobalt += 1;
                Destroy(collision.gameObject);
                break;
            case "Iron":
                Inventory.ScoreIron += 1;
                Destroy(collision.gameObject);
                break;
            case "Gold":
                Inventory.ScoreGold += 1;
                Destroy(collision.gameObject);
                break;
            default:
                break;
        }
    }

    public void SavingPosition()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
    }
    private void OnApplicationQuit()
    {
        //SaveManager.DeleteSave();
    }
}
