using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiItem : MonoBehaviour {

	[HideInInspector]public string elementName;

	[HideInInspector]public int elementID;

	[HideInInspector]public Sprite sprite;

	public GameObject dragPrefab;		// prefab of the draggable element that is going to be spawn in on click

	public ElementDictionary elements;

	

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		Button b1 = this.GetComponent<Button>();

		b1.onClick.AddListener(SpawnDragElement);
	}

	void SpawnDragElement()
	{
		GameObject temp = Instantiate(dragPrefab);
		temp.GetComponent<DraggableElementDisplay>().element = elements.allElements[elementID];
		
	} 

	
}
