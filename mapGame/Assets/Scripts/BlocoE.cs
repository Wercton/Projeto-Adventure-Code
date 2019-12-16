using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BlocoE : MonoBehaviour
{
	public string proximaCena;
	public bool liberar;
	public GameObject botaoBlocoE;


	
	public GameObject scriptFaseAnterior;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(botaoBlocoE.GetComponent<Button>().interactable == false){
			botaoBlocoE.GetComponent<Button>().interactable = liberar;
		}
    }
	public void clickBlocoE(){
		SceneManager.LoadScene(proximaCena);
	}
}
