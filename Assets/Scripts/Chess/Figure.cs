using UnityEngine;

namespace Chess
{
    [CreateAssetMenu(fileName = "Figure", menuName = "Chess/Figure", order = 0)]
    public class Figure : ScriptableObject
    {
        [SerializeField] private FigureType figureType;
        [SerializeField] private GameObject prefab;
        [SerializeField] private int numberOfFigures;
        [SerializeField] private FigureMoves figureMoves;
        [SerializeField] private Material[] skins;
        
        public GameObject Prefab => prefab;
        public Material[] Skins => skins;
        public int NumberOfFigures => numberOfFigures;
        public FigureType FigureType => figureType;
        public FigureMoves FigureMoves => figureMoves;
    }
}