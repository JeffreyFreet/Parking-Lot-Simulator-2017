using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour {

    public GameObject car;
    public GameObject winSpace;

    public GameObject car0;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;
    public GameObject car6;
    public GameObject car7;
    public GameObject car8;
    public GameObject car9;
    public GameObject car10;
    public GameObject car11;
    public GameObject car12;
    public GameObject car13;
    public GameObject car14;

    private GameObject[] spots;
    private GameObject[] carArray;
    private int winSpot = 0;
    private int carPicker = 0;
    private float[] direction;
    private int directionPicker = 0;
    //private List<GameObject> spots;

    // Use this for initialization
    void Start () {
        spots = GameObject.FindGameObjectsWithTag("emptySpot");
        carArray = new GameObject[] {car0, car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14};
        direction = new float[] { -1.0f, 1.0f };

        winSpot = Random.Range(0, 119);

        for(int i=0; i <= 119; i++)
        {
            if (i == winSpot)
            {
                Instantiate(winSpace, spots[i].transform.position, Quaternion.identity);
            }
            else
            {
                carPicker = Random.Range(0, 15);
                directionPicker = Random.Range(0, 2);
                float yAxis = (direction[directionPicker] * 90.0f);
                Debug.Log(yAxis);
                Instantiate(carArray[carPicker], spots[i].transform.position, Quaternion.Euler(new Vector3(0, yAxis, 0)));
            }
        }

        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
