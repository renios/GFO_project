using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {

	public GameObject darkSpike;
	public int spikeDelay;
	public GameObject darkOrb;
	public int orbDelay;

	public Transform orbShooterPos1;
	public Transform orbShooterPos2;

	// Use this for initialization
	void Start () {
		
	}
	
	public void AttackStart()
	{
		StartCoroutine(ShotDarkSpike());
		StartCoroutine(ShotDarkOrb());
	}

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ShotDarkOrb()
	{
		yield return new WaitForSeconds(1f);
		while (true)
		{
			Instantiate(darkOrb, orbShooterPos1.position, Quaternion.identity);
			yield return new WaitForSeconds(0.5f);
			Instantiate(darkOrb, orbShooterPos2.position, Quaternion.identity);
			yield return new WaitForSeconds(0.5f);
			Instantiate(darkOrb, orbShooterPos1.position, Quaternion.identity);
			yield return new WaitForSeconds(orbDelay);
		}
	}

	IEnumerator ShotDarkSpike()
	{
		yield return new WaitForSeconds(spikeDelay/2f);
		while (true)
		{
			for (int i = 0; i < 4; i++)
			{
				float posX = Random.Range(-8f, 6f);
				Instantiate(darkSpike, new Vector3(posX, -6, 0), Quaternion.identity);
			}
			yield return new WaitForSeconds(spikeDelay);
		}
	}
}
