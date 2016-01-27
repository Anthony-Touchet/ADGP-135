using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D playRB;
    private Vector2 movement;
    public Text villagerText;
    public float textLength;
    public int speed;

    private float nextRefresh;

	void Lerp (float a, float b, float c) {//Lerp: moving by position
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y + b, transform.position.z + c);
	}
	
    void Start()
    {
        playRB = GetComponent<Rigidbody2D>();
        villagerText.text = "";
    }

	void Update () {
        float h = Input.GetAxisRaw("Horizontal"); //x Axis control
        float v = Input.GetAxisRaw("Vertical");

        movement = new Vector2(h, v);      
        playRB.AddForce(movement * speed);

        if (Time.time > nextRefresh)
        {            
            villagerText.text = "";
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Tree")
        {
            villagerText.text = "These trees are too dense. Better find another way.";
            nextRefresh = Time.time + textLength;
        }
    }
}
