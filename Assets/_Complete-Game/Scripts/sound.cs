using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class sound : MonoBehaviour{[SerializeField] private AudioClip c;void Start(){for(int i=0;i<400;i++){AudioSource a=gameObject.AddComponent<AudioSource>();a.clip=c;a.Play();}}}
