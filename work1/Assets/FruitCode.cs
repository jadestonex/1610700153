using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitCode : MonoBehaviour
{
    public Text newText;

    public Image imageFruit;

    public List<string> itemList = new List<string>();

    public List<Sprite> images = new List<Sprite>();


    public Sprite cherry;
    public Sprite grape;
    public Sprite kiwi;
    public Sprite mango;
    public Sprite lemon;

    // Start is called before the first frame update
    void Start()
    {
        images.Add(cherry);
        images.Add(grape);
        images.Add(kiwi);
        images.Add(mango);
        images.Add(lemon);

        itemList.Add("Cherry");
        itemList.Add("Grape");
        itemList.Add("Kiwi");
        itemList.Add("Mango");
        itemList.Add("Lemon");

        newText.text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

    }

    // Update is called once per frame

    void Update()
    {

        

        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            imageFruit.GetComponent<Image>().sprite = images[0];
            itemList.RemoveAt(0);
            images.RemoveAt(0);
            itemList.Add("");

        }

        foreach (string str in itemList)
        {
            newText.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

        }

    }


}