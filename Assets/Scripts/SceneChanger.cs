using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string targetSceneName;
	public void NextScene()
	{
		// 読み込むシーンの名前を直接指定
		SceneManager.LoadSceneAsync(targetSceneName);
	}
}