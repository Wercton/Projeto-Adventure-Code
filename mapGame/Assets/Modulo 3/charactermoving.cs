using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charactermoving : MonoBehaviour
{
	private Rigidbody2D personagem;
	public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        personagem = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        personagem.velocity = new Vector2(velocidade, personagem.velocity.y);
		if(personagem.transform.rotation.z != 0){
			personagem.transform.rotation = Quaternion.Euler(personagem.transform.rotation.x, personagem.transform.rotation.y, 0);
		}
    }

	void OnCollisionEnter2D(Collision2D colisao){
		if(colisao.gameObject.tag == "mago"){
			SceneManager.LoadScene("modulo 3 - 2");
		}
	}
}