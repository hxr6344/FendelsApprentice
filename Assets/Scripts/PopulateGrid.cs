using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopulateGrid : MonoBehaviour {

	public GameObject item;

	public Sprite[] sprites;

	int counter;


	// Use this for initialization
	void Start () {
		for(int i=0;i<sprites.Length;i++)
		{
			GameObject temp= (GameObject)Instantiate(item,transform);
			temp.GetComponent<Image>().sprite = sprites[i];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}
