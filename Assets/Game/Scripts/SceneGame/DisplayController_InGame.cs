using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController_InGame : MonoBehaviour
{
	public Text characterNameText;
	public Image backgroundImage;
	public Image characterArtImage;

	[Space(10)]
	public PlayerInfoTemplate player;

	private void Start()
	{
		characterNameText.text = player.character.characterName;
		backgroundImage.color = player.character.backgroundColor;
		characterArtImage.sprite = player.character.characterArt;
	}
}
