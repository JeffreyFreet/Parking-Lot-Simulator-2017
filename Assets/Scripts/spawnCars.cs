using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCars : MonoBehaviour {

    public GameObject vehicle;
    public GameObject emptySpot;
    private List<float> coordinatesX;
    private List<float> coordinatesZ;
    private int winSpot;

	// Use this for initialization
	void Start () {
        coordinatesX = new List<float>();
        coordinatesX.Add(0.0f);
        coordinatesX.Add(3.0f);
        coordinatesX.Add(6.0f);
        coordinatesX.Add(9.0f);
        coordinatesX.Add(12.0f);
        coordinatesX.Add(15.0f);

        coordinatesZ = new List<float>();
        coordinatesZ.Add(0.0f);
        coordinatesZ.Add(6.0f);
        coordinatesZ.Add(12.0f);
        coordinatesZ.Add(18.0f);
        coordinatesZ.Add(24.0f);
        coordinatesZ.Add(30.0f);

        winSpot = Random.Range(0, 4);
        for(int i = 0; i < coordinatesX.Count; i++)
        {
            for (int j = 0; j < coordinatesZ.Count; j++)
            {
                if (i == winSpot && j == winSpot)
                {
                    Vector3 position = new Vector3(coordinatesX[i], 0.0f, coordinatesZ[j]);
                    Instantiate(emptySpot, new Vector3(coordinatesX[i], 0.0f, coordinatesZ[j]), Quaternion.identity);
                   
                }
                else
                {
                    Vector3 position = new Vector3(coordinatesX[i], 0.0f, coordinatesZ[j]);
                    Instantiate(vehicle, new Vector3(coordinatesX[i], 0.0f, coordinatesZ[j]), Quaternion.identity);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
