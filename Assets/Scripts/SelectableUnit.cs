using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class SelectableUnit : MonoBehaviour
{
    private NavMeshAgent Agent;
    [SerializeField]
    //private SpriteRenderer SelectionSprite;
    private GameObject SelectionSprite;

    public AudioSource source;
    public AudioClip clip;

    private void Awake()
    {
        SelectionManager.Instance.AvailableUnits.Add(this);
        Agent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 Position)
    {
        Agent.SetDestination(Position);
    }

    //Add anything that needs to be done upon selection, like animation trigger or voice line for example
    public void OnSelected()
    {
        SelectionSprite.gameObject.SetActive(true);
        source.PlayOneShot(clip);
    }

    //same as above but on deselect
    public void OnDeselected()
    {
        SelectionSprite.gameObject.SetActive(false);
    }
}
