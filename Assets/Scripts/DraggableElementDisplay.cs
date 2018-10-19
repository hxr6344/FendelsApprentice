using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DraggableElementDisplay : MonoBehaviour {

	public DraggableElement element;

	public GameObject nameText;
	public Image image;

	void Awake()
	{
		nameText.GetComponent<TextMeshProUGUI>().text = element.nameElement;
		image.sprite = element.artwork;
	}



}
