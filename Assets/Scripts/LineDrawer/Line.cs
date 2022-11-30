using UnityEngine;
using System.Collections.Generic;


namespace LineDrawer {
	public class Line : MonoBehaviour {

		[SerializeField]
		private LineRenderer lineRenderer;

		[SerializeField]
		private EdgeCollider2D edgeCollider;

		[SerializeField]
		private Rigidbody2D rigidBody;

		[SerializeField]
		private float pointsMinDistance = 0.1f;

		internal int pointsCount = 0;

		private List<Vector2> _points = new List<Vector2>();
		private float _circleColliderRadius;

		public void AddPoint(Vector2 newPoint) {

			if (pointsCount >= 1 && Vector2.Distance(newPoint, GetLastPoint()) < pointsMinDistance) {
				return;
			}

			_points.Add(newPoint);
			pointsCount++;

			CircleCollider2D circleCollider = gameObject.AddComponent<CircleCollider2D>();
			circleCollider.offset = newPoint;
			circleCollider.radius = _circleColliderRadius;


			lineRenderer.positionCount = pointsCount;
			lineRenderer.SetPosition(pointsCount - 1, newPoint);

			if (pointsCount > 1) {
				edgeCollider.points = _points.ToArray();
			}
		}

		public void UsePhysics(bool usePhysics) {
			// isKinematic = true;
			rigidBody.isKinematic = !usePhysics;
		}

		public void SetLineColor(Gradient colorGradient) {
			lineRenderer.colorGradient = colorGradient;
		}

		public void SetPointsMinDistance(float distance) {
			pointsMinDistance = distance;
		}

		public void SetLineWidth(float width) {
			lineRenderer.startWidth = width;
			lineRenderer.endWidth = width;

			_circleColliderRadius = width / 2f;

			edgeCollider.edgeRadius = _circleColliderRadius;
		}

		private Vector2 GetLastPoint() {
			return (Vector2)lineRenderer.GetPosition(pointsCount - 1);
		}

	}
}
