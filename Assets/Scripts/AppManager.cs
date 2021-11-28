using System;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class AppManager : MonoBehaviour
{
    public User user;
    [SerializeField] private GameObject userObject;
    [SerializeField] private int passedDay;
    
    public List<Vector3> roadPositions;

    [SerializeField] private List<GameObject> roadObjects;

    [SerializeField] private GameObject originalRoadObject;

    public float screenOffSetY;

    private float mouseY, lastMouseY;
    // Start is called before the first frame update
    void Awake()
    {
        SignIn();
        InitMap();
    }

    // Update is called once per frame
    void Update()
    {
        userObject.transform.position = new Vector3(roadPositions[passedDay % 31].x, roadPositions[passedDay % 31].y + screenOffSetY,
            userObject.transform.position.z);
            
        userObject.transform.SetAsLastSibling();
        
        if (Input.GetMouseButtonDown(0))
        {
            mouseY = Input.mousePosition.y;
            lastMouseY = mouseY;
        }

        if (Input.GetMouseButton(0))
        {
            mouseY = Input.mousePosition.y;
            screenOffSetY += -(lastMouseY - mouseY) / 100;
            lastMouseY = mouseY;
        }

        for (int i = 0; i < 30; i++)
        {
            roadObjects[i].transform.position = new Vector2(roadPositions[i].x, roadPositions[i].y + screenOffSetY);
        }
        

    }

    private void SignIn()
    {
        user = new User("Eagle", "Team", "48579985656", UInt16.MaxValue);
    }

    private void InitMap()
    {/*
        int totalDay = (user.PlanEndDate[0] - user.PlanStartDate[0]) + (user.PlanEndDate[1] - user.PlanStartDate[1]) * 30 +
                       (user.PlanEndDate[2] - user.PlanStartDate[2]) * 365;
        // Burada islem dogru bir sonuc dondurmuyor ayların arasındakı gun farkı veya 4 yılda bır gelen subat +1 gun olması
        // Bunlar bu ıslemde sonuca katılmamıstır.
        String[] todayS = DateTime.UtcNow.ToShortDateString().Split('.');
        int[] today = new int[] {0, 0, 0};
        for (int i = 0; i < 3; i++)
        {
            today[i] = int.Parse(todayS[i]);
        }

        int remainingDay = (user.PlanEndDate[0] - today[0]) + (user.PlanEndDate[1] - today[1]) * 30 +
                           (user.PlanEndDate[2] - today[2]) * 365;
        
        passedDay = (today[0] - user.PlanStartDate[0]) + (today[1] - user.PlanStartDate[1]) * 30 +
                        (today[2] - user.PlanStartDate[2]) * 365;
*/
        passedDay = 0;
        for (int i = 0; i < 30; i++)
        {
            // Start Y = -4.5f
            // Between X = -2.25f _ +2.25f
            // DY = 1.5f
            roadPositions.Add(new Vector2(UnityEngine.Random.Range(-2.25f, 2.25f), -4.5f + 1.5f * i));
            roadObjects.Add(Instantiate(originalRoadObject, roadPositions[i], Quaternion.identity));
        }
    }
}
