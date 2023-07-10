using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class camerafindplayer : MonoBehaviour
{
    public static camerafindplayer instance;

    public float orthographcsize;

    private CinemachineVirtualCamera virtualCamera;
    private float shkeTimer;
    private void Awake()
    {
        instance = this;
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        virtualCamera.m_Lens.OrthographicSize = orthographcsize;
    }
    private void Start()
    {
        virtualCamera.Follow =GameObject.FindGameObjectWithTag("playercamera").transform;
    }

    public void ShakeCamera(float intensity,float time)
    {
        CinemachineBasicMultiChannelPerlin CBMC = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        CBMC.m_AmplitudeGain = intensity;
        shkeTimer = time;
    }

    private void Update()
    {
        if (shkeTimer > 0)
        {
            shkeTimer -= Time.deltaTime;
            if (shkeTimer <= 0f)
            {
                CinemachineBasicMultiChannelPerlin CBMC = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                CBMC.m_AmplitudeGain = 0f;
            }
        }
    }


}
