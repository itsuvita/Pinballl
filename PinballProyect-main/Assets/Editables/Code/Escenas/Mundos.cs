using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mundos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Mundo1()
    {
        SceneManager.LoadScene("Scene01");
    }
    public void Mundo2()
    {
        SceneManager.LoadScene("Scene02");
    }
    public void Mundo3()
    {
        SceneManager.LoadScene("Scene03");
    }


}
