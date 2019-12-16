using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class M2P3 : MonoBehaviour
{
	public GameObject inputField;
	public GameObject resultado;
	public string entrada;
	public GameObject falaDoNPC;
	public GameObject field;
	public GameObject bot;
	public string primeiraFala;
	public string segundaFala;
	public string terceiraFala;
    // Start is called before the first frame update
    void Start()
    {
		primeiraFala = falaDoNPC.GetComponent<Text>().text;
		segundaFala = "Muito bem! Agora vamos dar início aos tipos de dados, esse resultado 12.5 é um valor de ponto flutuante (float). Valores float são valores com pontos decimais, por exemplo 1.2, 1.5 e por aí vai.";
		terceiraFala = "Temos também números inteiros (int), int são valores inteiros como por exemplo 1, 2, 3 e por aí vai. Não podemos deixar faltar os caracteres, falaremos especificamente das strings. As strings são conjuntos de caracteres que são criadas com aspas simples ou aspas duplas, por exemplo print(\"hello wolrd\")";
   }

    // Update is called once per frame
    void Update()
    {
       if(resultado.GetComponent<Text>().text == "resultado = 12,5"){
		if(falaDoNPC.GetComponent<Text>().text == primeiraFala){
	   	   if(Input.GetMouseButtonDown(0)){
			falaDoNPC.GetComponent<Text>().text = segundaFala;}
		   }
		   else{
		   if(falaDoNPC.GetComponent<Text>().text == segundaFala){
		   if(Input.GetMouseButtonDown(0)){
			falaDoNPC.GetComponent<Text>().text = terceiraFala;
		  }
		   }
		   else{
		   	   if(falaDoNPC.GetComponent<Text>().text == terceiraFala){
				if(Input.GetMouseButtonDown(0)){
				SceneManager.LoadScene("modulo 2 - 4");
		  }
		   }
		   }
		   }
		   }
}
	public void onClick(){
	 entrada =  inputField.GetComponent<Text>().text;
	 if(entrada.Contains("\n")){
		string ent1 = entrada.Substring(0, entrada.IndexOf('\n'));
		string ent2 = entrada.Substring(entrada.IndexOf('\n')+1);
		if((ent1.Equals("resultado = 50/4")||ent1.Equals("resultado =50/4")||ent1.Equals("resultado=50/4")||ent1.Equals("resultado= 50/4"))&&(ent2.Equals("return resultado")||ent2.Equals("return (resultado)")||ent2.Equals("return(resultado)"))){
		resultado.GetComponent<Text>().text = "resultado = 12,5";
		//field.SetActive(false);
		field.GetComponent<InputField>().interactable = false;
		bot.GetComponent<Button>().interactable = false;
		}
		}
	}
}
