using UnityEngine;
using System.Collections;

public class MovimientoJugador : MonoBehaviour {

	Rigidbody2D  rg;
	//Le asignamos velocidadjugador 8
	public float velocidadjug=8f;


	// Use this for initialization
	void Start () 
	{
		//llamamos al rigidbody
		rg = GetComponent<Rigidbody2D> (); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Si pulsamos A le aplicamos al rigidbody al que se apolica una velicdad, 
		//en el eje x la velocidadjug que es 8, y ninguna al eje y
		if(Input.GetKey(KeyCode.A))
		{
			//ponemos menos para que sea -8
			rg.velocity = (new Vector2 (-(velocidadjug), rg.velocity.y));
		}
		//Lo mismo que hemos puesto arriba
		if(Input.GetKey(KeyCode.D))
		{
			rg.velocity = (new Vector2 ((velocidadjug),rg.velocity.y));
		}


	}











}
