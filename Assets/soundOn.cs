using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class soundOn : MonoBehaviour
{
    public soundOff soundOff;

    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.volume == 0)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void actionSoundOn()
    {
        gameObject.SetActive(false);
        soundOff.show();

        AudioListener.volume = 0;
    }
    public void show()
    {
        gameObject.SetActive(true);

        AudioListener.volume = 0;
    }
}
