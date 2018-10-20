using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DraggableElementDisplay : MonoBehaviour {

	[HideInInspector] public Element element;

	public TextMeshProUGUI nameText;
	public Image image;

	void Awake()
	{
		//nameText.GetComponent<TextMeshProUGUI>().text = element.nameElement;
		//image.sprite = element.artwork;
	}
	
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		nameText.text = element.elementName;
		image.sprite = element.icon;
	}



}
