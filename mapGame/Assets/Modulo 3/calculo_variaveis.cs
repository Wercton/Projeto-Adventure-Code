using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class calculo_variaveis : MonoBehaviour
{
	public GameObject inputField;
	public GameObject resultado;
	public string entrada;
	private string res;
	public GameObject falaDoNPC;
    // Start is called before the first frame update
    void Start()
    {
        res = resultado.GetComponent<Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
		if(falaDoNPC.GetComponent<Text>().text == "Parabéns por ter conseguido, agora vamos voltar ao mapa para que voce possa acessar às outras fases"){
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene("cenaMapa");
		}
		}
		else{
		if(Input.GetMouseButtonDown(0)){
        if(resultado.GetComponent<Text>().text != res){
			falaDoNPC.GetComponent<Text>().text = "Parabéns por ter conseguido, agora vamos voltar ao mapa para que voce possa acessar às outras fases";
		}
		}
		}
    }

    public void onClick(){
		entrada =  inputField.GetComponent<Text>().text;
		if(entrada.Contains("\n")){
		try{
		entrada = entrada.Replace(" ", string.Empty);
		string aux = entrada.Substring(entrada.IndexOf('\n')+1);
		string ent1 = entrada.Substring(0, entrada.IndexOf('\n'));
		string ent2 = aux.Substring(0, entrada.IndexOf('\n'));
		aux = aux.Substring(aux.IndexOf('\n')+1);
		string nomeVar1 = ent1.Substring(0, ent1.IndexOf('='));
		string numero1 = ent1.Substring(ent1.IndexOf('=')+1);
		string nomeVar2 = ent2.Substring(0, ent1.IndexOf('='));
		string numero2 = ent2.Substring(ent1.IndexOf('=')+1);
		print(nomeVar1);
		print(numero1);
		print(nomeVar2);
		print(numero2);

		int n1;
		int n2;
		int.TryParse(numero1, out n1);
		int.TryParse(numero2, out n2);
		int soma = n1+n2;
		if(aux == "print("+nomeVar1+"+"+nomeVar2+")"||aux == "print"+nomeVar1+"+"+nomeVar2||aux == "print("+nomeVar2+"+"+nomeVar1+")"||aux == "print"+nomeVar2+"+"+nomeVar1){
			resultado.GetComponent<Text>().text = "Resultado = "+soma;
		}
		}catch{}
		}
		}
}
