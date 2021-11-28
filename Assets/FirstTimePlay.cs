using System;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimePlay : MonoBehaviour
{
    [SerializeField] private GameObject tanismaObject;
    [SerializeField]
    private float counter = 0;
    private int pageIndex;
    [SerializeField] private GameObject[] pages;
    private String welcome = "AHE Bireysel emeklilik yolculuğuna hoşgeldin.Seni nasıl çağırmamı istersin ?";
    private String Intro_one = "AHE Bireysel emeklilik yolculuğuna tekrardan hoşgeldin ";
    private String Intro_two = ". Oncelikle Ekranda gördüğün yol senin emeklilik yolun.Karakterin bu yolda hergün bir adım atar.Bu yolda ilerlerken AHE'nin kullanıcılarına özel sunduğu ödülleri sana sorduğumuz küçük soruları yanıtlayarak kazanabilirsin.Hadi Bireysel Emeklilik yolundaki ilk adımını at ve küçük bir süpriz kazan.";
    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectOfType<AppManager>().user.FirstLogin)
        {
            Destroy(FindObjectOfType<FirstTimePlay>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            if (i == pageIndex)
            {
                pages[i].SetActive(true);
            }
            else
            {
                pages[i].SetActive(false);
            }
        }
        if (pageIndex == 0)
        {
            pages[0].GetComponentInChildren<Text>().text = welcome.Substring(0, (int) counter);
            if (counter < welcome.Length)
            {
                counter += .1f;
            }
            else
            {
                counter = welcome.Length;
            }

            if (Input.GetMouseButtonDown(0))
            {
                if ((int)counter != welcome.Length)
                {
                    counter = welcome.Length;   
                }
                else
                {
                    pageIndex++;
                    counter = 0;
                }
            }
        }else if (pageIndex == 2)
        {
            String fullString = Intro_one + FindObjectOfType<AppManager>().user.UserAvatarName + Intro_two;
            pages[2].GetComponentInChildren<Text>().text = fullString.Substring(0, (int) counter);
                
            int stringLenght = fullString.Length;
            if (counter < stringLenght)
            {
                counter += .2f;
            }
            else
            {
                counter = stringLenght;
            }
            if (Input.GetMouseButtonDown(0))
            {
                if ((int)counter != fullString.Length)
                {
                    counter = fullString.Length;   
                }
                else
                {
                    pageIndex++;
                    counter = 0;
                }
            }
        }
        else if (pageIndex == 3)
        {
            Destroy(tanismaObject);
            Destroy(this);
        }
    }

    public void NextPageButton()
    {
        pageIndex++;
    }

    public void GetUserName()
    {
        FindObjectOfType<AppManager>().user.SetUserAvatarName(GameObject.FindGameObjectWithTag("Tanisma").GetComponent<Text>().text);
    }
}
