using UnityEngine;


namespace LineDrawer {
	public class LinesDrawer : MonoBehaviour {

        [SerializeField]
        private GameObject linePrefab;
        [SerializeField]
        private LayerMask cantDrawOverLayer;

        [Space(30f)]
        [SerializeField]
        private Gradient lineColor;
        [SerializeField]
        private float linePointsMinDistance;
        [SerializeField]
        private float lineWidth;

        private Line _currentLine;

        private void Update() {
            if (Input.GetMouseButtonDown(0)) {
                BeginDraw();
            }

            if (_currentLine != null) {
                Draw();
            }

            if (Input.GetMouseButtonUp(0)) {
                EndDraw();
            }
        }

        private void BeginDraw() {
            _currentLine = Instantiate(linePrefab, this.transform).GetComponent<Line>();

            _currentLine.UsePhysics(false);
            _currentLine.SetLineColor(lineColor);
            _currentLine.SetPointsMinDistance(linePointsMinDistance);
            _currentLine.SetLineWidth(lineWidth);

        }

        private void Draw() {
            Vector2 mousePosition = MousePosition.GetPointerPosition2D();
            RaycastHit2D hit = Physics2D.CircleCast(mousePosition, lineWidth / 3f, Vector2.zero, 1f, cantDrawOverLayer);

            if (hit) {
                EndDraw();
                return;
            }

            _currentLine.AddPoint(mousePosition);
        }

        private void EndDraw() {

            if (_currentLine != null) {

                if (_currentLine.pointsCount < 2) {
                    Destroy(_currentLine.gameObject);
                    return;
                }

                _currentLine.UsePhysics(true);
                _currentLine = null;
            }
        }
    }
}
