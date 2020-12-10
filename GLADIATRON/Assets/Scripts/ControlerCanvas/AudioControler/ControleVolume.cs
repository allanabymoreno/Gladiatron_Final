using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleVolume : MonoBehaviour
{
    public float volumeMax, volumeFX, volumeMusica;
    public Slider sliderMax, sliderFX, sliderMusica;


    // Start is called before the first frame update
    void Start()
    {
        sliderMax.value = PlayerPrefs.GetFloat("SMax");
        sliderFX.value = PlayerPrefs.GetFloat("SFx");
        sliderMusica.value = PlayerPrefs.GetFloat("SMusicas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VolumeMaximo(float volume)
    {
        volumeMax = volume;
        AudioListener.volume = volumeMax;
        PlayerPrefs.SetFloat("SMax", volumeMax); 
    }
    public void volumeFx(float volume)
    {
        volumeFX = volume;
        GameObject[] Fxs = GameObject.FindGameObjectsWithTag("Fx");
        for(int i=0; i<Fxs.Length; i++)
        {
            Fxs[i].GetComponent<AudioSource>().volume = volumeFX;
        }
        PlayerPrefs.SetFloat("SFx", volumeFX);
    }
    public void VolumeMusicas(float volume)
    {
        volumeMusica = volume;
        GameObject[] Music = GameObject.FindGameObjectsWithTag("Musicas");
        for (int i = 0; i < Music.Length; i++)
        {
            Music[i].GetComponent<AudioSource>().volume = volumeMusica;
        }
        PlayerPrefs.SetFloat("SMusicas", volumeMusica);
    }
}
