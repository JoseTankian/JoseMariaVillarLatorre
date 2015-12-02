using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rg;
	void Start () {
		rg = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D objeto)
	{
		//Si se encuentra un objeto con el tag jugador, la nave se destruira
		if(objeto.transform.tag == "jugador")
		{  
			Destroy(gameObject);
		}
	}
}
