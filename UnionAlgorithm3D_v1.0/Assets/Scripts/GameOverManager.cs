using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour {
	public PlayerHealth playerHealth;
	public float restartDelay = 5f;
	public GameObject gameoverImage;

	float restartTimer; 
	// Use this for initialization
	void Start () {
		gameoverImage.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(playerHealth.currentHealth <= 0)
		{
			gameoverImage.SetActive (true);
			restartTimer += Time.deltaTime;
			if(restartTimer >= restartDelay)
			{
				gameoverImage.SetActive (false);
				// .. then reload the currently loaded level.
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
