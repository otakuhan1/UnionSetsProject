using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;                            
	public int currentHealth;                                   
	public Slider healthSlider;                                 


	PlayerController playerController;

	bool isDead;                                                
	//bool damaged;

	void Awake()
	{
		currentHealth = startingHealth;
		playerController = GetComponent<PlayerController> ();
	}

	void Updata()
	{
		//damaged = false;
	}

	public void TakeDamage(int amount)
	{
		//damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;

		if(currentHealth <= 0&&!isDead)
		{
			Death();
		}
	}

	void Death()
	{
		isDead = true;
		playerController.enabled = false;
	}
}
