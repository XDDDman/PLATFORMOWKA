using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class soundOff : MonoBehaviour
{
    public soundOn soundOn;

    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.volume == 1)
        {
            gameObject.SetActive(false);
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void actionSoundOff()
    {
        gameObject.SetActive(false);
        soundOn.show();

        AudioListener.volume = 1;
    }
    public void show()
    {
        gameObject.SetActive(true);

        AudioListener.volume = 1;
    }
}
