using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "New Drag Element" , menuName="Drag Element")]
public class DraggableElement : ScriptableObject {

	public string nameElement;
	public Sprite artwork;
	public int id;
}
