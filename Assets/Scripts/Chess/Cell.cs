using UnityEngine;

namespace Chess
{
    [CreateAssetMenu(fileName = "Cell", menuName = "Chess/Cell", order = 0)]
    public class Cell : ScriptableObject
    {
        [SerializeField] private Vector3 posCell;
        [SerializeField] private Figure figure;
        [SerializeField] private FigureColor teamColor;

        public Vector3 PosCell => posCell;
        public Figure Figure => figure;
        public FigureColor TeamColor => teamColor;
    }
}