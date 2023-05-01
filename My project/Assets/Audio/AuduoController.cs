using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuduoController : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourseMenu;
    [SerializeField] private AudioSource _audioSourseGame;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        _audioSourseGame.Stop();

        //if (_audioSourseMenu.isPlaying)
        //{
        //    _audioSourseGame.Play();
        //    _audioSourseMenu.Pause();
        //}
    }

    public void OnplayAudioMenu()
    {
        _audioSourseMenu.Play();
    }

    public void OnStopAudioMenu()
    {
        _audioSourseMenu.Pause();
    }

    public void OnplayAudioGame()
    {
        DontDestroyOnLoad(this);
        _audioSourseGame.Play();
    }

    public void OnStopAudioGame()
    {
        
        _audioSourseGame.Pause();
    }


}
