using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class M2P4 : MonoBehaviour
{
	public GameObject input;
	public GameObject resultado;
	public GameObject falaDoNPC;
	public string entrada;
	public string primeiraFala;
	public string segundaFala;
	public GameObject ent;
	public GameObject bot;
	public bool liberarProximaFase;
    // Start is called before the first frame update
    void Start()
    {
        primeiraFala = falaDoNPC.GetComponent<Text>().text;
		segundaFala = "Agora faça um algoritmo que multiplique 5 vezes 5 e mostre o resultado. Declare a variável como int.\nDica: símbolos: (=) atribui valor à variável, (+) soma, (-) subtração, (/) divisão, (*) multiplicação.Ex:\nint nomeVariavel = 5*5\nreturn nomeVariavel";
		
		ent.GetComponent<InputField>().interactable = false;
		bot.GetComponent<Button>().interactable = false;
		liberarProximaFase = false;
   }

    // Update is called once per frame
    void Update()
    {
		if(falaDoNPC.GetComponent<Text>().text == primeiraFala){
        if(Input.GetMouseButtonDown(0)){
			falaDoNPC.GetComponent<Text>().text = segundaFala;
			ent.GetComponent<InputField>().interactable = true;
			bot.GetComponent<Button>().interactable = true;
		}
		}
		/*else{
			if(falaDoNPC.GetComponent<Text>().text == segundaFala){
			if(Input.GetMouseButtonDown(0)){


			}
			}
		}*/
		if(resultado.GetComponent<Text>().text == "Resultado = 25"){
			if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene("cenaMapa");
			}
			}
    }

	public void onClick(){
		string aux1;
		string aux2;
		string tipo;
		string nomeDaVariavel;
		string operacao;
		string retorno;
		string linha1;
		entrada = input.GetComponent<Text>().text;
		try{
		aux1 = entrada.Substring(0, entrada.IndexOf('\n'));
		linha1 = aux1;
		aux2 = entrada.Substring(entrada.IndexOf('\n')+1);
		tipo = aux1.Substring(0, aux1.IndexOf(' '));
		aux1 = aux1.Substring(aux1.IndexOf(' ')+1);
		nomeDaVariavel = aux1.Substring(0, aux1.IndexOf(' '));
		operacao = aux1.Substring(aux1.IndexOf('=')+2);
		aux1 = aux1.Substring(aux1.IndexOf(' ')+1);
		retorno = "return "+nomeDaVariavel;
		if(tipo =="int" && aux2 == retorno && aux1 == "= 5*5"){
			resultado.GetComponent<Text>().text = "Resultado = 25";
			falaDoNPC.GetComponent<Text>().text = "Meus parabéns, jovem aprendiz! Você concluiu todos meus desafios com êxito. Sinto que está mais que apto a prosseguir por sua jornada. Nos veremos ainda outra vez, tenho grande expectativas e posso prever que coisas grandiosas virão ainda de você. Até logo!";
			liberarProximaFase = true;
		}
		}catch
{
}
	}
}
