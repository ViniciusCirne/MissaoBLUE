using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCredits : MonoBehaviour
{
    public AudioSource buttoncredits;

    // Start is called before the first frame update
    void Start()
    {
        buttoncredits = GetComponent<AudioSource>();
        buttoncredits.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Credits()
	{
        buttoncredits.Play();
		SceneManager.LoadScene("Créditos");
	}
}
