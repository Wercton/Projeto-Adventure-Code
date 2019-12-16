using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class botaoPlay : MonoBehaviour
{
    
		public GameObject inputField;
		public string entrada;
		public SpriteRenderer sprite;
		public Rigidbody2D jogador;
		//public float currentValue = 1;
		//public float duration = 5.0f; 

	// Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		//currentValue -= Time.deltaTime / duration;

        if(jogador.transform.rotation.z != 0){
			jogador.transform.rotation = Quaternion.Euler(jogador.transform.rotation.x, jogador.transform.rotation.y, 0);
		}
		if(jogador.transform.position.x > 7.11){
			jogador.transform.position = new Vector3(7, jogador.transform.position.y, jogador.transform.position.z);
		}
		if(jogador.transform.position.x < -8.2){
			jogador.transform.position = new Vector3((float)-7.48, jogador.transform.position.y, jogador.transform.position.z);
		}
		
    }

	public void onClick(){
		entrada = inputField.GetComponent<Text>().text;
		jogador.transform.position = new Vector3((float)-7.422, (float)-2.77, 0);
		string[] lista = entrada.Split('\n');
		for(int i = 0; i<lista.Length;i++){
		jogador.transform.position = new Vector3(jogador.transform.position.x, (float)0, jogador.transform.position.z);
		if(lista[i].Equals("paraFrente()")){
			if(sprite.flipX == true){
			sprite.flipX = !sprite.flipX;
			}
		jogador.transform.position = new Vector3(jogador.transform.position.x+(float)1.7, jogador.transform.position.y, jogador.transform.position.z);
		}
		
		
		
		if(lista[i].Equals("paraTraz()")){
			if(sprite.flipX == false){
			sprite.flipX = !sprite.flipX;
		}
		jogador.transform.position = new Vector3(jogador.transform.position.x-(float)1.7, jogador.transform.position.y, jogador.transform.position.z);}
			
		if(lista[i].Equals("pularParaFrente()")){
		if(sprite.flipX == true){
			sprite.flipX = !sprite.flipX;
		}
		jogador.transform.position = new Vector3(jogador.transform.position.x+(float)1.5, jogador.transform.position.y+3, jogador.transform.position.z);}
			
		if(lista[i].Equals("pularParaTraz()")){
			if(sprite.flipX == false){
			sprite.flipX = !sprite.flipX;
		}
		jogador.transform.position = new Vector3(jogador.transform.position.x-(float)1.5, jogador.transform.position.y+3, jogador.transform.position.z);}
	}
	}
}
