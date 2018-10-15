using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Element {

	public string elementName;
	public string iconName;	// the name of the png file for this element.
	public int elementID;	// id of the element. if it is 0, then the element is a base element.
	public int ingred1;		// the elementID of the first ingredient;
	public int ingred2;		// the elementID of the second ingredient;
}
