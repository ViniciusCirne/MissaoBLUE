using System.Collections;
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
	public int life;
	//public GameObject vitoria;

	
    // Start is called before the first frame update
    void Start()
    {
		life = 3;
		araraScore = 0;
		//gameOver.SetActive(false);
		//vitoria.SetActive(false);
		rb = GetComponent<Rigidbody>();
		speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

		//if (SpawnScript.vitoria) {
		//	vitoria.SetActive(true);
		//}
    }

    void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag("Obstacle")) {
			rb.useGravity = true;
			speed = 0;
		    SceneManager.LoadScene("Derrota");
		}

		else if (col.gameObject.CompareTag("Fire Tree") || life == 0) {
			rb.useGravity = true;
			speed = 0;
			SceneManager.LoadScene("Derrota");
		}

		else if (col.gameObject.CompareTag("Normal Tree")) {
			rb.useGravity = true;
			speed = 0;
			life = life - 1;
			Debug.Log(life);
		}

		else if (col.gameObject.CompareTag("Fire")) {
			rb.useGravity = true;
			speed = 0;
			SceneManager.LoadScene("Derrota");
		}

		else if (col.gameObject.CompareTag ("Baby")){

			Score.scoreValue += 1;
			col.gameObject.SetActive(false);
		}
	}
}
