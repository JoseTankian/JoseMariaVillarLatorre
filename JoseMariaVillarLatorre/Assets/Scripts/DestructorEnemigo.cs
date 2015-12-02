using UnityEngine;
using System.Collections;

public class DestructorEnemigo : MonoBehaviour {


	// Use this for initialization

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D objeto)
	{
		//Si se encuentra un objeto con el tag enemigo enemigo la nave se destruira
		if(objeto.transform.tag == "enemigo")
		{  
			Destroy(gameObject);
		}
	}
}
