using System.Linq;

namespace Patterns.Structural.Facade
{
  internal static class CarBuilder
  {
    public static RigidBody Build()
    {
      var vehicleBody = new RigidBody();

      var wheels = new[]
      {
        new RigidBody(),
        new RigidBody(),
        new RigidBody(),
        new RigidBody()
      };

      var wheelSprings = new[]
      {
        new Spring(),
        new Spring(),
        new Spring(),
        new Spring()
      };

      wheelSprings
        .ToList()
        .ForEach(ws => ws.AttachToPoint1(vehicleBody));

      for (int i = 0; i < 4; i++)
      {
        wheelSprings[i].AttachToPoint2(wheels[i]);
      }

      return vehicleBody;
    }
  }
}
