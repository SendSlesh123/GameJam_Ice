using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishScript : MonoBehaviour
{
    public static FinishScript singleton;

    public List<FloorStript> floorStripts;

    public TextMeshProUGUI lostText;
    public int destroyed;
    public UI ui;

    private bool canFinished = false;
    [SerializeField] private GameObject effect;

    private void Awake()
    {
        singleton = this;
    }
    private void Start()
    {
        FloorStript[] all = FindObjectsByType<FloorStript>(FindObjectsSortMode.None);

        foreach (FloorStript comp in all)
        {
            floorStripts.Add(comp);
        }
        destroyed = floorStripts.Count;
    }

    private void Update()
    {
        lostText.text = "lost: " + floorStripts.Count.ToString();
        if (floorStripts.Count == 0 && !canFinished)
        {
            canFinished = true;
            effect.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            if (floorStripts.Count == 0)
            {
                ui.ShowWinPanel(destroyed, destroyed);
            }
        }
    }
}
