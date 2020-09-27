using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colorScript : MonoBehaviour
{
    public Button btn;
    public Image img;
    public Color orangeyellow;
    // Start is called before the first frame update
    void Start()
    {
        orangeyellow = new Color(1.0f, 205 / 255f, 25 / 255f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            img.GetComponent<Image>().color = orangeyellow;
        }
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
