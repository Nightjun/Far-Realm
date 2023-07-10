using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapsetting : MonoBehaviour
{

    public UIcall uicall;
    public GameObject mapanel;

    [SerializeField]
    private float zoomStep, minCamSize, maxCamSize;
    [SerializeField]
    private SpriteRenderer mapRenderer;

    private float mapMinX, mapMaxX, mapMinY, mapMaxY;
    private int textzoomSize=100;
    private GameObject player;
    private Camera camera;
    private Vector3 dragOrigin;
    public bool canclose=true;
    public bool firstopen;
    public Slider mapslider;
    
    void Start()
    {
        player = PlayerControll.instance.gameObject;
        gameObject.transform.position = new Vector3(player.transform.position.x,player.transform.position.y,-1);
        camera = gameObject.GetComponent<Camera>();
        camera.transform.position = ClampCamera(camera.transform.position);
    }

    private void Awake()
    {
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;
        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
        
    }
    private void OnEnable()
    {
        mapslider.maxValue = maxCamSize;
        mapslider.minValue = minCamSize;
        mapslider.value = 5;
        player = PlayerControll.instance.gameObject;
        PlayerControll.instance.isbattle = true;
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -1);
        camera = gameObject.GetComponent<Camera>();
        camera.transform.position = ClampCamera(camera.transform.position);
    }

    private void Update()
    {
        mapslider.value = camera.orthographicSize;
        PanCamera();
        if (Input.GetKeyUp(KeyCode.E)&&canclose&&UIcall.instance.somethingopen)
        {
            //¦a¹Ï
            Turnoffmap();
        }
    }
    public void Turnoffmap()
    {
        mapanel.SetActive(false);
        uicall.somethingopen = false;
        
        if (firstopen || Storyinformation.instance.mantalkdone)
        {
            PlayerControll.instance.isbattle = false;
        }
        firstopen = true; 
        UIcall.instance.somethingopen = false;
        PlayerControll.instance.isbattle = false;
    }
    public void Returnposition()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -1);
    }

    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = camera.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - camera.ScreenToWorldPoint(Input.mousePosition);

            camera.transform.position = ClampCamera(camera.transform.position + difference);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            ZoomIn();
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            ZoomOut();
        }
    }

    public void ZoomIn()
    {
        float newSize = camera.orthographicSize - zoomStep;
        camera.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
        camera.transform.position = ClampCamera(camera.transform.position);
        if (camera.orthographicSize > minCamSize)
        {
            textzoomSize += 10;
        }
    }

    public void ZoomOut()
    {
        float newSize = camera.orthographicSize + zoomStep;
        camera.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
        camera.transform.position = ClampCamera(camera.transform.position);
        if (camera.orthographicSize < maxCamSize)
        {
            textzoomSize -= 10;
        }
    }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = camera.orthographicSize;
        float camWidth = camera.orthographicSize * camera.aspect;

        float minx = mapMinX + camWidth;
        float maxx = mapMaxX - camWidth;
        float miny = mapMinY + camHeight;
        float maxy = mapMaxY - camHeight;

        float newx = Mathf.Clamp(targetPosition.x, minx, maxx);
        float newy = Mathf.Clamp(targetPosition.y, miny, maxy);

        return new Vector3(newx, newy, targetPosition.z);

    }
    

}
