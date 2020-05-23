using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchivementBadge : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI instructionText;
    [Multiline]
    [SerializeField] string textOfInstruction;
    [SerializeField] Image badgeBackground;
    [SerializeField] Image badge;
    [SerializeField] bool isCompleted;

}
