using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds: MonoBehaviour
{
    [SerializeField] private GameObject[] _sparrow;
    [SerializeField] private float _interactionDistance = 6f;
    [SerializeField] private Transform _player;

    private void Update()
    {
        for (int i = 0; i < _sparrow.Length; i++)
        {
            if (Vector3.Distance(_player.transform.position, _sparrow[i].transform.position) < _interactionDistance)
            {
                _sparrow[i].gameObject.SetActive(true);
            }
        }
    }
}