using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chagethemoney : MonoBehaviour
{
    public Image[] image;
    public Sprite[] sprites;
    private string[] seperetmoney;
    private string moneyy;
    private int howmuch;
    
    public void howmuchmoney(int money)
    {
        seperetmoney = new string[image.Length];
        moneyy = money.ToString();
        howmuch = moneyy.Length;
        for (int i = 0; i < image.Length; i++)
        {
            seperetmoney[i] = "0";
        }
        for (int i = 0; i < moneyy.Length; i++)
        {
            seperetmoney[i] = moneyy.Substring((howmuch) - 1, 1);
            howmuch--;
        }
        


        for (int i = 0; i <seperetmoney.Length; i++)
        {
           switch(seperetmoney[i])
            {
                case "0":
                    image[i].sprite = sprites[0];
                    break;
                case "1":
                    image[i].sprite = sprites[1];
                    break;
                case "2":
                    image[i].sprite = sprites[2];
                    break;
                case "3":
                    image[i].sprite = sprites[3];
                    break;
                case "4":
                    image[i].sprite = sprites[4];
                    break;
                case "5":
                    image[i].sprite = sprites[5];
                    break;
                case "6":
                    image[i].sprite = sprites[6];
                    break;
                case "7":
                    image[i].sprite = sprites[7];
                    break;
                case "8":
                    image[i].sprite = sprites[8];
                    break;
                case "9":
                    image[i].sprite = sprites[9];
                    break;
            }
        }
    }

   
}
