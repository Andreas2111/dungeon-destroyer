using UnityEngine;
using System.Collections;

public class DealDamageToTag : MonoBehaviour
{
	//Hvor meget den skader
	public int amount;

	//Det tag som tager damage
	public string damageTag;


	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == damageTag)
		{
			other.gameObject.GetComponent<Health>().ReceiveDamage(amount);
		}
	}
}
