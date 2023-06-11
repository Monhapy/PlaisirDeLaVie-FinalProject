using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicNoteCode : MonoBehaviour
{
    public AudioSource A_Note;
    public AudioSource B_Note;
    public AudioSource C_Note;
    public AudioSource D_Note;
    public AudioSource E_Note;


    public void A_Note_Play()
    {
        A_Note.Play();
        Invoke("SahneGeçiþ", 2f);

    }
    public void B_Note_Play()
    {
        B_Note.Play();
    }
    public void C_Note_Play()
    {
        C_Note.Play();
    }
    public void D_Note_Play()
    {
        D_Note.Play();
    }
    public void E_Note_Play()
    {
        E_Note.Play();
    }
    private void SahneGeçiþ()
    {
        SceneManager.LoadScene(24);
    }

}
