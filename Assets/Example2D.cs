using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2D : MonoBehaviour {

    public Joystick joystick;

    public Transform target;
    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
        joystick.OnTouchMove += OnJoystickMove;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnJoystickMove(JoystickData data)
    {
        float mx = Mathf.Cos(data.radians) * speed * Time.deltaTime * data.power;
        float my = Mathf.Sin(data.radians) * speed * Time.deltaTime * data.power;

        target.Translate(mx, my, 0);

        /*
        if (angle360 >= 45 && angle360 < 135)
        {
            print("UP");
        }
        else if (angle360 >= 135 && angle360 < 225)
        {
            print("Left");
        }
        else if (angle360 >= 225 && angle360 < 315)
        {
            print("Down");
        }
        else
        {
            print("Right");
        }
         */

       // print(angle360);
    }
}
