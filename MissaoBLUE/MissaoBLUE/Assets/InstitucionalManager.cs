using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstitucionalManager : MonoBehaviour
{
	public GameObject logoEscola;
	public GameObject logoWee;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine("Institucional");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator Institucional()
	{
		logoEscola.SetActive(true);
		logoWee.SetActive(false);
		yield return new WaitForSeconds(5);
		logoWee.SetActive(true);
		logoEscola.SetActive(false);
		yield return new WaitForSeconds(5);
		NumAraras.minAraras = 5;
		SceneManager.LoadScene("Menu2");


	}
}
