using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DraggableElement : MonoBehaviour {

	[HideInInspector] public Element element=null;

	public TextMeshProUGUI nameText;
	public Image image;

	public ElementDictionary elDic;

	[HideInInspector]public int elementID;

	bool canCollide = false;

	void Awake()
	{
		
	}
	
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		nameText.text = element.elementName;
		image.sprite = element.icon;
		elementID = element.elementID;
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		Image image = gameObject.GetComponent<Image>();
		Color newColor = new Color(image.color.r,image.color.g,image.color.b,image.color.a-0.2f);
		image.color = newColor;

		if(gameObject.GetComponent<ElementDragHandler>().dragging == false)
			canCollide = false;
		else
			canCollide = true;
	}

	/// <summary>
	/// Sent each frame where another object is within a trigger collider
	/// attached to this object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.tag=="DraggableElement"&&canCollide ==true&&gameObject.GetComponent<ElementDragHandler>().dragging == false)
		{
			
			//Destroy(other.gameObject);
			Image image = other.gameObject.GetComponent<Image>();
			Color newColor = new Color(image.color.r,image.color.g,image.color.b,image.color.a+0.2f);
			image.color = newColor;

			int elementIndex = IsValidRecipe(this,other.gameObject.GetComponent<DraggableElement>());
			other.gameObject.GetComponent<DraggableElement>().image.sprite = elDic.allElements[elementIndex].icon;
			other.gameObject.GetComponent<DraggableElement>().elementID = elDic.allElements[elementIndex].elementID;
			other.gameObject.GetComponent<DraggableElement>().nameText.text = elDic.allElements[elementIndex].elementName;
			other.gameObject.GetComponent<DraggableElement>().element = elDic.allElements[elementIndex];

			
			Destroy(this.gameObject);
		}
	}

	/// <summary>
	/// Sent when another object leaves a trigger collider attached to
	/// this object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerExit2D(Collider2D other)
	{
		Image image = gameObject.GetComponent<Image>();
		Color newColor = new Color(image.color.r,image.color.g,image.color.b,image.color.a+0.2f);
		image.color = newColor;
	}

	public int IsValidRecipe(DraggableElement e1, DraggableElement e2)
	{
		// return ocean
		if(e1.elementID==3&&e2.elementID==3)
		{
			return 35;
		
		}
		// return heat
		else if(e1.elementID==2&&e2.elementID==2)
		{
			return 34;
			
		}
		// return cloud
		else if((e1.elementID==0&&e2.elementID==3)||(e2.elementID==3&&e2.elementID==0))
		{
			return 38;
		}

		return -99;
	}



}
