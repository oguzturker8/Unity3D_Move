using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarpismaTespit : MonoBehaviour {
	public int point; //Puan
	private GameObject pointText; //UI Puan Texti
	private List<GameObject> pointObjects = new List<GameObjects>();//Rastgele Olusturulacak Objelerin Arrayi
	static int tmp;//Toplam Puan

	void OnCollisionEnter() {//Hitboxlarin carpimi esnasinda calisan constructor.

	pointText = GameObject.Find("PuanYazisi");//UI deki text conts icine atanir.
	pointObjects.Add(GameObject.Find("EksiPuanObjesi"));//Prefablar object listte toplanir.
	pointObjects.Add(GameObject.Find("ArtiPuanObjesi"));//Prefablar object listte toplanir.
	pointText.GetComponent<Text>().text = "Puan : " + tmp.ToString();//Tmp UI texte yazilir.
	int randi = Random.Range(0,1);//Yaratilacak obje secimi
	float randx = Random.Range(1.5f, -5f);//Rastgele x konumu.
	float randz = Random.Range(-3.6f,2.4f);//Rastgele z konumu.
	GameObject createdObject = (GameObject) Instantiate(pointObjects[randi] , new Vector3(randx,1.6,randz));//Rastgele obje olusturma
	Destroy(gameObject);//Objeyi silme (Olusan yeniyi degil mevcut objeci gameObject'in g si kucukse this gorevi gorur.)
	}

	void Update(){ //Update Frame Basina Calisan Constructordir. 
	transform.Rotate(1,3,4);//Objenin surekli donmesini saglar.
	}
}