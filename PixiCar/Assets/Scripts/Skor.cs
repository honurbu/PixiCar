using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{

    public Text skorYazi,rekorYazi;
    private float skor;
    private int rekor;
    private void Start() {
        rekor=PlayerPrefs.GetInt("Rekor");//Oyun ilk açıldığında Rekor anahtar keyini locale storage'ten al rekora eşitle
        rekorYazi.text="Rekor:"+rekor;
      
    }
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null )
        {
            skor += 1 * Time.deltaTime;
            skorYazi.text = (int)skor+"";
           
        }
         setPlayerData();

    }
    private void setPlayerData(){
        if(skor>rekor){//Eğer kullanıcının skoru rekoru geçerse bunu yap:
            rekor=(int)(skor);
            PlayerPrefs.SetInt("Rekor",rekor);//Skorun int değerini Rekor anahtar keyiyle sakla
            rekorYazi.text="Rekor:"+rekor; // ekrana yazdır
        }
    }
}
