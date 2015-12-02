using UnityEngine;
using System.Collections;

public class MovimientoJugador : MonoBehaviour {

	Rigidbody2D  rg;
	public float velocidadjug=8f;

	// Use this for initialization
	void Start () 
	{
		rg = GetComponent<Rigidbody2D> (); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.A))
		{
			rg.velocity = (new Vector2 (-(velocidadjug), rg.velocity.y));
		}
		
		if(Input.GetKey(KeyCode.D))
		{
			rg.velocity = (new Vector2 ((velocidadjug),rg.velocity.y));
		}

		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity;
		Debug.DrawLine(transform.position, new Vector3(transform.position.x+ velocidad.x,
		                                               transform.position.y + velocidad.y, transform.position.z));
	}
}
