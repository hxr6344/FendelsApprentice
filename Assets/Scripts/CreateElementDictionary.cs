using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateElementDictionary {
	[MenuItem("Assets/Create/Element Dictionary")]
	public static ElementDictionary Create()
	{
		ElementDictionary asset = ScriptableObject.CreateInstance<ElementDictionary>();

		AssetDatabase.CreateAsset(asset,"Assets/Resources/ScriptObjects/Dictionary/ElementDictionary.asset");
		AssetDatabase.SaveAssets();
		return asset;
	}
}
