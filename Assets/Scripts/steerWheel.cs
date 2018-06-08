using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steerWheel : MonoBehaviour {

    public int speed = 30;
    Vector3 normal;
    bool restore = false;
    public GameObject steeringWheel;
    // Use this for initialization
    void Start()
    {
        normal = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            steeringWheel.transform.Rotate(0, 0, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            steeringWheel.transform.Rotate(0, 0, -(speed * Time.deltaTime));
    }
}
