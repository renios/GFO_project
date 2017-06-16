using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	public readonly int maxHealth = 30;
	public int currentHealth;
	public GameObject currentHpBar;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;	
		UpdateHealthBar();
	}
	
	// Update is called once per frame
	void UpdateHealthBar () {
		float healthRatio = (float)currentHealth / (float)maxHealth;
		currentHpBar.transform.localScale = new Vector3(healthRatio,1,1);
	}

	public void Heal(int healAmount)
	{
		currentHealth += healAmount;
		if (currentHealth > maxHealth) 
			currentHealth = maxHealth;
		UpdateHealthBar();
	}

	public void Damaged(int damageAmount)
	{
		currentHealth -= damageAmount;
		if (currentHealth < 0) 
			currentHealth = 0;
		UpdateHealthBar();
	}

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.O)){
			Damaged(1);
		}
		if(Input.GetKeyDown(KeyCode.H)){
			Heal(1);
		}
		if (currentHealth == 0)
		{
			Restart();
		}
	}

	void Restart()
	{
		string sceneName = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(sceneName);
	}
}
