using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {

    float time;
    Vector3 initialVelocity;
    float charge;
    float mass;
    Vector3 initialPosition;
    float frequency;
    float fi;
    float velocity;

	// Use this for initialization
	void Start () {
        initialPosition = new Vector3(0.0f, 0.0f, 0.0f);
        transform.position = initialPosition;
        
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        Vector3 position = new Vector3();
        position.x = initialPosition.x + velocity / frequency * (Mathf.Cos(fi) - Mathf.Cos(frequency * time + fi));
        position.y = velocity / frequency * (Mathf.Sin(fi) - Mathf.Sin(frequency * time + fi));
        transform.position = position;

    }

    public void Setup(Vector3 initialVelocity, float charge, float mass, Vector3 initialPosition) {

        this.initialVelocity = initialVelocity;
        this.charge = charge;
        this.mass = mass;
        this.initialPosition = initialPosition;
        this.frequency = charge * Field.induction / mass;
        this.velocity = initialVelocity.magnitude;
        this.fi = Mathf.Atan(initialVelocity.x / initialVelocity.y);

    }


    

}
