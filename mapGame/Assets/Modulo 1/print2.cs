using static scriptInicio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class print2 : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject inputField;
	public GameObject falaDoNPC;
	public string entrada;
	public string num;
	public GameObject field;
	public GameObject botao;
	public GameObject mapa;
	
	void Start()
    {
        
    }

	void Update(){
		 if(field.transform.position == new Vector3 (-100000,-10000000,0)){
			if(Input.GetMouseButtonDown(0)){
				SceneManager.LoadScene("cenaMapa");
		}
		}
	}

	public void onClickPrint2(){
		entrada = inputField.GetComponent<Text>().text;
		entrada = entrada.Replace(" ", "");
		if(entrada.Contains("print(") && entrada.Contains(")")){
			num = entrada.Substring(entrada.IndexOf('(')+1);
			num = num.Substring(0, num.IndexOf(')'));
			long number1;
			bool canConvert = long.TryParse(num, out number1);
			if(canConvert){
			falaDoNPC.GetComponent<Text>().text = "Parabéns, você concluiu o módulo 1 e aprendeu a usar o comando print(). Agora vamos voltar ao mapa para que você possa explorar o mapa, divirta-se!";
			
			
			mapa.SetActive(false);
			field.transform.position = new Vector3 (-100000,-10000000,0);
			botao.transform.position = new Vector3 (-100000,-10000000,0);
			}
		}
	}
}
