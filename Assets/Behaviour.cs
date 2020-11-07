using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	public void playGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
	
	public void quitGame() {
		Debug.Log("Quit");
		Application.Quit();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
