using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 1.5f;
    private float xRange = 2.0f;
    public static int health = 3;          //puts Hp value to 3
    public TextMeshProUGUI healthUI;       //puts public field for canvas value
    public static int score = 0;           //Score System  
    public TextMeshProUGUI Cscore;         //Score text

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Score System
        Cscore.text = "Current Score is :" + score.ToString();
        //Health System
        healthUI.text = "Remaining Health is : " + health.ToString();
        //prevent health from going zero
        if (health < 1)
        {
            health = 0;
        }
        //adds an input limit to prevent going too left using xRange -ve for left and +ve for right
        if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            //Horizontal Input initialization
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Time.timeScale = 0.5f;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                health--;
            }
        if (collision.gameObject.tag == "Life")
        {
            health++;
            Destroy(collision.gameObject);
        }


        if (collision.gameObject.tag == "Coin")
        {
            score++;
            Destroy(collision.gameObject);
        }
    }
         void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
                Time.timeScale = 1.0f;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
            }
         }
    }

