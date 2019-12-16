using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class explicacao : MonoBehaviour
{
	public GameObject falaDoNPC;
	public string primeiraFala;
	public string segundaFala;
	public string terceiraFala;
    // Start is called before the first frame update
    void Start()
    {
		primeiraFala = falaDoNPC.GetComponent<Text>().text;
		segundaFala = "Hoje aprenderemos a manipular as variáveis de modo que não só armazene resultados, como também realize operações algébricas.";
		//" Digamos que eu crie uma variável A na qual armazenarei o valor inteiro 5, e depois crio uma segunda variável B onde armazeno o valor 16, o que acontecerá quando eu der print() em A-B?"
		terceiraFala = "Crie duas variáveis, e atribua a cada uma delas um diferente valor inteiro. Em seguida, use o comando \'print()\" para mostrar o resultado da soma entre as duas.";
		//terceiraFala = "Armazene o resultado da expressão A - B em uma terceira variável C e dê print no resultado, não se esquecendo de definir A como 5 e B como 16.";
    }

    // Update is called once per frame
    void Update()
    {
		if(falaDoNPC.GetComponent<Text>().text == primeiraFala){
	   		if(Input.GetMouseButtonDown(0)){
				falaDoNPC.GetComponent<Text>().text = segundaFala;
			}
		}else{
			if(falaDoNPC.GetComponent<Text>().text == segundaFala){
				if(Input.GetMouseButtonDown(0)){
					falaDoNPC.GetComponent<Text>().text = terceiraFala;
				}
			}else{
				if(falaDoNPC.GetComponent<Text>().text == terceiraFala){
					if(Input.GetMouseButtonDown(0)){
						SceneManager.LoadScene("modulo 3 - 3");
			}
		}
		}
		}   
}}


