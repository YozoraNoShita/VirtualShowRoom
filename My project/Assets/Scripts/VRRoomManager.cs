using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRoomManager : MonoBehaviour
{
    public GameObject floor_01_pos;
    public GameObject floor_02_pos;
    public GameObject VRCharacter;

    public AudioClip[] audioClips; // MP3 클립들을 저장할 배열
    private AudioSource audioSource;

    public GameObject[] MannequinCloth = new GameObject[18];
    public int MannequinClothIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        ResetCloth();
        MannequinCloth[MannequinClothIndex].SetActive(true);
        audioSource = GetComponent<AudioSource>();
        PlayRandomSound();
    }

    private void PlayRandomSound()
    {
        if (audioClips.Length > 0)
        {
            int randomIndex = Random.Range(0, audioClips.Length);
            audioSource.clip = audioClips[randomIndex];
            audioSource.Play();

            // 사운드가 끝나면 다시 재생
            Invoke("PlayRandomSound", audioSource.clip.length);
        }
    }
        

    public void ResetCloth()
    {
        for (int i = 0; i < MannequinCloth.Length; i++)
        {
            MannequinCloth[i].SetActive(false);
        }
    }

    public void ClothLeft()
    {
        ResetCloth();

        MannequinClothIndex--;

        if(MannequinClothIndex < 0)
        {
            MannequinClothIndex = MannequinCloth.Length - 1;
        }

        MannequinCloth[MannequinClothIndex].SetActive(true);
    }

    public void ClothRight()
    {
        ResetCloth();

        MannequinClothIndex++;

        if(MannequinClothIndex >= MannequinCloth.Length - 1)
        {
            MannequinClothIndex = 0;
        }

        MannequinCloth[MannequinClothIndex].SetActive(true);
    }

    public void Move2F()
    {
        VRCharacter.transform.position = floor_02_pos.transform.position;
        VRCharacter.transform.rotation = floor_02_pos.transform.rotation;
    }

    public void Move1F()
    {
        VRCharacter.transform.position = floor_01_pos.transform.position;
        VRCharacter.transform.rotation = floor_02_pos.transform.rotation;
    }
}
