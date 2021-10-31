using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public PlayerInfoTemplate player;
	public DisplayController_InSelection displayController;

	public void SaveCharacter()
	{
		player.character = displayController.characterList[displayController.selectedCharacter];
		NextScene();
	}

	public void NextScene()
	{
		SceneManager.LoadScene("Game");
	}
}
