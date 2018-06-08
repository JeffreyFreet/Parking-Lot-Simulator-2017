using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectTrigger : MonoBehaviour
{
    public Text timer;
    public Text gameoverPrompt;
    public GameObject winSpot;
    private float time = 45;
    private bool winCondition = false;
    private bool loss = false;
    private float carHitTime = 0;
    private float pedHitTime = 0;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        carHitTime += Time.deltaTime;
        pedHitTime += Time.deltaTime;
        //Debug.Log(carHitTime);
        //Debug.Log(pedHitTime);

        if (winCondition == false)
        {
            if (time <= 0)
            {
                loss = true;
                gameoverPrompt.text = "You Lose!";
                timer.text = "Press R to play again!";
                if (Input.GetKey(KeyCode.R))
                {
                    timer.text = "Loading...";
                    Application.LoadLevel("ParkingLotSim2017");
                }
            }
            else
            {
                time -= Time.deltaTime;
                timer.text = time.ToString();
            }
        }
        if (winCondition == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                timer.text = "Loading...";
                Application.LoadLevel("ParkingLotSim2017");
            }
        }


    }

    void OnTriggerEnter(Collider other)
    {
        //Handles Collision with the Winning Spot
        if (loss == false && other.tag == "winSpot")
        {

            winCondition = true;
            Debug.Log("Event Triggered");
            gameoverPrompt.text = "You Win!";
            timer.text = "Press R to play again!";
        }

        //Handles collision with a parked car
        if(other.tag == "ParkedCar" && carHitTime >= 2.0f)
        {
            Debug.Log("Hit Parked Car");
            time -= 3.0f;
            carHitTime = 0;
        }

        //Handles collision with pedestrian
        if(other.tag == "pedestrian" && pedHitTime >= 2.0f)
        {
            Debug.Log("Pedestrian Hit");
            time -= 10.0f;
            pedHitTime = 0;
        }
    }
}