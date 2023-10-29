using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour
{
    public float cutsceneTime;
    public Animator BlackOut;
    void Start()
    {
        StartCoroutine(cutSceneNum());
    }
    IEnumerator cutSceneNum()
    {
        yield return new WaitForSeconds(cutsceneTime);
        BlackOut.SetTrigger("Change");
        SceneManager.LoadScene(2);
    }
    
}
