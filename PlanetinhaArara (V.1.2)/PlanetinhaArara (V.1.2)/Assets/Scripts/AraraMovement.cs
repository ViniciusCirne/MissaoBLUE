﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AraraMovement : MonoBehaviour
{ 
	public int araraScore;
	public float speed;
	private Rigidbody rb;
	public GameObject gameOver;

	
    // Start is called before the first frame update
    void Start()
    {
		araraScore = 0;
		gameOver.SetActive(false);
		rb = GetComponent<Rigidbody>();
		speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag("Obstacle")) {
			rb.useGravity = true;
			gameOver.SetActive(true);
			speed = 0;
		}
		if (col.gameObject.CompareTag("Fire")) {
			rb.useGravity = true;
			gameOver.SetActive(true);
			speed = 0;
		}
		if (col.gameObject.CompareTag ("Baby")){

			Score.scoreValue += 10;
			col.gameObject.SetActive(false);
		}
	}
}
