using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterTemplate : ScriptableObject {

	public string characterName;
	public Color backgroundColor;
	public Sprite characterArt;
}
