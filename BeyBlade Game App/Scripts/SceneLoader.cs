using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
   
    private string sceneNameToBeLoaded;

    public void LoadScene(string sceneName)
    {
        sceneNameToBeLoaded = sceneName;


        StartCoroutine(InitializeSceneLoading());

    }

    IEnumerator InitializeSceneLoading()
    {
        //first we load the loading scene
        yield return SceneManager.LoadSceneAsync("Scene_Loading");
        //Load the actual scene
        StartCoroutine(LoadActualyScene());
    }

    IEnumerator LoadActualyScene()
    {
        var asyncSceneLoading = SceneManager.LoadSceneAsync(sceneNameToBeLoaded);
        //this value stops the scene from displaying when it is still loading
        asyncSceneLoading.allowSceneActivation = false;

        while (!asyncSceneLoading.isDone)
        {
            Debug.Log(asyncSceneLoading.progress);
            if (asyncSceneLoading.progress >= 0.9f)
            {
                //finally show the scene
                asyncSceneLoading.allowSceneActivation = true;
            }


            yield return null;
        }

        
    }


}
