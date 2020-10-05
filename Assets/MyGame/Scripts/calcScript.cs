using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class calcScript : MonoBehaviour
{
    public Button nxtbtn;
    public InputField numb1;
    public InputField numb2;
    public Text solution;
    public Button calc;

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }


    private int addNumbers()
    {
        int tempResult = int.Parse(numb1.text) + int.Parse(numb2.text);
        return tempResult;
    }

    public void SetResult()
    {
        solution.text = addNumbers().ToString();
    }
}
