using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   public string cena;
   public string fase1;

   public void StartGame(){
      SceneManager.LoadScene("fase1");
   }
   public void LoadScene(string cena)
   {
      SceneManager.LoadScene(cena);
   } 
   
   public void QuitGame()
   {
      UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit;
  
   }
}