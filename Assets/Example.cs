using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

    public Joystick joystick;

	// Use this for initialization
	void Start () {
        joystick.OnTouchMove += OnJoystickMove;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnJoystickMove(float angle360, float power)
    {
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

       // print(angle360);
    }
}
