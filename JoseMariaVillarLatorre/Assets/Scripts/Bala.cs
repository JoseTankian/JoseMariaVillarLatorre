using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	//Creamos una objeto llamado proyectil
	public GameObject proyectil;
	//Creamos un vector llamado fuerza con valor x 0 y y 1000
	public Vector2 fuerza = new Vector2(0,1000);
	Rigidbody2D rg;

	// Use this for initialization
	void Start () 
	{
		//llamamos al rigidbody
		rg = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.Space))
		{
			//Creamos el proyectil y lo metemos en la variable nuevo_proyectil
			GameObject nuevo_proyectil =(GameObject) Instantiate(proyectil, transform.position, transform.rotation);
			//Extraemos en rigidbody para poder aplicarle una fuerza
			rg = nuevo_proyectil.GetComponent<Rigidbody2D>();
			//A los dos segundos se destruye el proyectil que ha sido invocado
			Destroy(nuevo_proyectil, 2);
			//Aplicamos la fuerza con el vector que hemos creado arriba
			rg.AddForce(fuerza);
		}

	}

	void OnTriggerEnter2D(Collider2D objeto)
	{
		//Si se encuentra un objeto con el tag enemigo la bala se destruira
		if(objeto.transform.tag == "enemigo")
		{  
			Destroy(gameObject);
		}
	}

}
