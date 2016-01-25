using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D playRB;
    private Vector2 movement;
    public int speed;

    float maxSpeed = 10f;

	void Lerp (float a, float b, float c) {//Lerp: moving by position
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y + b, transform.position.z + c);
	}
	
    void Start()
    {
        playRB = GetComponent<Rigidbody2D>();
    }

	void Update () {
        float h = Input.GetAxisRaw("Horizontal"); //x Axis control
        float v = Input.GetAxisRaw("Vertical");

        movement = new Vector2(h, v);

        if (playRB.velocity.magnitude < maxSpeed)  //Keeps player at a speed
        {
            playRB.AddForce(movement * speed);
        }

    }
}
