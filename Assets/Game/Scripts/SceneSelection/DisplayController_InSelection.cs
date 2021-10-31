using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController_InSelection : MonoBehaviour
{
	public Text characterNameText;
	public Image backgroundImage;
	public Image characterArtImage;

	[Space(10)]
	public List<CharacterTemplate> characterList;

	[HideInInspector]
	public int selectedCharacter;

	private void Start()
	{
		selectedCharacter = 0;

		characterNameText.text = characterList[selectedCharacter].characterName;
		backgroundImage.color = characterList[selectedCharacter].backgroundColor;
		characterArtImage.sprite = characterList[selectedCharacter].characterArt;
	}

	public void Previous()
	{
		selectedCharacter--;

		if (selectedCharacter >= 0)
		{
			characterNameText.text = characterList[selectedCharacter].characterName;
			backgroundImage.color = characterList[selectedCharacter].backgroundColor;
			characterArtImage.sprite = characterList[selectedCharacter].characterArt;
		}
		else
        {
			selectedCharacter = 0;
		}
	}

	public void Next()
	{
		selectedCharacter++;

		if (selectedCharacter < characterList.Count)
		{
			characterNameText.text = characterList[selectedCharacter].characterName;
			backgroundImage.color = characterList[selectedCharacter].backgroundColor;
			characterArtImage.sprite = characterList[selectedCharacter].characterArt;
		}
		else
		{
			selectedCharacter = characterList.Count - 1;
		}
	}
}
