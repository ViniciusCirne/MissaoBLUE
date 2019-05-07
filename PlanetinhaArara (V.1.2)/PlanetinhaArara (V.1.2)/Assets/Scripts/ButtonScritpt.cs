using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScritpt : MonoBehaviour
{
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void GoToGameplay()
	{
		SceneManager.LoadScene("Gameplay");
	}

	public void GoToInstrucoes()
	{
		SceneManager.LoadScene("Instruções");
	}

	public void GoToConfiguracoes()
	{
		SceneManager.LoadScene("Configurações");
	}

	public void GoToCreditos()
	{
		SceneManager.LoadScene("Créditos");
	}

	public void GoToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
