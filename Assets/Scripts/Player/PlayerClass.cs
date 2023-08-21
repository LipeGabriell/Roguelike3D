using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    private GameObject _playerMesh;
    [SerializeField] private GameObject[] classPrefabs;

    public enum Classes
    {
        Knight,
        Mage,
        Barbarian,
        Rogue
    }

    [field: SerializeField] public Classes selectedClass { get; private set; }

    private void Start()
    {
        ChangeClass();
    }

    private void ChangeClass()
    {
        Destroy(_playerMesh);
        switch (selectedClass)
        {
            case Classes.Knight:
                _playerMesh = Instantiate(classPrefabs[0], gameObject.transform.GetChild(0));
                break;
            case Classes.Mage:
                _playerMesh = Instantiate(classPrefabs[1], gameObject.transform.GetChild(0));
                break;
            case Classes.Barbarian:
                _playerMesh = Instantiate(classPrefabs[2], gameObject.transform.GetChild(0));
                break;
            case Classes.Rogue:
                _playerMesh = Instantiate(classPrefabs[3], gameObject.transform.GetChild(0));
                break;
            default:
                Debug.LogError("Erro ao selecionar classe!");
                break;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedClass = Classes.Knight;
            ChangeClass();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedClass = Classes.Mage;
            ChangeClass();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedClass = Classes.Barbarian;
            ChangeClass();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selectedClass = Classes.Rogue;
            ChangeClass();
        }
    }
}