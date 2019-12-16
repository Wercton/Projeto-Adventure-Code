using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apresentacaoPersonagem : MonoBehaviour
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
    }

	void OnCollisionEnter2D(Collision2D colisao){
		if(colisao.gameObject.tag == "mago"){
			SceneManager.LoadScene("inicio");
		}
	}
}
