using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

    // Use this for initialization
   

    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            //zatrzymuje pilke przy paddle
        this.transform.position = paddle.transform.position + paddleToBallVector;
            if (Input.GetMouseButtonDown(0))
            {
                // jezeli nacisne myszke to 
                hasStarted = true; //gra sie rozpoczyna
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f); //nadaje predkosci pilce
                
            }
        }
        

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 randomDir = new Vector2(UnityEngine.Random.Range(0f, 0.4f), UnityEngine.Random.Range(0f, 0.4f));
        if (hasStarted)
        {
            GetComponent<Rigidbody2D>().velocity += randomDir;
            print("collision");
        }
    }
    //dźwięk przy odbijaniu
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    AudioSource audio = GetComponent<AudioSource>();
    //    if (hasStarted) { 
    //    audio.Play();
    //    }
    //}
}
