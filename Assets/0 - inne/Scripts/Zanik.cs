using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zanik : MonoBehaviour
{

    // Camera Information
    public Transform cameraTransform;
    private Vector3 orignalCameraPos;

    // Shake Parameters
    public float shakeDuration = 2f;
    public float shakeAmount = 0.7f;

    private bool canShake = false;
    private float _shakeTimer;


    public float time;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
            Invoke("Znikniecie", time);
            //ShakeCamera();
    }


    void Znikniecie()
    {
        Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        orignalCameraPos = cameraTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
        }

        if (canShake)
        {
            StartCameraShakeEffect();
        }
    }

    public void ShakeCamera()
    {
        canShake = true;
        _shakeTimer = shakeDuration;
    }

    public void StartCameraShakeEffect()
    {
        if (_shakeTimer > 0)
        {
            cameraTransform.localPosition = orignalCameraPos + Random.insideUnitSphere * shakeAmount;
            _shakeTimer -= Time.deltaTime;
        }
        else
        {
            _shakeTimer = 0f;
            cameraTransform.position = orignalCameraPos;
            canShake = false;
        }
    }
}