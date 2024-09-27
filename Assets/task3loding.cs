using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class task3loding : MonoBehaviour
{
    public Slider slider;
    public GameObject loadingScreen;
    public void Loading(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        BoM_CharacterController.taskNumber = 3;

    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
