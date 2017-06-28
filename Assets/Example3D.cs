using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3D : MonoBehaviour {

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
        float mz = Mathf.Sin(data.radians) * speed * Time.deltaTime * data.power;
        target.transform.Translate(mx, 0, mz);
    }
}
