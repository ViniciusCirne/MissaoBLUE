using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumAraras : MonoBehaviour
{
	public GameObject canvasNum;
	Text num;
	public static int minAraras;

	public static bool canAdd;

    // Start is called before the first frame update
    void Start()
    {
		minAraras = 10;
		num = GetComponent<Text> ();
		//canvasNum.SetActive (false);
		StartCoroutine(TempoCanvas());

 
    }

    // Update is called once per frame
    void Update()
    {
		num.text = " " + minAraras;

		if (canAdd == true) {
			minAraras += 5;
			canAdd = false;
		}
    }

	IEnumerator TempoCanvas()
	{
		canvasNum.SetActive (true);
		yield return new WaitForSeconds(5);
		canvasNum.SetActive (false);

	}


}
