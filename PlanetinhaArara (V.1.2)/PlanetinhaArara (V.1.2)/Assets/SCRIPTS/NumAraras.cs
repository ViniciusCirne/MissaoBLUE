using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumAraras : MonoBehaviour
{
	public GameObject canvasNum;
	public Text num;
	public static int minAraras;
	public static bool canStartNum;
	public static bool canAdd;
	public static bool canStartFire;

    // Start is called before the first frame update
    void Start()
    {
		
		canvasNum.SetActive(false);
		minAraras = 10;
		//num = GetComponent<Text> ();
		//canvasNum.SetActive (false);
		//StartCoroutine(TempoCanvas());
		if (Tutorial.tutorialDone == false) {
			canvasNum.SetActive(false);
		}

		if (Tutorial.tutorialDone == true) {
			canvasNum.SetActive(true);
		}

    }

    // Update is called once per frame
    void Update()
    {
		if (canStartNum == true) {
			Debug.Log("começa a corotina");
			canvasNum.SetActive(true);
			StartCoroutine(TempoCanvas());
			canStartNum = false;
		}

		num.text = " " + minAraras;

		if (canAdd == true) {
			minAraras += 5;
			canAdd = false;
		}
    }

	IEnumerator TempoCanvas()
	{
		AraraMovement.speed = 0.0f;
		canvasNum.SetActive (true);
		yield return new WaitForSeconds(4);
		canvasNum.SetActive (false);
		AraraMovement.speed = 10.0f;
		NumAraras.canStartFire = true;

	}


}
