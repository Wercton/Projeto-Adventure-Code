using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botaoPrint : MonoBehaviour
{
		public GameObject inputField;
		public string entrada;
		public GameObject falaDoNPC;

	public void onClickPrint(){
		entrada = inputField.GetComponent<Text>().text;
		entrada = entrada.Replace(" ", "");
		if(entrada.Equals("print(3,6,9)")){
			SceneManager.LoadScene("print2");
		}
		else{
			falaDoNPC.GetComponent<Text>().text = "Voce errou alguma coisa, verifique o seu codigo e clique no botão para tentar de novo\nLembre-se que voce deve digitar os tres primeiros numeros da tabuada de tres, dentro do \"print()\", separados por vírgula. Ex: print(num1, num2, num3)";
		}
		}
}
