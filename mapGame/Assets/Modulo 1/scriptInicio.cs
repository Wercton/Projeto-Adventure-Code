using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptInicio : MonoBehaviour
{
		public GameObject input;
		public GameObject falaDoNPC;
		public string nome;
		public string fala;
		public GameObject field;
		public GameObject bot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(field.transform.position == new Vector3 (-100000,-10000000,0)){
			if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene("apresentacaoMapa");
		}
		}
    }

	public void onClickInicio(){
		nome = input.GetComponent<Text>().text;
		if(nome.Contains("(")&&nome.Contains(")")){
		nome = nome.Substring(nome.IndexOf('(')+1);
		nome = nome.Substring(0, nome.IndexOf(')'));
		fala = "Então, "+nome+", espero que você possa nos ajudar. Passamos por tempos terríveis com a escassez de água, tudo virou de cabeça para baixo. Você me parece bem inteligente, acho que é a pessoa que estávamos esperando.";
		falaDoNPC.GetComponent<Text>().text = fala;
		field.transform.position = new Vector3 (-100000,-10000000,0);
		bot.transform.position = new Vector3 (-100000,-10000000,0);
		}
	}
}
