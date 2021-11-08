using UnityEngine;

public class YellowBird : Bird
{
    [SerializeField]
    public float _boostForce = 100f;
    public bool hasBoost = false;

    public void Boost()
    {
        if (State == BirdState.Thrown && !hasBoost)
        {
            RigidBody.AddForce(RigidBody.velocity * _boostForce);
            hasBoost = true;
        }
    }
    public override void OnTap()
    {
        Boost();
    }
}