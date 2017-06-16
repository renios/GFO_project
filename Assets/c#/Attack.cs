using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	public GameObject player;
	Animator playerAnimator;
	SpriteRenderer sr;

	public GameObject swordPowerPrefab;
	public Transform shotPosition;
	public Vector2 direction;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		sr.enabled = false;
		playerAnimator = player.GetComponent<move_1>().spriteObject.GetComponent<Animator>();
		direction = Vector2.right;
	}

	// IEnumerator PlayAttackCoroutine(Vector2 direction)
	// {
	// 	playerAnimator.SetTrigger("attack");
		// sr.enabled = true;
		// yield return new WaitForSeconds(0.5f);
		// sr.enabled = false;
	// }
	
	
	public void PlayAttack()
	{
		// StartCoroutine(PlayAttackCoroutine());
		playerAnimator.SetTrigger("attack");
		GameObject bullet = Instantiate(swordPowerPrefab, shotPosition.position, Quaternion.identity) as GameObject;
		bullet.GetComponent<SwordPower>().SetDirection(direction);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
			PlayAttack();
	}
}
