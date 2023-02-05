using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {
    
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _devScream;
    [SerializeField] AudioClip _scream2;
    [SerializeField] AudioClip _scream3;
    [SerializeField] private Animator _animator;
    private List<Tuple<String, AudioClip>> _screams = new List<Tuple<string, AudioClip>>();
    
    bool _isScreaming = false;

    private void Start() {
        _screams.Add(new Tuple<string, AudioClip>("Scream1", _devScream));
        _screams.Add(new Tuple<string, AudioClip>("Scream2", _scream2));
        _screams.Add(new Tuple<string, AudioClip>("Scream3", _scream3));
    }

    void Update() {
        
        // If player presses w actiavte animation trigger "Scream1", e for "Scream2", r for "Scream3"
        if (Input.GetKeyDown(KeyCode.W)) {
            _animator.SetTrigger("Scream1");
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            _animator.SetTrigger("Scream2");
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            _animator.SetTrigger("Scream3");
        }
        
    }

    public void FrogScream() {
        // This method will be triggered by a UI button. 
        // When run, trigger a random scream and play audio clip from the list.
        // Run play random scream coroutine
        StartCoroutine(PlayRandomScream());
    }
    
    // coroutine to play random scream, wont run if already playing, resets bool when done
    IEnumerator PlayRandomScream() {
        if (!_isScreaming) {
            _isScreaming = true;
            int randomScream = UnityEngine.Random.Range(0, _screams.Count);
            _animator.SetTrigger(_screams[randomScream].Item1);
            yield return new WaitForSeconds(_screams[randomScream].Item2.length);
            _isScreaming = false;
        }
    }

    public void ScreamDev() {
        _audioSource.PlayOneShot(_devScream);
    }
    
    public void ScreamTwo() {
        _audioSource.PlayOneShot(_scream2);
    }
    
    public void ScreamThree() {
        _audioSource.PlayOneShot(_scream3);
    }
}
